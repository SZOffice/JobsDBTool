using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections;

namespace JobsDBTool.Helper
{
    public class IndexFieldFactorySolrNet
    {
        public static string ObjectToXml<T>(T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringBuilder sbXml = new StringBuilder();

            serializer.Serialize(new StringWriter(sbXml), obj);
            return sbXml.ToString();
        }

        public static T XmlToObject<T>(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlTextReader reader = new XmlTextReader(new StringReader(xml));

            T obj = (T)serializer.Deserialize(reader);
            return obj;
        }
        
        public static string ComposeIndexFieldXml<TIndexField>(IList<TIndexField> indexFields, bool includeAddNode)
        {
            return ComposeIndexFieldXml<TIndexField>(indexFields, includeAddNode, null, OperateMethod.None);
        }
        public static string ComposeIndexFieldXml<TIndexField>(IList<TIndexField> indexFields, bool includeAddNode, IList<string> atomFields, OperateMethod operateMethod)
        {
            string result = Serialize(indexFields, atomFields, operateMethod);

            if (includeAddNode)
            {
                result = new StringBuilder().Append("<?xml version='1.0' encoding='UTF-8' ?><add overwrite=\"true\">")
                                            .Append(result)
                                            .Append("</add>").ToString();
            }

            return result;
        }

        public static string Serialize<TIndexField>(IList<TIndexField> indexFields)
        {
            return Serialize<TIndexField>(indexFields, null, OperateMethod.None);
        }
        public static string Serialize<TIndexField>(IList<TIndexField> indexFields, IList<string> atomFields, OperateMethod operateMethod)
        {
            StringBuilder result = new StringBuilder();

            List<PropertyInfo> distinctPropertyInfos = TypeHelpers.GetClassProperties<TIndexField>();

            foreach (var indexField in indexFields)
            {
                StringBuilder sbXml = new StringBuilder();
                string coreName = string.Empty;
                bool isSearchableRecord = true;

                sbXml.Append("<doc>");
                foreach (PropertyInfo pi in distinctPropertyInfos)
                {
                    if (pi.PropertyType.IsValueType
                            || pi.PropertyType == typeof(string)
                            || (pi.PropertyType.IsGenericType && pi.PropertyType.GetGenericTypeDefinition() == typeof(IList<>)))
                    {
                        var piValue = pi.GetValue(indexField, null);
                        string piName = pi.Name.ToLower();
                        bool isSearchableRecordField = pi.Name.Equals("IsSearchableRecord", StringComparison.OrdinalIgnoreCase);

                        if (isSearchableRecordField)
                        {
                            isSearchableRecord = Convert.ToBoolean(piValue);
                            if (!isSearchableRecord)
                            {
                                break;
                            }
                        }

                        if (!isSearchableRecordField && piValue != null)
                        {
                            string sAtomic = string.Empty;
                            if (operateMethod == OperateMethod.AtomSet && piName != "id" && atomFields.Contains(piName))
                            {
                                sAtomic = "update='set'";
                            }
                            else if (operateMethod == OperateMethod.AtomAdd && piName != "id" && atomFields.Contains(piName))
                            {
                                sAtomic = "update='add'";
                            }

                            //string jobsdb_text = CommonConfig.GetConfigValue(piName);
                            if (pi.PropertyType == typeof(DateTime) || pi.PropertyType == typeof(Nullable<DateTime>))
                            {
                                if (Convert.ToDateTime(piValue) != default(DateTime))
                                {
                                    string dateValue = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffffff}Z", piValue);
                                    sbXml.Append("<field name=\"" + piName + "\" " + sAtomic + ">").Append(dateValue).Append("</field>");
                                }
                            }
                            else if (pi.PropertyType == typeof(String))
                            {
                                string fieldValue = piValue.ToString().Trim();
                                
                                // prevents the field value contains cdata end tag, and breaks the xml document generated
                                // some job ad records really contains this char pattern
                                if (fieldValue.Contains("]]>"))
                                {
                                    fieldValue = fieldValue.Replace("]]>", "]]]]><![CDATA[>");
                                }

                                sbXml.Append("<field name=\"" + piName + "\" " + sAtomic + ">")
                                        .Append("<![CDATA[" + fieldValue + "]]>")
                                        .Append("</field>");
                            }
                            else if (pi.PropertyType.IsGenericType && pi.PropertyType.GetGenericTypeDefinition() == typeof(IList<>))
                            {
                                //var enumerator = ((IEnumerable)piValue).GetEnumerator();
                                //enumerator.Reset();
                                //while (enumerator.MoveNext())
                                //{
                                //    sbXml.Append("<field name=\"" + piName + "\">").Append(enumerator.Current).Append("</field>");
                                //}

                                IList objList = (IList)piValue;
                                foreach (var obj in objList)
                                {
                                    sbXml.Append("<field name=\"" + piName + "\" " + sAtomic + ">").Append(obj).Append("</field>");
                                }
                            }
                            else if (pi.PropertyType.IsArray)
                            {
                                ArrayList objList = (ArrayList)piValue;
                                foreach (var obj in objList)
                                {
                                    sbXml.Append("<field name=\"" + piName + "\" " + sAtomic + ">").Append(obj).Append("</field>");
                                }
                            }
                            else
                            {
                                sbXml.Append("<field name=\"" + piName + "\" " + sAtomic + ">").Append(piValue.ToString().Trim()).Append("</field>");
                            }
                        }
                    }
                }

                if (isSearchableRecord)
                {
                    sbXml.Append("</doc>");
                    
                    result.Append(sbXml.ToString());
                    
                }
            }

