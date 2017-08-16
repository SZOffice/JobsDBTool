using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using JinianNet.JNTemplate;
using System.Text.RegularExpressions;
using System.IO;
using PlainElastic.Net;
using PlainElastic.Net.Serialization;

namespace JobsDBTool.Helper
{
    public class ESHelper
    {
        private static string dateToId(string datetime)
        {
            return datetime.Replace(" ", "")
                .Replace(":", "")
                .Replace(",", "");
        }

        public static IList<Dictionary<string, object>> Log2Json(string logPath, IDictionary<string, object> dic)
        {
            string[] log_keys = new string[]{
                "Date and Time", "Machine Name", "Process User", "Remote User", "Remote Address",
                "Remote Host", "URL", "NET Runtime version", "Application Domain",
                "Assembly Codebase", "Assembly Full Name", "Assembly Version",
                "Assembly Build Date", "Exception Type", "Exception Message", "Exception Source"};
            string[] log_obj_keys = new string[] { "Form", "Cookies", "Session", "ServerVariables" };

            //try
            //{
            IList<Dictionary<string, object>> listLog = new List<Dictionary<string, object>>();
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            using (StreamReader objStreamReader = new StreamReader(logPath, System.Text.Encoding.UTF8))
            {
                string cur_key = "";
                bool bCurException = false;
                bool bCurError = false;
                Dictionary<string, object> log = new Dictionary<string, object>();

                while (objStreamReader.Peek() >= 0)
                {
                    string line = objStreamReader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    Regex regStart = new Regex(@"^(\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2},\d*),\[(\d*)\],(\D*),(.*),(\D*),""Helpdesk Ticket:(.*)");
                    MatchCollection matches = regStart.Matches(line);
                    if (matches.Count > 0)
                    {
                        if (log.ContainsKey("UTCDate"))
                        {
                            listLog.Add(log);
                            log = new Dictionary<string, object>();
                            cur_key = "";
                            bCurException = false;
                            bCurError = false;
                        }

                        foreach (Match match in matches)
                        {
                            GroupCollection groups = match.Groups;
                            log.Add("Id", dateToId(groups[1].Value.Trim()));
                            log.Add("UTCDate", groups[1].Value.Trim());
                            log.Add("Thread", groups[2].Value.Trim());
                            log.Add("Level", groups[3].Value.Trim());
                            log.Add("LogId", groups[4].Value.Trim());
                            log.Add("LogType", groups[5].Value.Trim());
                            log.Add("TicketId", groups[6].Value.Trim());
                        }
                        continue;
                    }

                    Regex regErrorStart = new Regex(@"^(\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2},\d*),\[(\d*)\],(\D*),(.*)");
                    MatchCollection matchesError = regErrorStart.Matches(line);
                    if (matchesError.Count > 0)
                    {
                        if (log.ContainsKey("UTCDate"))
                        {
                            listLog.Add(log);
                            log = new Dictionary<string, object>();
                            cur_key = "";
                            bCurException = false;
                            bCurError = false;
                        }

                        foreach (Match match in matchesError)
                        {
                            GroupCollection groups = match.Groups;
                            log.Add("Id", dateToId(groups[1].Value.Trim()));
                            log.Add("UTCDate", groups[1].Value.Trim());
                            log.Add("Thread", groups[2].Value.Trim());
                            log.Add("Level", groups[3].Value.Trim());
                            log.Add("Exception", groups[4].Value.Trim());
                        }
                        continue;
                    }
                    if (bCurError)
                    {
                        log["Exception"] += Environment.NewLine + line;
                        continue;
                    }

                    Regex regException = new Regex(@"^Exception Target Site:(.*)");
                    MatchCollection matchesException = regException.Matches(line);
                    if (matchesException.Count > 0)
                    {
                        bCurException = true;
                        if (!log.ContainsKey("ExceptionTargetSite"))
                        {
                            log.Add("ExceptionTargetSite", ((GroupCollection)matchesException[0].Groups)[1].Value.Trim());
                        }
                        continue;
                    }
                    Regex regEndException = new Regex(@"^---- ASP.NET Collections ----");
                    if (regEndException.IsMatch(line))
                    {
                        bCurException = false;
                        continue;
                    }
                    if (bCurException)
                    {
                        log["ExceptionTargetSite"] += Environment.NewLine + line;
                        continue;
                    }

                    foreach (var key in log_keys)
                    {
                        Regex temReg = new Regex(string.Format(@"^{0}:*(.*)", key));
                        MatchCollection tmpMatches = temReg.Matches(line);
                        if (tmpMatches.Count > 0)
                        {
                            log.Add(key, ((GroupCollection)tmpMatches[0].Groups)[1].Value.Trim());
                            continue;
                        }
                    }

                    bool bMatch = false;
                    foreach (var obj_key in log_obj_keys)
                    {
                        Regex temReg = new Regex(string.Format(@"^{0}", obj_key));
                        MatchCollection tmpMatches = temReg.Matches(line);
                        if (tmpMatches.Count > 0)
                        {
                            bMatch = true;
                            cur_key = obj_key;
                            break;
                        }
                    }
                    if (bMatch)
                    {
                        continue;
                    }

                    Regex regObj_Param = new Regex(@"^\s+(\S+)\s+(.*)");
                    MatchCollection matchesObj_Param = regObj_Param.Matches(line);
                    if (matchesObj_Param.Count > 0 && !string.IsNullOrEmpty(cur_key))
                    {
                        if (!log.ContainsKey(cur_key))
                        {
                            log.Add(cur_key, new Dictionary<string, string>());
                        }
                        if (!((Dictionary<string, string>)log[cur_key]).ContainsKey(((GroupCollection)matchesObj_Param[0].Groups)[1].Value.Trim()))
                        {
                            ((Dictionary<string, string>)log[cur_key]).Add(((GroupCollection)matchesObj_Param[0].Groups)[1].Value.Trim(), ((GroupCollection)matchesObj_Param[0].Groups)[2].Value.Trim());
                        }
                        continue;
                    }

                }
                //for the lastest log info
                if (log.ContainsKey("UTCDate"))
                {
                    listLog.Add(log);
                    log = new Dictionary<string, object>();
                    cur_key = "";
                    bCurException = false;
                    bCurError = false;
                }

                Console.WriteLine(listLog.ToJSON());
                objStreamReader.Close();
            }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return listLog;
        }

        public static string PostES(string host, string index, string type, IList<Dictionary<string, object>> listLog)
        {
            if (listLog.Count == 0)
            {
                return "";
            }
            var connection = new ElasticConnection(host, 9200);
            var serializer = new JsonNetSerializer();
            string bulkCommand = new BulkCommand(index: index, type: type);
            string bulkJson = new BulkBuilder(serializer)
                                .BuildCollection(listLog,
                                    (builder, log) => builder.Index(data: log, id: log["Id"].ToString())
                                );

            string response = connection.Post(bulkCommand, bulkJson);

            //Parse bulk result;
            BulkResult bulkResult = serializer.ToBulkResult(response);

            string result = string.Empty;
            foreach (var item in bulkResult.items)
            {
                if (item.Result.status != 200)
                {
                    result += item.ToJSON();
                }
            }
            return result;
        }
    }
}
