using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEI_SSMS_COMMON
{
    public static class BatHelper
    {
        /// <summary>
        /// 执行批处理文件方法
        /// </summary>
        /// <param name="batPath"></param>
        public static bool RunBat(string batPath)
        {
            try 
            {
                if (batPath != null)
                {
                    Process pro = new Process();
                    FileInfo file = new FileInfo(batPath);
                    pro.StartInfo.WorkingDirectory = file.Directory.FullName;
                    pro.StartInfo.FileName = batPath;
                    pro.StartInfo.CreateNoWindow = true;
                    pro.StartInfo.UseShellExecute = false;
                    pro.Start();
                    pro.WaitForExit();
                    return true;
                }
                else return false;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// 写Bat文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool WriteBat(string path,string content)
        {
            try 
            {
                if (path == null) return false;
                string strContent=string.Empty;
                // 判断 bat文件是否存在，如果存在先把文件删除
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
                File.WriteAllText(path, content, Encoding.Default); 
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}
