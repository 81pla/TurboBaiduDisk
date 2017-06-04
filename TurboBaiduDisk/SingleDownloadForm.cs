using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboEngine.Core;

namespace TurboBaiduDisk
{
    public partial class SingleDownloadForm : Form
    {
        DownloadEngine engine;

        public SingleDownloadForm(List<string> mirrors)
        {
            InitializeComponent();
            engine = new DownloadEngine(mirrors);
            engine.FilePath = Program.Config.DefaultDownloadPath;
            engine.DownloadError += Engine_DownloadError;
            lblSaveTo.Text = Program.Config.DefaultDownloadPath;
        }

        private void Engine_DownloadError(string obj)
        {
            MessageBox.Show(obj, "下载错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            engine.Stop();
            Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", lblSaveTo.Text);
            Close();
        }

        private void SingleDownloadForm_Load(object sender, EventArgs e)
        {
            StartDownlaod();
        }
        private void StartDownlaod()
        {
            engine.Start();
            Task.Run(new Action(StatePolling));
        }
        private void StatePolling()
        {
            try
            {
                engine.FilePath = Program.Config.DefaultDownloadPath;
                engine.Start();

                lblProgress.Text = "Connecting...";

                while (engine.State != EngineState.Running)
                    ;

                lblFileName.Text = engine.FileName;
                btnCancel.Enabled = true;
                btnPause.Enabled = true;

                while (engine.State == EngineState.Running)
                {
                    lblSpeed.Text = GetSizeString((long)engine.Speed) + "/s";
                    lblRunningThreads.Text = engine.RunningWorkers.ToString();
                    lblProgress.Text = $"{engine.Rate:#.#%} 已完成";
                    lblDOfA.Text = $"{GetSizeString(engine.DownloadedSize)}/{GetSizeString(engine.FileLength)}";
                    lblTimeRemaining.Text = (engine.Speed == 0 ? TimeSpan.Zero : TimeSpan.FromSeconds((engine.FileLength - engine.DownloadedSize) / engine.Speed)).ToString(@"hh\:mm\:ss");
                    progressBar1.Value = (int)(engine.Rate * progressBar1.Maximum);
                    Thread.Sleep(1000);
                }

                while (engine.State != EngineState.Finished || engine.State != EngineState.Stopped)
                    ;

                switch (engine.State)
                {
                    case EngineState.Stopped:
                        lblProgress.Text = $"Stopped.";
                        btnCancel.Enabled = true;
                        btnPause.Enabled = true;
                        break;
                    case EngineState.Finished:
                        lblProgress.Text = $"Finished.";
                        pnlFinish.Visible = true;
                        pnlRunning.Visible = false;
                        break;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
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
        
        private void btnPause_Click(object sender, EventArgs e)
        {
            if(btnPause.Text == "暂停")
            {
                btnCancel.Enabled = false;
                btnPause.Enabled = false;
                engine.Pause();
                btnPause.Text = "继续";
            }
            else
            {
                StartDownlaod();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            engine.Stop();
            Close();
        }
    }
}
