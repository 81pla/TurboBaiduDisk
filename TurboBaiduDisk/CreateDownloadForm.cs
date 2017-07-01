using APIClient;
using APIClient.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboEngine.Core;

namespace TurboBaiduDisk
{
    public partial class CreateDownloadForm : MetroForm
    {
        DownloadEngine engine;
        List<string> mirrors = new List<string>();
        long filelength = 0;
        public CreateDownloadForm(string path, string filename, string filesize)
        {
            InitializeComponent();
            txtRemotePath.Text = path;
            txtFilename.Text = filename;
            txtSize.Text = filesize;
        }

        private void CreateDownloadForm_Load(object sender, EventArgs e)
        {
            txtSaveto.Text = Program.Config.DefaultDownloadPath;
        }

        private void CreateDownloadForm_Shown(object sender, EventArgs e)
        {
            Task.Run(new Action(Init));
        }

        private void Init()
        {
            Client client = new Client();
            DownloadResult dresult = client.GetDownload(txtRemotePath.Text);
            if (dresult.urls == null)
            {
                txtList.Text = "获取下载链接失败！";
                return;
            }
            if (dresult.urls[0].url.Contains("wenxintishi"))
            {
                MessageBox.Show("此文件已被封禁! :)");
                return;
            }
            foreach (Url url in dresult.urls)
            {
                mirrors.Add(url.url);
                txtList.AppendText($"{url.url}\r\n");
            }
            txtList.AppendText($"镜像数量: {mirrors.Count}\r\n");
        }
        
        private void btnDownload_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "选择下载位置";
            dlg.SelectedPath = Environment.CurrentDirectory;
            dlg.ShowDialog();
            txtSaveto.Text = dlg.SelectedPath;
            Program.Config.DefaultDownloadPath = dlg.SelectedPath;
            Program.Config.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDownloadNow_Click(object sender, EventArgs e)
        {
            new SingleDownloadForm(mirrors).Show();
            Close();
        }

        private void btnShowLinks_Click(object sender, EventArgs e)
        {
            Height = 451;
            btnShowLinks.Visible = false;
        }
    }
}
