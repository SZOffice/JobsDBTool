using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace JobsDBTool
{
    public class ABTesting
    {
        public static int getABValue(long employerId, string testGroup)
        {
            int idRange = 0;
            try
            {
                string md5Hash = GetMd5Str(employerId.ToString() + testGroup);
                string bchex = bchexdesc(md5Hash).ToString();
                idRange = Convert.ToInt32(bchex.Substring(bchex.Length - 2, 2));                
            }
            catch
            {

            }
            return idRange;
        }

        public static string getABGroup(long employerId, string testGroup, List<int> proportionList)
        {
            string abGroup = "unique";
            try
            {
                var idRange = getABValue(employerId, testGroup);
                //Console.WriteLine(employerId + ": " + idRange);
                int lastValue = 0;
                for (var i = 0; i < proportionList.Count; i++)
                {
                    if ((idRange >= lastValue) && (idRange < proportionList[i] + lastValue))
                    {
                        abGroup = Chr(Asc("a") + i);
                        break;
                    }
                    lastValue += proportionList[i];
                }
            }
            catch
            {

            }
            return abGroup;
        }

        private static int Asc(string character)
        {
            if (character.Length == 1)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                int intAsciiCode = (int)asciiEncoding.GetBytes(character)[0];
                return (intAsciiCode);
            }
            else
            {
                throw new Exception("Character is not valid.");
            }
        }

        private static string Chr(int asciiCode)
        {
            if (asciiCode >= 0 && asciiCode <= 255)
            {
                System.Text.ASCIIEncoding asciiEncoding = new System.Text.ASCIIEncoding();
                byte[] byteArray = new byte[] { (byte)asciiCode };
                string strCharacter = asciiEncoding.GetString(byteArray);
                return (strCharacter);
            }
            else
            {
                throw new Exception("ASCII Code is not valid.");
            }
        }

        private static long bchexdesc(string hex)
        {
            long dec = 0;
            int len = hex.Length;
            for (int i = 1; i <= len; i++)
            {
                var bcpow = Convert.ToInt64(Math.Pow(16, len - i));
                string hexdec = String.Format("{0:X}", Convert.ToInt32(hex[i - 1]));
                var bcmul = bcpow * Convert.ToInt64(hexdec);
                dec = dec + bcmul;
            }
            return dec;
        }

        private static string GetMd5Str(string ConvertString)
        {
            string md5Pwd = string.Empty;

            //使用加密服务提供程序
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //将指定的字节子数组的每个元素的数值转换为它的等效十六进制字符串表示形式。
            md5Pwd = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)), 4, 8);

            md5Pwd = md5Pwd.Replace("-", "");

            return md5Pwd;
        }

    }
}
