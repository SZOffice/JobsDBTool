using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using JinianNet.JNTemplate;

namespace JobsDBTool.Helper
{
    ///   <summary> 
    ///   通过ADO方式的Excel文件操作类 
    ///   </summary> 
    public class TemplateHelper
    {
        public static string GetContent(string templatePath, IDictionary<string, object> dic)
        {
            BuildManager.Engines.Clear();
            Engine e = new Engine();
            Template template = (Template)e.CreateTemplate(templatePath);
                        
            foreach (var item in dic)
            {
                template.Set(item.Key, item.Value);
            }

            return template.Render();
        }
    }
}
