using MetroFramework.Forms;
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
    public partial class SingleDownloadForm : MetroForm
    {
        DownloadEngine engine;
        Task uiTask;
        bool autoClose = false;
        public SingleDownloadForm(List<string> mirrors)
        {
            InitializeComponent();
            engine = new DownloadEngine(mirrors);
            engine.DownloadError += Engine_DownloadError;
            lblSaveTo.Text = Program.Config.DefaultDownloadPath;
        }

        public SingleDownloadForm(List<string> mirrors, string downloadPath)
            : this(mirrors)
        {
            engine.FilePath = downloadPath;
        }
        public SingleDownloadForm(List<string> mirrors, string downloadPath, bool autoClose)
            : this(mirrors, downloadPath)
        {
            this.autoClose = autoClose;
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
            Process.Start("explorer.exe", $"/select,\"{engine.FullFileName}\"");
            Close();
        }

        private void SingleDownloadForm_Load(object sender, EventArgs e)
        {
            StartDownlaod();
        }
        private void StartDownlaod()
        {
            engine.MinWorkers = (int)(Program.Config.MaxSpeed / (256 * 1024));
            engine.MaxWorkers = engine.MinWorkers * 3;
            uiTask = Task.Run(new Action(StatePolling));
        }
        private void StatePolling()
        {
            try
            {
                if (engine.FilePath == null)
                    engine.FilePath = Program.Config.DefaultDownloadPath;
                engine.Start();

                lblProgress.Text = "连接中...";

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

                while (engine.State != EngineState.Finished && engine.State != EngineState.Stopped)
                    ;

                switch (engine.State)
                {
                    case EngineState.Stopped:
                        lblProgress.Text = $"已停止";
                        Close();
                        break;
                    case EngineState.Finished:
                        lblProgress.Text = $"已完成";
                        lblSpeed.Text = "";
                        lblRunningThreads.Text = "";
                        lblDOfA.Text = "";
                        lblTimeRemaining.Text = "";
                        progressBar1.Value = progressBar1.Maximum;
                        this.Invoke(new Action(() =>
                        {
                            pnlFinish.Visible = true;
                            pnlRunning.Visible = false;
                        }));
                        if (autoClose || Program.Config.AutoClose)
                            Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"UIRefresh: {ex.Message}");
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
            btnCancel.Enabled = false;
            btnPause.Enabled = false;
            engine.Pause();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            engine.Stop();
            Close();
        }

        private void SingleDownloadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            engine.Stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Program.Config.AutoClose = checkBox1.Checked;
        }
    }
}
