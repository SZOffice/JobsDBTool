using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Sdk.Sfc;

namespace JobsDBTool.Helper
{
    public class OperateDBHelper
    {
        private static int limitRang = 150;

        public static IList<SelectItem> GetDbNameList(Server server)
        {
            IList<SelectItem> selectItemList = new List<SelectItem>();

            foreach (Database db in server.Databases)
            {
                selectItemList.Add(new SelectItem()
                {
                    Name = db.Name,
                    Value = db.Name
                });
            }
            return selectItemList;
        }

        public static string GetGenerateSql(Server server, ScriptParams scriptParams, List<Urn> urnList)
        {
            StringBuilder sbGenerate = new StringBuilder();

            Scripter scripter = new Scripter(server);
            scripter.Options.IncludeHeaders = true;
            scripter.Options.IncludeIfNotExists = true;
            if (scriptParams.IsScriptDrops)
            {
                scripter.Options.ScriptDrops = true;

                foreach (string s in scripter.EnumScript(urnList.ToArray()))
                {
                    sbGenerate.Append(s).AppendLine();
                }
            }

            sbGenerate.AppendLine();

            scripter.Options.IncludeHeaders = true;
            scripter.Options.IncludeIfNotExists = true;
            scripter.Options.ScriptDrops = false;
            if (scriptParams.IsScriptSchema)
            {
                scripter.Options.ScriptSchema = true;
            }
            else
            {
                scripter.Options.ScriptSchema = false;
            }
            if (scriptParams.IsScriptData)
            {
                scripter.Options.ScriptData = true;
            }

            if (scriptParams.IsScriptSchema || scriptParams.IsScriptData)
            {
                foreach (string s in scripter.EnumScript(urnList.ToArray()))
                {
                    sbGenerate.Append(s).AppendLine();
                }
            }

            return sbGenerate.ToString();
        }

        #region get urn lsit

        public static List<Urn> GetUrnList(Database database, ScriptParams scriptParams)
        {
            if (database == null) return null;

            List<Urn> urnList = new List<Urn>();
            GetUrnList_ByTable(database, scriptParams, urnList);
            GetUrnList_ByView(database, scriptParams, urnList);
            GetUrnList_BySynonym(database, scriptParams, urnList);
            GetUrnList_ByFunction(database, scriptParams, urnList);
            GetUrnList_ByStoredProcedure(database, scriptParams, urnList);

            return urnList;
        }

        private static bool isExistsInDB(ScriptParams scriptParams, string name)
        {
            if (scriptParams.ScriptObj == ScriptObj.OnlyList)
            {
                if (scriptParams.NameList.Select(c=>string.Equals(c, name, StringComparison.CurrentCultureIgnoreCase)).Count()>0)
                {
                    return true;
                }
            }
            else if (scriptParams.ScriptObj == ScriptObj.IgnoreList)
            {
                if (scriptParams.NameList.Select(c => string.Equals(c, name, StringComparison.CurrentCultureIgnoreCase)).Count() == 0)
                {
                    return true;
                }
            }
            return true;
        }

