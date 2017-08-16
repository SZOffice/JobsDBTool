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
    public class CommonHelper
    {
        public static Hashtable GetConfigValue()
        {
            Hashtable ht = (Hashtable)ConfigurationManager.GetSection("sqlCode");
            return ht;
        }

        public static void RunBat(string batPath)
        {
            Process pro = new Process();

            FileInfo file = new FileInfo(batPath);
            pro.StartInfo.WorkingDirectory = file.Directory.FullName;
            pro.StartInfo.FileName = batPath;
            pro.StartInfo.CreateNoWindow = false;
            pro.Start();
            pro.WaitForExit();
        }

        public static string copyFileToBK(string backupFolderPath, string filePath, string taskName, int index)
        {
            return copyFileToBK(backupFolderPath, filePath, taskName, index, false);
        }
        public static string copyFileToBK(string backupFolderPath, string filePath, string taskName, int index, bool isDirectCopy)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                return "";
            }
            string appBKFolderPath = Path.Combine(System.Environment.CurrentDirectory, "Backup");
            string folderPath = appBKFolderPath;
            if (!string.IsNullOrEmpty(backupFolderPath))
            {
                folderPath = backupFolderPath;
            }
            if (!KernelClass.PhysicalFile.FolderExists(folderPath))
            {
                KernelClass.PhysicalFile.CreateFolder(folderPath);
            }

            
            string fileName = Path.GetFileName(filePath);
            if (!isDirectCopy)
            {
                 fileName = Path.GetFileNameWithoutExtension(filePath)
                    + (string.IsNullOrEmpty(taskName) ? "" : "_" + taskName)
                    + "_" + DateTime.Now.ToString("yyyyMMdd")
                    + "_V" + index + Path.GetExtension(filePath);
            }
            string newFilePath = Path.Combine(folderPath, fileName);
            if (!File.Exists(newFilePath))
            {
                File.Copy(filePath, newFilePath);
                if (!string.IsNullOrEmpty(backupFolderPath) && ConfigurationManager.AppSettings["IsDebug"] == "true")
                {
                    if (!KernelClass.PhysicalFile.FolderExists(appBKFolderPath))
                    {
                        KernelClass.PhysicalFile.CreateFolder(appBKFolderPath);
                    }
                    if (!File.Exists(Path.Combine(appBKFolderPath, fileName)))
                    {
                        File.Copy(filePath, Path.Combine(appBKFolderPath, fileName));
                    }
                }
                return newFilePath;
            }
            index++;
            return copyFileToBK(backupFolderPath, filePath, taskName, index);
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="baseFileName"></param>
        /// <param name="extension">.txt</param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int getNameIndex(string folderPath, string baseFileName, string extension, int index)
        {
            string fileName = DateTime.Now.ToString("yyyyMMdd");
            string filePath = Path.Combine(folderPath,
                (string.IsNullOrEmpty(baseFileName) ? "" : baseFileName+"_") + fileName
                + "_V" + index + extension);
            if (KernelClass.PhysicalFile.FileExists(filePath) || KernelClass.PhysicalFile.FolderExists(filePath))
            {
                index++;
                index = getNameIndex(folderPath, baseFileName, extension, index);
            }
            return index;
        }

        public static string GetAbsolutePath(string relativePath)
        {
            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Replace(@"file:\", string.Empty);

            if (!relativePath.StartsWith(Path.DirectorySeparatorChar.ToString()))
            {
                return rootPath + Path.DirectorySeparatorChar + relativePath;
            }

            return rootPath + relativePath;
        }

        public static string ComposeHyperLink(string basePath, IDictionary<string, string> queryStringArgs)
        {
            if (queryStringArgs == null || queryStringArgs.Count == 0)
            {
                return basePath;
            }

            StringBuilder sb = new StringBuilder(basePath);

            if (!basePath.EndsWith("?"))
            {
                sb.Append("?");
            }

            bool isFirstItem = true;

            foreach (var item in queryStringArgs)
            {
                if (isFirstItem)
                {
                    isFirstItem = false;
                }
                else
                {
                    sb.Append("&");
                }

                sb.Append(item.Key);
                sb.Append("=");
                sb.Append(item.Value);
            }

            return sb.ToString();
        }
    }
}
