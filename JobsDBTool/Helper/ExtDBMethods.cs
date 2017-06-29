
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace JobsDBTool.Helper
{
    public static class ExtDBMethods
    {  
        /// <summary>  
        /// 执行带GO的SQL，返回最后一条SQL的受影响行数  
        /// </summary>  
        /// <param name="sql"></param>  
        /// <returns>返回最后一条SQL的受影响行数</returns>  
        public static int ExecuteNonQueryWithGo(this SqlCommand oldCmd)  
        {  
            int result = 0;
            string[] arr = Regex.Split(oldCmd.CommandText, "\r\n\\s*go", RegexOptions.IgnoreCase);  
            using (SqlConnection conn = new SqlConnection(oldCmd.Connection.ConnectionString))  
            {  
                conn.Open();  
                SqlCommand cmd = new SqlCommand();  
                cmd.Connection = conn;  
                SqlTransaction tx = conn.BeginTransaction();  
                cmd.Transaction = tx;  
                try  
                {  
                    for (int n = 0; n < arr.Length; n++)  
                    {  
                        string strsql = arr[n];  
                        if (strsql.Trim().Length > 1)  
                        {  
                            cmd.CommandText = strsql;  
                            result = cmd.ExecuteNonQuery();  
                        }  
                    }  
                    tx.Commit();  
                }  
                catch (System.Data.SqlClient.SqlException E)  
                {  
                    tx.Rollback();  
                    //return -1;  
                    throw new Exception(E.Message);  
                }  
                finally   
                {  
                    if (conn.State != ConnectionState.Closed)   
                    {  
                        conn.Close();  
                        conn.Dispose();  
                    }  
                }  
            }  
            return result;  
        }  
    }//end of class  
}//end of namespace  