        public static List<Urn> GetUrnList_ByTable(Database database, ScriptParams scriptParams, List<Urn> urnList)
        {
            if (scriptParams.NameList.Count > limitRang || scriptParams.ScriptObj == ScriptObj.All)
            {
                foreach (Table item in database.Tables)
                {
                    if (item.IsSystemObject)
                        continue;
                    if (isExistsInDB(scriptParams, item.Name))
                    {
                        urnList.Add(item.Urn);
                    }
                }
            }
            else
            {
                for (int i = scriptParams.NameList.Count-1; i >=0; i--)
                {
                    if (database.Tables.Contains(scriptParams.NameList[i]))
                    {
                        if (database.Tables[scriptParams.NameList[i]].IsSystemObject)
                            continue;
                        urnList.Add(database.Tables[scriptParams.NameList[i]].Urn);
                        scriptParams.NameList.RemoveAt(i);
                    }
                }
            }

            return urnList;
        }
        public static List<Urn> GetUrnList_BySynonym(Database database, ScriptParams scriptParams, List<Urn> urnList)
        {
            if (scriptParams.NameList.Count > limitRang || scriptParams.ScriptObj == ScriptObj.All)
            {
                foreach (Synonym item in database.Synonyms)
                {
                    if (isExistsInDB(scriptParams, item.Name))
                    {
                        urnList.Add(item.Urn);
                    }
                }
            }
            else
            {
                for (int i = scriptParams.NameList.Count - 1; i >= 0; i--)
                {
                    if (database.Synonyms.Contains(scriptParams.NameList[i]))
                    {
                        urnList.Add(database.Synonyms[scriptParams.NameList[i]].Urn);
                        scriptParams.NameList.RemoveAt(i);
                    }
                }

            }

            return urnList;
        }
        public static List<Urn> GetUrnList_ByView(Database database, ScriptParams scriptParams, List<Urn> urnList)
        {
            if (scriptParams.NameList.Count > limitRang || scriptParams.ScriptObj == ScriptObj.All)
            {
                foreach (Microsoft.SqlServer.Management.Smo.View item in database.Views)
                {
                    if (item.IsSystemObject)
                        continue;
                    if (isExistsInDB(scriptParams, item.Name))
                    {
                        urnList.Add(item.Urn);
                    }
                }
            }
            else
            {
                for (int i = scriptParams.NameList.Count - 1; i >= 0; i--)
                {
                    if (database.Views.Contains(scriptParams.NameList[i]))
                    {
                        if (database.Views[scriptParams.NameList[i]].IsSystemObject)
                            continue;
                        urnList.Add(database.Views[scriptParams.NameList[i]].Urn);
                        scriptParams.NameList.RemoveAt(i);
                    }
                }
            }

            return urnList;
        }
        public static List<Urn> GetUrnList_ByFunction(Database database, ScriptParams scriptParams, List<Urn> urnList)
        {
            if (scriptParams.NameList.Count > limitRang || scriptParams.ScriptObj == ScriptObj.All)
            {
                foreach (UserDefinedFunction item in database.UserDefinedFunctions)
                {
                    if (item.IsSystemObject)
                        continue;
                    if (isExistsInDB(scriptParams, item.Name))
                    {
                        urnList.Add(item.Urn);
                    }
                }
            }
            else
            {
                for (int i = scriptParams.NameList.Count - 1; i >= 0; i--)
                {
                    if (database.UserDefinedFunctions.Contains(scriptParams.NameList[i]))
                    {
                        if (database.UserDefinedFunctions[scriptParams.NameList[i]].IsSystemObject)
                            continue;
                        urnList.Add(database.UserDefinedFunctions[scriptParams.NameList[i]].Urn);
                        scriptParams.NameList.RemoveAt(i);
                    }
                }

            }

            return urnList;
        }
        public static List<Urn> GetUrnList_ByStoredProcedure(Database database, ScriptParams scriptParams, List<Urn> urnList)
        {
            if (scriptParams.NameList.Count > limitRang || scriptParams.ScriptObj == ScriptObj.All)
            {
                foreach (StoredProcedure item in database.StoredProcedures)
                {
                    if (item.IsSystemObject)
                        continue;
                    if (isExistsInDB(scriptParams, item.Name))
                    {
                        urnList.Add(item.Urn);
                    }
                }
            }
            else
            {
                for (int i = scriptParams.NameList.Count - 1; i >= 0; i--)
                {
                    if (database.StoredProcedures.Contains(scriptParams.NameList[i]))
                    {
                        if (database.StoredProcedures[scriptParams.NameList[i]].IsSystemObject)
                            continue;
                        urnList.Add(database.StoredProcedures[scriptParams.NameList[i]].Urn);
                        scriptParams.NameList.RemoveAt(i);
                    }
                }
            }

            return urnList;
        }
        #endregion
    }
}
