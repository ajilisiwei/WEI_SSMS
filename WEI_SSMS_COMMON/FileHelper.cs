using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEI_SSMS_COMMON
{
    public static class FileHelper
    {
        /// <summary>
        /// 选择文件
        /// </summary>
        /// <returns></returns>
        public static string OpenFilePath()
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Title = "选择文件";
            openFileDialog.Filter = "zip文件|*.zip|rar文件|*.rar|所有文件|*.*";
            openFileDialog.FileName = string.Empty;
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "zip";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                return "";
            }
            string fileName = openFileDialog.FileName;
            return fileName;
        }

        /// <summary>
        /// 选择目录
        /// </summary>
        /// <returns></returns>
        public static string OpenFolderPath()
        {
            FolderBrowserDialog m_Dialog = new FolderBrowserDialog();
            DialogResult result = m_Dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                return "";
            }
            string m_Dir = m_Dialog.SelectedPath.Trim();
            return m_Dir;
        }

        /// <summary>
        /// 复制文件到指定目录下
        /// SourceFileName:The complete path of file
        /// DesDic:The path without file name but end with '\'
        /// DesFileName:Just the file name
        /// </summary>
        /// <param name="SourceFileName"></param>
        /// <param name="DesDic"></param>
        /// <param name="DesFileName"></param>
        public static void CopyFileToAssignedDic(string SourceFileName,string DesDic,string DesFileName)
        {
            try 
            {
                if (SourceFileName == null) return;
                String[] extName = SourceFileName.Split('.');
                if (!Directory.Exists(DesDic))
                {
                    Directory.CreateDirectory(DesDic);  //创建目录
                }
                if(DesFileName==null)
                {

                    String[] filename=SourceFileName.Split('\\');
                    DesFileName = DesDic + filename[filename.Count() - 1];
                }
                DesFileName = DesDic + DesFileName + "." + extName[extName.Count() - 1];
                File.Copy(SourceFileName, DesFileName);
                System.Windows.MessageBox.Show("图片上传成功！");
            }
            catch(Exception ex)
            {
            }
        }

        /// <summary>
        /// 在指定的目录中查找文件
        /// </summary>
        /// <param name="dir">目录</param>
        /// <param name="fileName">文件名</param>
        /// <returns></returns>
        public static bool FindFile(string dir, string fileName)
        {
            if (dir == null || dir.Trim() == "" || fileName == null || fileName.Trim() == "" || !Directory.Exists(dir))
            {
                return false;
            }

            DirectoryInfo dirInfo = new DirectoryInfo(dir);
            return FindFile(dirInfo, fileName);
        }

        public static bool FindFile(DirectoryInfo dir, string fileName)
        {
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                if (File.Exists(d.FullName + "\\" + fileName))
                {
                    return true;
                }
                FindFile(d, fileName);
            }
            return false;
        }

        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetConfigString(string str)
        {
            string result = string.Empty;
            try
            {
                result = System.Configuration.ConfigurationManager.AppSettings[str];
            }
            catch (Exception ex)
            {
            }
            return result;
        }

    }
}
