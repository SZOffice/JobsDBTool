using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace JobsDBTool.GetFiledId
{
    public class CamelCaseInputDataAliasMappingDictionary
    {
        HashSet<string> uniqueAliasClassNameSet = new HashSet<string>();
        HashSet<string> uniqueAliasPropertyNameSet = new HashSet<string>();

        private string Left(string s, int numberOfChar)
        {
            return s.Substring(0, numberOfChar);
        }

        private string Right(string s, int numberOfChar)
        {
            return s.Substring(s.Length - numberOfChar, numberOfChar);
        }

        private string GetAliasName(string className, int numberOfChar)
        {
            string camelcaseClassName = Regex.Replace(className, "([A-Z])", " $1").Trim();
            string[] items = camelcaseClassName.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            IList<string> aliasCamelCaseName = new List<string>();
            foreach (string s in items)
            {
                string name;
                if (s.Length / 2 >= numberOfChar)
                {
                    name = Left(s, numberOfChar) + Right(s, numberOfChar);
                }
                else
                {
                    name = s;
                }
                aliasCamelCaseName.Add(name);
            }
            return string.Join("", aliasCamelCaseName.ToArray<string>());
        }

        public string GetClassAliasName(string className)
        {
            int numberOfChar = 1;
            string classAliasName = GetAliasName(className, numberOfChar);

            while (uniqueAliasClassNameSet.Contains(classAliasName))
            {
                numberOfChar++;
                classAliasName = GetAliasName(className, numberOfChar);
            }
            uniqueAliasClassNameSet.Add(classAliasName);
            return classAliasName;
        }

        public string GetPropertyAliasName(string propertyName)
        {
            int numberOfChar = 1;
            string propertyAliasName = GetAliasName(propertyName, numberOfChar);
            while (uniqueAliasPropertyNameSet.Contains(propertyAliasName))
            {
                numberOfChar++;
                propertyAliasName = GetAliasName(propertyName, numberOfChar);
            }

            uniqueAliasPropertyNameSet.Add(propertyAliasName);
            return propertyAliasName + InputDataKeys.Dummy;
        }

    }
}
