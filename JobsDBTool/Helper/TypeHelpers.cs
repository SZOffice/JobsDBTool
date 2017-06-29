using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace JobsDBTool.Helper
{
    public class TypeHelpers
    {
        public static List<PropertyInfo> GetClassProperties<TIndexField>()
        {
            //get all properties from TIndexField and base interface
            PropertyInfo[] instancePropertyInfos =
                typeof(TIndexField).GetProperties(BindingFlags.Public | BindingFlags.Instance |
                                                   BindingFlags.FlattenHierarchy);

            Type[] interfaceTypes = typeof(TIndexField).GetInterfaces();
            List<PropertyInfo> allPropertyInfos = new List<PropertyInfo>();
            foreach (Type type in interfaceTypes)
            {
                allPropertyInfos.AddRange(type.GetProperties());
            }
            allPropertyInfos.AddRange(instancePropertyInfos);
            List<PropertyInfo> distinctPropertyInfos = new List<PropertyInfo>();
            foreach (PropertyInfo pi in allPropertyInfos)
            {
                var piCurrent = distinctPropertyInfos.SingleOrDefault(i => i.Name.Equals(pi.Name, StringComparison.OrdinalIgnoreCase));
                if (null == piCurrent)
                {
                    distinctPropertyInfos.Add(pi);
                }
            }
            return distinctPropertyInfos;
        }
    }
}