            return result.ToString();
        }

        public static IList<TIndexField> Deserialize<TIndexField>(IList<Dictionary<string, object>> solrResults)
            where TIndexField : new()
        {
            IList<TIndexField> result = new List<TIndexField>();

            List<PropertyInfo> distinctPropertyInfos = TypeHelpers.GetClassProperties<TIndexField>();

            foreach (var doc in solrResults)
            {
                TIndexField record = new TIndexField();

                foreach (PropertyInfo pi in distinctPropertyInfos)
                {
                    if (pi.PropertyType.IsValueType
                            || pi.PropertyType == typeof(string)
                            || (pi.PropertyType.IsGenericType && pi.PropertyType.GetGenericTypeDefinition() == typeof(IList<>))
                            || pi.PropertyType.IsArray)
                    {                        
                        string piName = pi.Name.ToLower();
                        if (!doc.ContainsKey(piName))
                        {
                            continue;
                        }
                        var piValue = doc[piName];
                        
                        if (piValue != null)
                        {
                            if (pi.PropertyType.IsGenericType && pi.PropertyType.GetGenericTypeDefinition() == typeof(IList<>))
                            {
                                IList objList = (IList)piValue;
                                if (objList != null)
                                {
                                    Type elementType = pi.PropertyType.GetGenericArguments()[0];
                                    if (elementType == typeof(string))
                                    {
                                        pi.SetValue(record, SetList<string>(objList), null);
                                    }
                                    else if (elementType == typeof(int))
                                    {
                                        pi.SetValue(record, SetList<int>(objList), null);
                                    }
                                    else if (elementType == typeof(long))
                                    {
                                        pi.SetValue(record, SetList<long>(objList), null);
                                    }
                                }
                            }
                            else if (pi.PropertyType.IsArray)
                            {
                                ArrayList objList = (ArrayList)piValue;
                                if (objList != null)
                                {
                                    Type elementType = pi.PropertyType.GetElementType();
                                    if (elementType == typeof(string))
                                    {
                                        pi.SetValue(record, (string[])((ArrayList)doc[piName]).ToArray(typeof(string)), null);
                                    }
                                    else if (elementType == typeof(int))
                                    {
                                        pi.SetValue(record, (int[])((ArrayList)doc[piName]).ToArray(typeof(int)), null);
                                    }
                                    else if (elementType == typeof(long))
                                    {
                                        pi.SetValue(record, (long[])((ArrayList)doc[piName]).ToArray(typeof(long)), null);
                                    }
                                }
                            }
							else if (!pi.PropertyType.IsGenericType)
							{
								pi.SetValue(record, Convert.ChangeType(doc[piName], pi.PropertyType), null);
							}
							else
							{
								//for like type: int?
								Type genericTypeDefinition = pi.PropertyType.GetGenericTypeDefinition();
								if (genericTypeDefinition == typeof(Nullable<>))
								{
									pi.SetValue(record, Convert.ChangeType(doc[piName], Nullable.GetUnderlyingType(pi.PropertyType)), null);
								}
							}
                        }
                    }
                }

                result.Add(record);
            }

            return result;
        }

        private static IList<T> SetList<T>(IList objList)
        {
            IList<T> list = new List<T>();
            foreach (var obj in objList)
            {
                list.Add((T)obj);
            }
            return list;
        } 

    }
}
