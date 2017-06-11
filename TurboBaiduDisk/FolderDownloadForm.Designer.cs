namespace TurboBaiduDisk
{
    partial class FolderDownloadForm
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
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.txtTargetDir = new MetroFramework.Controls.MetroTextBox();
            this.lblDownloading = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(328, 195);
            this.button1.Name = "button1";
            this.button1.TabIndex = 0;
            this.button1.Text = "开始下载";
            this.button1.UseSelectable = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(247, 195);
            this.button2.Name = "button2";
            this.button2.TabIndex = 1;
            this.button2.Text = "取消下载";
            this.button2.UseSelectable = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "下载文件夹:";
            // 
            // txtTargetDir
            // 
            this.txtTargetDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetDir.Lines = new string[0];
            this.txtTargetDir.Location = new System.Drawing.Point(93, 113);
            this.txtTargetDir.MaxLength = 32767;
            this.txtTargetDir.Name = "txtTargetDir";
            this.txtTargetDir.PasswordChar = '\0';
            this.txtTargetDir.ReadOnly = true;
            this.txtTargetDir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTargetDir.SelectedText = "";
            this.txtTargetDir.Size = new System.Drawing.Size(310, 21);
            this.txtTargetDir.TabIndex = 3;
            this.txtTargetDir.UseSelectable = true;
            // 
            // lblDownloading
            // 
            this.lblDownloading.AutoSize = true;
            this.lblDownloading.Location = new System.Drawing.Point(87, 146);
            this.lblDownloading.Name = "lblDownloading";
            this.lblDownloading.Size = new System.Drawing.Size(15, 19);
            this.lblDownloading.TabIndex = 4;
            this.lblDownloading.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "正在下载:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "保存至:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(93, 81);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(310, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.UseSelectable = true;
            // 
            // FolderDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 245);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDownloading);
            this.Controls.Add(this.txtTargetDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "FolderDownloadForm";
            this.Text = "下载文件夹";
            this.Load += new System.EventHandler(this.FolderDownloadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroButton button2;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox txtTargetDir;
        private MetroFramework.Controls.MetroLabel lblDownloading;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroTextBox textBox1;
    }
}