using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using EasyNet.Solr;
using EasyNet.Solr.Commons;
using System.Collections;

namespace JobsDBTool.Helper
{
    public enum OperateMethod
    {
        None=0,
        AtomAdd=1,
        AtomSet=2
    }
    public class SolrObjectSerializer<TIndexField> : IObjectSerializer<TIndexField>
    {
        public IEnumerable<SolrInputDocument> Serialize(IEnumerable<TIndexField> objs)
        {
            return Serialize(objs, null,  OperateMethod.None);
        }
        public IEnumerable<SolrInputDocument> Serialize(IEnumerable<TIndexField> objs, IList<string> atomFields, OperateMethod operateMethod)
        {
            if (objs == null)
            {
                yield return null;
            }

            List<PropertyInfo> distinctPropertyInfos = TypeHelpers.GetClassProperties<TIndexField>();
            
            foreach (var obj in objs)
            {
                var doc = new SolrInputDocument();

                foreach (PropertyInfo pi in distinctPropertyInfos)
                {
                    if (pi.PropertyType.IsValueType
                        || pi.PropertyType == typeof (string)
                        ||
                        (pi.PropertyType.IsGenericType && pi.PropertyType.GetGenericTypeDefinition() == typeof (IList<>)))
                    {
                        var piValue = pi.GetValue(obj, null);
                        string piName = pi.Name.ToLower();

                        if (OperateMethod.None == operateMethod || piName=="id")
                        {
                            doc.Add(piName, new SolrInputField(piName, piValue));
                        }
                        else {
                            bool isUpdate = false;
                            if (piValue != null)
                            {
                                if (pi.PropertyType == typeof(DateTime) || pi.PropertyType == typeof(Nullable<DateTime>))
                                {
                                    if (Convert.ToDateTime(piValue) != default(DateTime))
                                    {
                                        isUpdate = true;
                                    }
                                }
                                else
                                    isUpdate = true;
                            }

                            if (isUpdate)
                            {
                                var oper = new Hashtable();
                                if (operateMethod == OperateMethod.AtomAdd && atomFields.Contains(piName))
                                    oper.Add("add", piValue);
                                else if (operateMethod == OperateMethod.AtomSet && atomFields.Contains(piName))
                                    oper.Add("set", piValue);
                                doc.Add(piName, new SolrInputField(piName, oper));
                            }
                        }
                       
                    }
                }

                yield return doc;
            }
        }

    }

    public class SolrObjectDeSerializer<TIndexField> : IObjectDeserializer<TIndexField>
        where TIndexField:new()
    {
        public string GetString(SolrDocument doc, string name)
        {
            if (!doc.ContainsKey(name))
            {
                return string.Empty;
            }
            var docObject = doc[name];
            if (docObject == null)
            {
                return string.Empty;
            }
            return docObject.ToString();

        }

        public IEnumerable<TIndexField> Deserialize(SolrDocumentList result)
        {
            if (result == null)
            {
                yield return new TIndexField();
            }
            List<PropertyInfo> distinctPropertyInfos = TypeHelpers.GetClassProperties<TIndexField>();

            foreach (SolrDocument doc in result)
            {
                var record = new TIndexField();

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
                                    if(elementType == typeof(string))
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

                yield return record;
            }
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
