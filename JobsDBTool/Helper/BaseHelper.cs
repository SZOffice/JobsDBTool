using KernelClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JobsDBTool
{
    public class BaseHelper
    {
        public static bool IsDebug = true;

        public static void InfoLog(string msg)
        {
            if (IsDebug)
            {
                LogHelper.InfoLog(string.Format("{0}: {1}", DateTime.Now.ToString(), msg));
            }
        }
        public static void ErrorLog(string msg)
        {
            LogHelper.ErrorLog(string.Format("{0}: {1}", DateTime.Now.ToString(), msg));            
        }
        public static void ErrorLog(string msg, Exception ex)
        {
            LogHelper.ErrorLog(string.Format("{0}: {1}", DateTime.Now.ToString(), msg), ex);
        }


        public static bool IsExistTable(PetaPoco.Database dbSqlite, string tableName)
        {
            return dbSqlite.ExecuteScalar<long>("SELECT count(*) FROM sqlite_master WHERE type='table' AND name='" + tableName + "'") == 1;
        }
        public static void InitSQLiteDB(string conn, int type)
        {
            try
            {
                SQLiteConnection m_dbConnection;
                m_dbConnection = new SQLiteConnection(conn);
                m_dbConnection.Open();

                if (type == 0) { 
                    string sql = @"Create Table Task (
                    Id integer PRIMARY KEY not null,
                    Title varchar not null, 
                    Url varchar, 
                    Summary varchar, 
                    Status varchar not null,
                    Remark varchar,
                    CreatedTime datetime not null default '0000-00-00 00:00:00',
                    LastModifiedTime datetime,
                    SubmittedTime datetime)";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();

                    sql = @"Create Table TaskLog (
                    TaskId integer PRIMARY KEY not null,
                    Remark varchar,
                    CreatedTime datetime not null default '0000-00-00 00:00:00')";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                }
                if (type == 1)
                {
                    string sql = @"Create Table Document (
                    Id integer PRIMARY KEY not null,
                    Name varchar not null, 
                    ParentId interger not null, 
                    Content varchar, 
                    SortOrder interger not null, 
                    CreatedTime datetime not null default '0000-00-00 00:00:00',
                    LastModifiedTime datetime)";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                ErrorLog("InitSQLiteDB: ", err);
            }
        }

        public static DataSet LoadDataFromSQLiteDB(string sSQL, string conn)
        {
            DataSet ds = new DataSet();
            try
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection(conn);
                m_dbConnection.Open();
                SQLiteCommand command = new SQLiteCommand(sSQL, m_dbConnection);
                SQLiteDataAdapter sda = new SQLiteDataAdapter();
                sda.SelectCommand = command;
                sda.Fill(ds);

                m_dbConnection.Close();
            }
            catch (Exception err)
            {
                ErrorLog("LoadDataFromSQLiteDB sql:" + sSQL + ", conn:" + conn, err);
            }
            return ds;
        }

        public static void AsyncAppendResult(RichTextBox rtb, ResultType type, string text)
        {
            if (rtb.InvokeRequired)//不同线程访问了
                rtb.Invoke(new Action<RichTextBox, ResultType, string>(AppendResult), rtb, type, text);//跨线程了
            else//同线程直接赋值
                AppendResult(rtb, type, text);
        }
        private static void AppendResult(RichTextBox rtb, ResultType type, string text)
        {
            rtb.Select(rtb.Text.Length, 0);
            rtb.Focus();
            switch (type)
            {
                case ResultType.Failure:
                    rtb.SelectionColor = Color.Red;
                    break;
                case ResultType.Success:
                    rtb.SelectionColor = Color.Green;
                    break;

            }
            bool isSwitchline = string.IsNullOrEmpty(text) || text == Environment.NewLine;
            rtb.AppendText(isSwitchline ? text : DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + text);
        }

    }
}
