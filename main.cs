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


        private void Main_Load(object sender, EventArgs e)
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

        /// <summary>
        /// 关闭进程
        /// </summary>
        /// <param name="softName"></param>
        public static void CloseApp(string softName)
        {
            Process[] pProcess;
            pProcess = Process.GetProcesses();
            for (int i = 1; i <= pProcess.Length - 1; i++)
            {
                if (pProcess[i].ProcessName == softName)
                {
                    pProcess[i].Kill();
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var weChatPath = tbPath.Text;
            if (nud.Value > 0 && File.Exists(weChatPath))
            {
                CloseApp("WeChat");
                for (int i = 0; i < nud.Value; i++)
                {
                    Process.Start(weChatPath);
                }
                if (chbCloseSelf.Checked)
                {
                    this.Close();
                }
            }
        }
    }
}
