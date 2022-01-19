using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StartWeChat
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        //D:\Program Files(x86)\Tencent\WeChat\WeChat.exe
        public static bool TryGetSoftwarePath(string softName, out string path)
        {
            string strPathResult = string.Empty;
            string strKeyName = "";     //"(Default)" key, which contains the intalled path
            object objResult = null;

            Microsoft.Win32.RegistryValueKind regValueKind;
            Microsoft.Win32.RegistryKey regKey = null;
            Microsoft.Win32.RegistryKey regSubKey = null;

            try
            {
                //Read the key
                regKey = Microsoft.Win32.Registry.LocalMachine;
                regSubKey = regKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" + softName.ToString() + ".exe", false);

                //Read the path
                objResult = regSubKey.GetValue(strKeyName);
                regValueKind = regSubKey.GetValueKind(strKeyName);

                //Set the path
                if (regValueKind == Microsoft.Win32.RegistryValueKind.String)
                {
                    strPathResult = objResult.ToString();
                }
            }
            catch (System.Security.SecurityException ex)
            {
                throw new System.Security.SecurityException("You have no right to read the registry!", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Reading registry error!", ex);
            }
            finally
            {

                if (regKey != null)
                {
                    regKey.Close();
                    regKey = null;
                }

                if (regSubKey != null)
                {
                    regSubKey.Close();
                    regSubKey = null;
                }
            }

            if (strPathResult != string.Empty)
            {
                //Found
                path = strPathResult;
                return true;
            }
            else
            {
                //Not found
                path = null;
                return false;
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            try
            {
                string softName = "WeChat.exe";
                string strKeyName = "InstallPath";
                string softPath = @"Software\Tencent\WeChat\";
                RegistryKey regKey = Registry.CurrentUser;
                RegistryKey regSubKey = regKey.OpenSubKey(softPath, false);

                object objResult = regSubKey.GetValue(strKeyName);
                RegistryValueKind regValueKind = regSubKey.GetValueKind(strKeyName);
                if (regValueKind == Microsoft.Win32.RegistryValueKind.String)
                {
                    tbPath.Text = Path.Combine(objResult.ToString(), softName);
                }

                
            }
            catch
            {
                tbPath.Text = "获取失败，请手动输入";
            }

        }

        public static void CloseApp(string softName)
        {
            Process[] pProcess;
            pProcess = Process.GetProcesses();
            for (int i = 1; i <= pProcess.Length - 1; i++)
            {
                if (pProcess[i].ProcessName == softName)
                {
                    pProcess[i].Kill();
                    break;
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (nud.Value > 0)
            {
                CloseApp("WeChat");
                for (int i = 0; i < nud.Value; i++)
                {
                    Process.Start(tbPath.Text);
                }

            }
        }
    }
}
