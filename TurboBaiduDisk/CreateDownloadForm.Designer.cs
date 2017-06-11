namespace TurboBaiduDisk
{
    partial class CreateDownloadForm
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
            this.btnSetPath = new MetroFramework.Controls.MetroButton();
            this.txtSaveto = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSize = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilename = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemotePath = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtList = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDownloadNow = new MetroFramework.Controls.MetroButton();
            this.btnShowLinks = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSetPath);
            this.groupBox1.Controls.Add(this.txtSaveto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFilename);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRemotePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // btnSetPath
            // 
            this.btnSetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetPath.Location = new System.Drawing.Point(469, 74);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(59, 21);
            this.btnSetPath.TabIndex = 8;
            this.btnSetPath.Text = "设置";
            this.btnSetPath.UseSelectable = true;
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // txtSaveto
            // 
            this.txtSaveto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveto.Lines = new string[0];
            this.txtSaveto.Location = new System.Drawing.Point(71, 74);
            this.txtSaveto.MaxLength = 32767;
            this.txtSaveto.Name = "txtSaveto";
            this.txtSaveto.PasswordChar = '\0';
            this.txtSaveto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSaveto.SelectedText = "";
            this.txtSaveto.Size = new System.Drawing.Size(392, 21);
            this.txtSaveto.TabIndex = 7;
            this.txtSaveto.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "保存至:";
            // 
            // txtSize
            // 
            this.txtSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSize.Lines = new string[] {
        "正在获取..."};
            this.txtSize.Location = new System.Drawing.Point(327, 47);
            this.txtSize.MaxLength = 32767;
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.ReadOnly = true;
            this.txtSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSize.SelectedText = "";
            this.txtSize.Size = new System.Drawing.Size(201, 21);
            this.txtSize.TabIndex = 5;
            this.txtSize.Text = "正在获取...";
            this.txtSize.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "大小:";
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Lines = new string[] {
        "正在获取..."};
            this.txtFilename.Location = new System.Drawing.Point(71, 47);
            this.txtFilename.MaxLength = 32767;
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.PasswordChar = '\0';
            this.txtFilename.ReadOnly = true;
            this.txtFilename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilename.SelectedText = "";
            this.txtFilename.Size = new System.Drawing.Size(209, 21);
            this.txtFilename.TabIndex = 3;
            this.txtFilename.Text = "正在获取...";
            this.txtFilename.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "文件名:";
            // 
            // txtRemotePath
            // 
            this.txtRemotePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemotePath.Lines = new string[0];
            this.txtRemotePath.Location = new System.Drawing.Point(71, 20);
            this.txtRemotePath.MaxLength = 32767;
            this.txtRemotePath.Name = "txtRemotePath";
            this.txtRemotePath.PasswordChar = '\0';
            this.txtRemotePath.ReadOnly = true;
            this.txtRemotePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemotePath.SelectedText = "";
            this.txtRemotePath.Size = new System.Drawing.Size(457, 21);
            this.txtRemotePath.TabIndex = 1;
            this.txtRemotePath.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件路径:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtList);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 0);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "下载镜像列表";
            // 
            // txtList
            // 
            this.txtList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtList.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtList.ForeColor = System.Drawing.Color.Blue;
            this.txtList.Lines = new string[0];
            this.txtList.Location = new System.Drawing.Point(6, 20);
            this.txtList.MaxLength = 32767;
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.PasswordChar = '\0';
            this.txtList.ReadOnly = true;
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtList.SelectedText = "";
            this.txtList.Size = new System.Drawing.Size(522, 0);
            this.txtList.TabIndex = 0;
            this.txtList.UseSelectable = true;
            this.txtList.WordWrap = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(389, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDownloadNow
            // 
            this.btnDownloadNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadNow.Enabled = false;
            this.btnDownloadNow.Location = new System.Drawing.Point(470, 176);
            this.btnDownloadNow.Name = "btnDownloadNow";
            this.btnDownloadNow.TabIndex = 5;
            this.btnDownloadNow.Text = "下载";
            this.btnDownloadNow.UseSelectable = true;
            this.btnDownloadNow.UseVisualStyleBackColor = true;
            this.btnDownloadNow.Click += new System.EventHandler(this.btnDownloadNow_Click);
            // 
            // btnShowLinks
            // 
            this.btnShowLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowLinks.Location = new System.Drawing.Point(284, 176);
            this.btnShowLinks.Name = "btnShowLinks";
            this.btnShowLinks.Size = new System.Drawing.Size(99, 23);
            this.btnShowLinks.TabIndex = 6;
            this.btnShowLinks.Text = "显示下载链接";
            this.btnShowLinks.UseSelectable = true;
            this.btnShowLinks.UseVisualStyleBackColor = true;
            this.btnShowLinks.Click += new System.EventHandler(this.btnShowLinks_Click);
            // 
            // CreateDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 211);
            this.Controls.Add(this.btnShowLinks);
            this.Controls.Add(this.btnDownloadNow);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateDownloadForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "新建下载";
            this.Load += new System.EventHandler(this.CreateDownloadForm_Load);
            this.Shown += new System.EventHandler(this.CreateDownloadForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtRemotePath;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnSetPath;
        private MetroFramework.Controls.MetroTextBox txtSaveto;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtSize;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtFilename;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtList;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnDownloadNow;
        private MetroFramework.Controls.MetroButton btnShowLinks;
    }
}