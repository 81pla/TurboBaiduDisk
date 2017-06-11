namespace TurboBaiduDisk
{
    partial class SingleDownloadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDOfA = new MetroFramework.Controls.MetroLabel();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.lblTimeRemaining = new MetroFramework.Controls.MetroLabel();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.lblSpeed = new MetroFramework.Controls.MetroLabel();
            this.lblProgress = new MetroFramework.Controls.MetroLabel();
            this.lblRunningThreads = new MetroFramework.Controls.MetroLabel();
            this.lblSaveTo = new MetroFramework.Controls.MetroLabel();
            this.lblFileName = new MetroFramework.Controls.MetroLabel();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.btnOpenDir = new MetroFramework.Controls.MetroButton();
            this.btnFinish = new MetroFramework.Controls.MetroButton();
            this.pnlRunning = new System.Windows.Forms.Panel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnPause = new MetroFramework.Controls.MetroButton();
            this.pnlFinish = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.pnlRunning.SuspendLayout();
            this.pnlFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblDOfA);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTimeRemaining);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblSpeed);
            this.groupBox1.Controls.Add(this.lblProgress);
            this.groupBox1.Controls.Add(this.lblRunningThreads);
            this.groupBox1.Controls.Add(this.lblSaveTo);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblDOfA
            // 
            this.lblDOfA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDOfA.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDOfA.Location = new System.Drawing.Point(101, 113);
            this.lblDOfA.Name = "lblDOfA";
            this.lblDOfA.Size = new System.Drawing.Size(302, 23);
            this.lblDOfA.TabIndex = 14;
            this.lblDOfA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "已下载/总大小:";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(71, 161);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(332, 23);
            this.lblTimeRemaining.TabIndex = 12;
            this.lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "剩余时间:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.Location = new System.Drawing.Point(47, 137);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(356, 23);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProgress.Location = new System.Drawing.Point(47, 89);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(356, 23);
            this.lblProgress.TabIndex = 9;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRunningThreads
            // 
            this.lblRunningThreads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRunningThreads.Location = new System.Drawing.Point(83, 65);
            this.lblRunningThreads.Name = "lblRunningThreads";
            this.lblRunningThreads.Size = new System.Drawing.Size(320, 23);
            this.lblRunningThreads.TabIndex = 8;
            this.lblRunningThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaveTo
            // 
            this.lblSaveTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveTo.Location = new System.Drawing.Point(59, 41);
            this.lblSaveTo.Name = "lblSaveTo";
            this.lblSaveTo.Size = new System.Drawing.Size(344, 23);
            this.lblSaveTo.TabIndex = 7;
            this.lblSaveTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.Location = new System.Drawing.Point(59, 17);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(344, 23);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(6, 201);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "速度:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "进度:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "运行线程数:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "保存至:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件名:";
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDir.Location = new System.Drawing.Point(3, 3);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(92, 23);
            this.btnOpenDir.TabIndex = 3;
            this.btnOpenDir.Text = "打开文件夹";
            this.btnOpenDir.UseSelectable = true;
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinish.Location = new System.Drawing.Point(344, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(62, 23);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "完成";
            this.btnFinish.UseSelectable = true;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pnlRunning
            // 
            this.pnlRunning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRunning.Controls.Add(this.btnCancel);
            this.pnlRunning.Controls.Add(this.btnPause);
            this.pnlRunning.Location = new System.Drawing.Point(257, 321);
            this.pnlRunning.Name = "pnlRunning";
            this.pnlRunning.Size = new System.Drawing.Size(164, 30);
            this.pnlRunning.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(0, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消下载";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(84, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暂停下载";
            this.btnPause.UseSelectable = true;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // pnlFinish
            // 
            this.pnlFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFinish.Controls.Add(this.btnOpenDir);
            this.pnlFinish.Controls.Add(this.btnFinish);
            this.pnlFinish.Location = new System.Drawing.Point(12, 321);
            this.pnlFinish.Name = "pnlFinish";
            this.pnlFinish.Size = new System.Drawing.Size(409, 30);
            this.pnlFinish.TabIndex = 6;
            this.pnlFinish.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "完成后退出";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SingleDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 356);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pnlRunning);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlFinish);
            this.Name = "SingleDownloadForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "下载";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingleDownloadForm_FormClosing);
            this.Load += new System.EventHandler(this.SingleDownloadForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlRunning.ResumeLayout(false);
            this.pnlFinish.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lblSpeed;
        private MetroFramework.Controls.MetroLabel lblProgress;
        private MetroFramework.Controls.MetroLabel lblRunningThreads;
        private MetroFramework.Controls.MetroLabel lblSaveTo;
        private MetroFramework.Controls.MetroLabel lblFileName;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroButton btnOpenDir;
        private MetroFramework.Controls.MetroButton btnFinish;
        private System.Windows.Forms.Panel pnlRunning;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnPause;
        private System.Windows.Forms.Panel pnlFinish;
        private MetroFramework.Controls.MetroLabel lblTimeRemaining;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroLabel lblDOfA;
        private MetroFramework.Controls.MetroLabel label8;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}