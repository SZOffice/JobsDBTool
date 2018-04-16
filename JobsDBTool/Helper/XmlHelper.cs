using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using System.Reflection;

namespace JobsDBTool.Helper
{
    public class XmlHelper
    {
        public static Hashtable GetSections(string path, Hashtable ht)
        {
            if (ht == null)
            {
                ht = new Hashtable();
            }

            if (KernelClass.PhysicalFile.FileExists(path))
            {
                XDocument xDoc = XDocument.Parse(KernelClass.PhysicalFile.ReadFile(path));
                foreach (var ele in xDoc.Descendants("root").Descendants("add"))
                {
                    string key = (string)ele.Attribute("key");
                    if (!ht.ContainsKey(key))
                    {
                        ht.Add(key, ele.Value.ToString());
                    }
                    else if (key == "DropDownToText")
                    {
                        ht[key] = ht[key].ToString() + ele.Value.ToString();
                    }
                }
            }

            return ht;
        }
    }
}
