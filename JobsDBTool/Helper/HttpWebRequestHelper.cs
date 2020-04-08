using System.Data;
using System.Net;
using System.IO;
using System.Text;
using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace JobsDBTool.Helper
{
    public class HttpWebRequestHelper
    {
        public static string doPost(string sRequestUrl, string sParams)
        {
            return doPost(null, sRequestUrl, sParams);
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //always accept
        }

        public static string doPost(string sOrigin, string sRequestUrl, string sParams, IDictionary<string, string> headers = null)
        {
            string sResult = string.Empty;
            HttpWebRequest oRequest = null;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            if (sRequestUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                oRequest = WebRequest.Create(sRequestUrl) as HttpWebRequest;
                oRequest.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                oRequest = (HttpWebRequest)WebRequest.Create(sRequestUrl);
            }
            oRequest.Method = WebRequestMethods.Http.Post;

            oRequest.ContentType = "application/json";
            if (!string.IsNullOrEmpty(sOrigin))
            {
                oRequest.Headers.Add("Origin", sOrigin);
                oRequest.Referer = sOrigin;
            }
            if (headers != null)
            {
                foreach (KeyValuePair<string, string> item in headers)
                {
                    oRequest.Headers.Add(item.Key, item.Value);
                }
            }
            oRequest.Proxy = null;
            oRequest.KeepAlive = false;
            oRequest.Timeout = 30000;

            byte[] aDataArray = Encoding.UTF8.GetBytes(sParams);

            oRequest.ContentLength = aDataArray.Length;

            using (Stream oRequestStream = oRequest.GetRequestStream())
            {
                oRequestStream.Write(aDataArray, 0, aDataArray.Length);
                HttpWebResponse oResponse = (HttpWebResponse)oRequest.GetResponse();

                StreamReader oReader = new StreamReader(oResponse.GetResponseStream(),
                   System.Text.Encoding.GetEncoding("utf-8"));
                sResult = oReader.ReadToEnd();
                sResult = sResult.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                oReader.Close();
                oResponse.Close();
            }

            oRequest.Abort();

            return sResult;
        }

        public static string doGet(string sRequestUrl, string sParams, IDictionary<string, string> headers = null)
        {
            string sResult = string.Empty;

            HttpWebRequest httpRequest = null;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            if (sRequestUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                httpRequest = WebRequest.Create(sRequestUrl + "?" + sParams) as HttpWebRequest;
                httpRequest.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(sRequestUrl + "?" + sParams);
            }

            if (headers != null)
            {
                foreach (KeyValuePair<string, string> item in headers)
                {
                    httpRequest.Headers.Add(item.Key, item.Value);
                }
            }

            httpRequest.Method = WebRequestMethods.Http.Get;
            httpRequest.ContentType = "application/x-www-form-urlencoded";
            httpRequest.Proxy = null;
            httpRequest.KeepAlive = false;
            httpRequest.Timeout = 30000;
            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (Stream oRequestStream = httpResponse.GetResponseStream())
            {
                StreamReader sr = new StreamReader(oRequestStream,
                   System.Text.Encoding.GetEncoding("utf-8"));
                sResult = sr.ReadToEnd();
                sResult = sResult.Replace("\r", "").Replace("\n", "").Replace("\t", "");

                sr.Close();
                httpResponse.Close();
            }

            httpRequest.Abort();

            return sResult;
        }

        public static byte[] doGetToBytes(string sRequestUrl, string sParams)
        {
            byte[] bytes;

            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(sRequestUrl + "?" + sParams);
            httpRequest.Method = WebRequestMethods.Http.Get;
            httpRequest.ContentType = "application/x-www-form-urlencoded";
            httpRequest.Proxy = null;
            httpRequest.KeepAlive = false;
            httpRequest.Timeout = 30000;
            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (Stream oRequestStream = httpResponse.GetResponseStream())
            {
                bytes = new byte[httpResponse.ContentLength];
                bytes = ReadFully(oRequestStream);
                httpResponse.Close();
            }

            httpRequest.Abort();

            return bytes;
        }

        public static byte[] ReadFully(Stream stream)
        {
            byte[] buffer = new byte[128];
            using (MemoryStream ms = new MemoryStream())
            {
                while (true)
                {
                    int read = stream.Read(buffer, 0, buffer.Length);
                    if (read <= 0)
                        return ms.ToArray();
                    ms.Write(buffer, 0, read);
                }
            }
        }

        public static bool CheckAccessWebSite(string url, int timeout)
        {
            HttpWebResponse myRes = null;

            try
            {
                HttpWebRequest myReq = WebRequest.Create(url) as HttpWebRequest;
                myReq.Method = "GET";
                myReq.Timeout = timeout;

                myRes = myReq.GetResponse() as HttpWebResponse;

                return (myRes != null && myRes.StatusCode == HttpStatusCode.OK);
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                if (myRes != null) myRes.Close();
            }
        }

    }
}
