using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace JobsDBTool.Helper
{
    public static class JsonConvertHelper
    {
        private static Hashtable jsonStringCache = new Hashtable();
        private static JsonSerializerSettings settings = new JsonSerializerSettings();

        class SerializableContractResolver : Newtonsoft.Json.Serialization.DefaultContractResolver
        {
            protected override IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
            {
                var properties = base.CreateProperties(type, memberSerialization);

                foreach (var p in properties)
                {
                    if (type.GetProperty(p.PropertyName) != null)
                    {
                        p.Ignored = false;
                    }
                    else
                    {
                        p.Ignored = true;
                    }
                }
                return properties;
            }

            protected override Newtonsoft.Json.Serialization.JsonContract CreateContract(Type objectType)
            {
                var contract = base.CreateContract(objectType);

                if (contract is Newtonsoft.Json.Serialization.JsonStringContract)
                    return CreateObjectContract(objectType);
                return contract;
            }
        }

        public class DynamicContractResolver : Newtonsoft.Json.Serialization.DefaultContractResolver
        {
            private IList<string> _propertiesToSerialize = null;

            public DynamicContractResolver(IList<string> propertiesToSerialize)
            {
                _propertiesToSerialize = propertiesToSerialize;
            }

            protected override IList<JsonProperty> CreateProperties(Type type, Newtonsoft.Json.MemberSerialization memberSerialization)
            {
                IList<JsonProperty> properties = base.CreateProperties(type, memberSerialization);
                return properties.Where(p => _propertiesToSerialize.Contains(p.PropertyName)).ToList();
            }
        }

        static JsonConvertHelper()
        {
            settings.ContractResolver = new SerializableContractResolver();
        }

        public static string ToJSON(this object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.None, settings);
        }

        public static string ToJSONWithCaching(this object obj, string cacheKey)
        {
            string result;

            result = jsonStringCache[cacheKey] as string;
            if (result == null)
            {
                lock (jsonStringCache)
                {
                    result = jsonStringCache[cacheKey] as string;
                    if (result == null)
                    {
                        result = obj.ToJSON();
                        jsonStringCache[cacheKey] = result;
                    }
                }
            }
            return result;
        }

        public static string ToJsonNullIgnore(this object obj)
        {
            var serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            var result = new StringBuilder();
            using (var sw = new StringWriter(result))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);
            }
            return result.ToString();
        }

        public static T FromJSON<T>(this string json)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(json));

            List<string> propertiesList = new List<string>();
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                    propertiesList.Add("" + reader.Value);
            }

            string convertedJson = json;
            foreach (string key in propertiesList)
            {
                string newKey = key;
                newKey = newKey.Substring(0, 1).ToUpper() + newKey.Substring(1);
                convertedJson = convertedJson.Replace("\"" + key + "\"", "\"" + newKey + "\"");
            }

            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            T deserialedObject = (T)serializer.Deserialize(new StringReader(convertedJson), typeof(T));
            return deserialedObject;
        }

        public static List<int> ToIntList(this string idListString)
        {
            if (!string.IsNullOrEmpty(idListString))
            {
                //Handling Json string array [\"1\",\"2\"]
                //Some code we wrote may use this custom format 1,2,3
                string intListString = idListString.Replace("[", "").Replace("]", "").Replace("\"", "");
                string[] intStringArray = intListString.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                var intList = new List<int>(intStringArray.Length);

                foreach (var idString in intStringArray)
                {
                    int id;
                    id = int.Parse(idString);
                    intList.Add(id);
                }

                return intList;
            }

            return new List<int>(0);
        }

        public static List<long> ToLongList(this string idListString)
        {
            if (!string.IsNullOrEmpty(idListString))
            {
                //Handling Json string array [\"1\",\"2\"]
                //Some code we wrote may use this custom format 1,2,3
                string intListString = idListString.Replace("[", "").Replace("]", "").Replace("\"", "");
                string[] intStringArray = intListString.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                var intList = new List<long>(intStringArray.Length);

                foreach (var idString in intStringArray)
                {
                    long id;
                    id = long.Parse(idString);
                    intList.Add(id);
                }

                return intList;
            }
            return new List<long>(0);
        }

        public static List<string> ToStringList(this string idListString)
        {
            if (!string.IsNullOrEmpty(idListString))
            {
                //Handling Json string array [\"1\",\"2\"]
                //Some code we wrote may use this custom format 1,2,3
                string stringListString = idListString.Replace("[", "").Replace("]", "").Replace("\"", "");
                string[] stringArray = stringListString.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                return stringArray.ToList<string>();
            }
            return new List<string>(0);
        }
    }
}
