using APIClient;
using APIClient.Model;
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
    public partial class CreateDownloadForm : Form
    {
        DownloadEngine engine;
        List<string> mirrors = new List<string>();
        long filelength = 0;
        public CreateDownloadForm(string path)
        {
            InitializeComponent();
            txtRemotePath.Text = path;
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
                lblNoticeBan.Visible = true;
                return;
            }
            foreach (Url url in dresult.urls)
            {
                mirrors.Add(url.url);
                txtList.AppendText($"{url.url}\r\n");
            }
            txtList.AppendText($"Mirrors Count: {mirrors.Count}\r\n");
            string filename = "";
            DownloadEngine.LoadBasicInfo(mirrors[1], out filename, out filelength);
            txtFilename.Text = filename;
            txtSize.Text = GetSizeString(filelength);

            engine = new DownloadEngine(mirrors);
            engine.FileName = filename;
            engine.FileLength = filelength;

            btnDownload.Enabled = true;
            btnDownloadNow.Enabled = true;
        }
        private string GetSizeString(long size)
        {
            if (size > 1024 * 1024 * 1024)
                return $"{(double)size / 1024 / 1024 / 1024:#.##}GB";
            else if (size > 1024 * 1024)
                return $"{(double)size / 1024 / 1024:#.##}MB";
            else if (size > 1024)
                return $"{(double)size / 1024:#.##}KB";
            else
                return $"{size}B";
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
            DialogResult = DialogResult.Cancel;
        }

        private void btnDownloadNow_Click(object sender, EventArgs e)
        {
            if (btnDownloadNow.Text == "立即下载")
            {
                if (txtSaveto.Text == "")
                {
                    MessageBox.Show("请选择下载目录。");
                    return;
                }

                Task.Run(new Action(() =>
                {
                    engine.FilePath = Program.Config.DefaultDownloadPath;
                    engine.Start();
                    while (engine.State != EngineState.Running)
                    {
                        txtList.Text = "Connecting...";
                    }
                    while (engine.State == EngineState.Running)
                    {
                        txtList.Text = $"<Downloading>\r\nThreads: {engine.RunningWorkers} \r\n{engine.Rate:#.#%} finished\r\nSpeed:{GetSizeString((long)engine.Speed)}/s\r\nDownloaded: {GetSizeString(engine.DownloadedSize)}/{GetSizeString(engine.FileLength)}\r\nTime Remaining: {(engine.Speed == 0 ? TimeSpan.MaxValue : TimeSpan.FromSeconds((engine.FileLength - engine.DownloadedSize) / engine.Speed)):c}";
                    }
                    txtList.Text = $"Stopped.";
                }));

                btnDownloadNow.Text = "停止下载";
            }
            else
            {
                Task.Run(new Action(() =>
                {
                    btnDownloadNow.Enabled = false;
                    engine.Pause();
                    btnDownloadNow.Enabled = true;
                    btnDownloadNow.Text = "立即下载";
                }
                ));
            }
        }
    }
}
