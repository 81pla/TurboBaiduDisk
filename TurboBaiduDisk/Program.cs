using APIClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TurboBaiduDisk
{
    static class Program
    {
        public static GlobalConfig Config;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Control.CheckForIllegalCrossThreadCalls = false;

            Config = GlobalConfig.Load();

            if(Config.SavedCredential != null)
            {
                Client.Authentication = Config.SavedCredential;
                Client client = new Client();

                if (client.CheckIsLogined())
                {
                    Run();
                }
            }

            Client clientLogin = new Client();
            if (clientLogin.Login())
            {
                Config.SavedCredential = Client.Authentication;
                Config.Save();
                Run();
            }
        }
        static void Run()
        {
            Application.Run(new MainForm());
            Environment.Exit(0);
        }
    }
}
