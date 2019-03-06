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

namespace JobsDBTool.Helper
{
    public class WordingHelper
    {
        public static string saveBackupTaskToCSV(string filePath, DataTable csvDataTable)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                filePath = Path.Combine(System.Environment.CurrentDirectory, "BackupTask.csv");
            }
            
            UTF8Encoding utf8 = new UTF8Encoding(false);
            if (!KernelClass.CSVHelper.WriteCSV(csvDataTable, filePath, false, utf8))
            {
                return "Have error when save data to csv";
            }

            return "";
        }

        public static void saveToCSV(string filePath, DataTable dt)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("请选择正确的文件路径.", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sbErrorMsg = new StringBuilder();

            DataTable csvDataTable = KernelClass.dtHelper.GetNewDataTable(dt, "");
            csvDataTable.Columns.RemoveAt(0);
            UTF8Encoding utf8 = new UTF8Encoding(false);
            if (!KernelClass.CSVHelper.WriteCSV(csvDataTable, filePath, false, utf8))
            {
                sbErrorMsg.Append("Have error when save data to csv");
            }
            else
                sbErrorMsg.Append("Successed");

            if (!string.IsNullOrEmpty(sbErrorMsg.ToString()))
            {
                MessageBox.Show(sbErrorMsg.ToString(), "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public static List<Dictionary<string, Type>> GetColumns(Hashtable htConfig)
        {
            List<Dictionary<string, Type>> ls = new List<Dictionary<string, Type>>();
            if (htConfig.ContainsKey("TableColumns"))
            {
                XDocument doc = XDocument.Parse(htConfig["TableColumns"].ToString());
                var result = from d in doc.Descendants("column")
                             select d;
                foreach (var item in result)
                {
                    Dictionary<string, Type> dic = new Dictionary<string, Type>();
                    dic.Add(item.Value, GetColumnType(item.Attribute("type").Value));
                    ls.Add(dic);
                }

            }
            else
            {
                MessageBox.Show("请先到App.config中定义TableColumns.", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ls;
        }

        public static DataSet InitDataSet(List<Dictionary<string, Type>> columns)
        {
            DataSet ds = new DataSet();
            DataTable oDT = new DataTable();

            foreach (var dic in columns)
            {
                foreach (var item in dic)
                {
                    oDT.Columns.Add(item.Key, item.Value);
                }
            }

            ds.Tables.Add(oDT);

            return ds;
        }

        public static Type GetColumnType(string str)
        {
            Type columnType;
            switch (str)
            {
                case "int":
                    columnType = typeof(int);
                    break;
                default:
                    columnType = typeof(string);
                    break;
            }
            return columnType;
        }
        
        public static string InsertDataToDB(bool isAdd, DataSet ds, string connectStr, string sKeySql, string sSQL, out List<int> arrSuccess, out StringBuilder sbWholeSqlQuery)
        {
            arrSuccess = new List<int>();
            sbWholeSqlQuery = new StringBuilder();
            StringBuilder sbWholeKeySqlQuery = new StringBuilder();
            StringBuilder sbWholeContentSqlQuery = new StringBuilder();
            StringBuilder sbErrorMsg = new StringBuilder();
            if (isAdd && string.IsNullOrEmpty(connectStr))
            {
                return "Please input connection string";
            }

            IList<string> listKey = new List<string>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string sKeySqlCopy = sKeySql;
                    string sSQLCopy = sSQL;
                    bool bKeyExist = true;
                    if (!listKey.Contains(ds.Tables[0].Rows[i][2].ToString()))
                    {
                        listKey.Add(ds.Tables[0].Rows[i][2].ToString());
                        bKeyExist = false;
                    }

                    for (int j = 1; j < ds.Tables[0].Columns.Count; j++)
                    {
                        string columnName = ds.Tables[0].Columns[j].ColumnName;
                        string row = ds.Tables[0].Rows[i][j].ToString();
                        if (isAdd)
                        {
                            SqlParameter para1 = new SqlParameter(ds.Tables[0].Columns[j].ColumnName, row);
                            cmd.Parameters.Add(para1);
                        }
                        else
                        {

                            sKeySqlCopy = bKeyExist ? string.Empty : sKeySqlCopy.Replace("@" + columnName, "N'" + row.Replace("'", "''") + "'");
                            sSQLCopy = sSQLCopy.Replace("@" + columnName, "N'" + row.Replace("'", "''") + "'");
                        }
                    }

                    if (!isAdd)
                    {
                        sbWholeKeySqlQuery.AppendLine("USE [JobsDB_System]");
                        sbWholeKeySqlQuery.AppendLine("GO");

                        if (!string.IsNullOrEmpty(sKeySqlCopy))
                        {
                            sbWholeKeySqlQuery.AppendLine(sKeySqlCopy);
                        }

                        if (sbWholeContentSqlQuery.Length > 0)
                        {
                            sbWholeContentSqlQuery.AppendLine("Go");
                        }
                        sbWholeContentSqlQuery.AppendLine(sSQLCopy);
                    }
                    else
                    {
                        SqlConnection sqlConn = new SqlConnection(connectStr);
                        sqlConn.Open();
                        cmd.CommandText = sKeySqlCopy + Environment.NewLine + sSQLCopy;
                        cmd.Connection = sqlConn;

                        int rtn = cmd.ExecuteNonQuery();
                        if (rtn >=0)
                        {
                            ds.Tables[0].Rows[i][0] = "Completed";// sdr.GetString(0).ToString();
                            ds.AcceptChanges();
                            arrSuccess.Add(i);
                        }
                        sqlConn.Close();
                    }

                }
                catch (Exception err)
                {
                    if (isAdd)
                    {
                        ds.Tables[0].Rows[i][0] = "Failed";
                        ds.AcceptChanges();
                    }
                    sbErrorMsg.AppendFormat("插入第{0}条数据失败!失败原因：{1}, 提示信息", i.ToString(), err.Message).AppendLine();
                }

            }

            sbWholeSqlQuery.AppendLine(sbWholeKeySqlQuery.ToString());
            sbWholeSqlQuery.AppendLine("Go");
            sbWholeSqlQuery.AppendLine(sbWholeContentSqlQuery.ToString());

            return sbErrorMsg.ToString();
        }

    }
}
