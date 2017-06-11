using APIClient;
using APIClient.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboBaiduDisk
{
    public partial class FolderDownloadForm : MetroForm
    {
        bool stopFlag = false;
        public FolderDownloadForm(string path)
        {
            InitializeComponent();
            txtTargetDir.Text = path;
        }

        private void FolderDownloadForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.Config.DefaultDownloadPath;
        }
        private void DownloadFolder(object path)
        {
            Client client = new Client();
            ListFileResult flst = client.GetFileList(path as string);
            foreach (Item item in flst.list)
            {
                if (stopFlag)
                    return;
                if (item.isdir == 0)
                {
                    if (File.Exists(Program.Config.DefaultDownloadPath + item.path.Replace("/", "\\")))
                        continue;
                    retry:
                    DownloadResult dr = client.GetDownload(item.path);
                    if (dr.urls == null)
                    {
                        goto retry;
                    }
                    if (dr.urls.Length == 1 && dr.urls[0].url.Contains("wenxintishi"))
                    {
                        continue;
                    }
                    List<string> urls = new List<string>();
                    foreach (Url url in dr.urls)
                        urls.Add(url.url);
                    string p = Program.Config.DefaultDownloadPath + item.path.Remove(item.path.LastIndexOf('/')).Replace("/", "\\");
                    if (!Directory.Exists(p))
                        Directory.CreateDirectory(p);
                    lblDownloading.Text = item.path;
                    new SingleDownloadForm(urls, p, true).ShowDialog();
                }
                else
                {
                    DownloadFolder(item.path);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(DownloadFolder).Start(txtTargetDir.Text);
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopFlag = true;
            Close();
        }
    }
}
