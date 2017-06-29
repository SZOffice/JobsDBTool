using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JobsDBTool.Helper
{
    public class LoadDataForWording
    {
        private static string sheetName = "Wording";

        //加载Excel 
        public static DataSet LoadDataFromExcel(string filePath)
        {
            DataSet OleDsExcle = new DataSet();
            try
            {
                ExcelDatabase excelDB = new ExcelDatabase(filePath);
                OleDsExcle.Tables.Add(excelDB.GetSheetData(sheetName));
            }
            catch (Exception err)
            {
                throw new Exception("数据绑定Excel失败!失败原因：" + err.Message);
            }

            return OleDsExcle;
        }

        //加载CSV
        public static DataSet LoadDataFromCSV(string filePath)
        {
            DataSet oleDsExcle = new DataSet();
            try
            {
                oleDsExcle.Tables.Add(KernelClass.CSVHelper.ReadCSV(filePath));
            }
            catch (Exception err)
            {
                MessageBox.Show("数据绑定CSV失败!失败原因：" + err.Message, "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return oleDsExcle;
        }

        public static DataSet LoadDataFromDB(string sSQL, string conn)
        {

            DataSet ds = new DataSet();
            try
            {
                SqlConnection sqlConn = new SqlConnection(conn);

                sqlConn.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = sSQL;
                cmd.Connection = sqlConn;

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;

                sda.Fill(ds);

                sqlConn.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("查询数据失败!失败原因：" + err.Message, "提示信息",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }


        public static DataSet LoadDataFromString(string sContent, CheckedListBox clbCountry, List<Dictionary<string, Type>> columns)
        {
            //Warning_D_JobAdCompanyProfile_HideEmployerProfile,Label_D_JobAdCompanyProfile_SaveDefault
            if (string.IsNullOrEmpty(sContent.Trim())) {
                MessageBox.Show("请输入字符串", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string[] arrContent = sContent.Replace("\r\n", "").Split(',');

            DataSet ds = WordingHelper.InitDataSet(columns);

            Dictionary<string, string> dicCountry_Language = new Dictionary<string, string>();
            foreach (var s in clbCountry.CheckedItems)
            {
                switch ((Option.Country)Enum.Parse(typeof(Option.Country), s.ToString()))
                {
                    case Option.Country.ID:
                        dicCountry_Language.Add(s.ToString(), Option.Language.ID.ToString());
                        break;
                    case (Option.Country.TH):
                        dicCountry_Language.Add(s.ToString(), Option.Language.TH.ToString());
                        break;
                    default:
                        dicCountry_Language.Add(s.ToString(), Option.Language.EN.ToString());
                        break;
                }
            }
            try
            {
                int i = 1;
                foreach (var wordingKey in arrContent)
                {
                    var key = wordingKey.Split('_');
                    if (!string.IsNullOrEmpty(wordingKey.Trim()))
                    {
                        foreach (var item in dicCountry_Language)
                        {
                            ds.Tables[0].Rows.Add("Pending", i, wordingKey.Trim(), ((int)Enum.Parse(typeof(Option.WordingGroup), key[0])).ToString()
                            , item.Key
                            , item.Value
                            , key[key.Length - 1], "");

                            i++;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("查询数据失败!失败原因：" + err.Message, "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }        
    }
}
