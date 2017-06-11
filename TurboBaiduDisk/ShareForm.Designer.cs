namespace TurboBaiduDisk
{
    partial class ShareForm
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
            this.txtPwd = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPath = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLong = new MetroFramework.Controls.MetroTextBox();
            this.txtShort = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.btnShare = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分享选项";
            // 
            // txtPwd
            // 
            this.txtPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwd.Enabled = false;
            this.txtPwd.Lines = new string[0];
            this.txtPwd.Location = new System.Drawing.Point(71, 69);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '\0';
            this.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPwd.SelectedText = "";
            this.txtPwd.Size = new System.Drawing.Size(403, 21);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(71, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "使用密码分享";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Lines = new string[0];
            this.txtPath.Location = new System.Drawing.Point(71, 20);
            this.txtPath.MaxLength = 32767;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.ReadOnly = true;
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPath.SelectedText = "";
            this.txtPath.Size = new System.Drawing.Size(403, 21);
            this.txtPath.TabIndex = 1;
            this.txtPath.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件路径:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLong);
            this.groupBox2.Controls.Add(this.txtShort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(23, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "链接";
            // 
            // txtLong
            // 
            this.txtLong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLong.Lines = new string[0];
            this.txtLong.Location = new System.Drawing.Point(59, 47);
            this.txtLong.MaxLength = 32767;
            this.txtLong.Name = "txtLong";
            this.txtLong.PasswordChar = '\0';
            this.txtLong.ReadOnly = true;
            this.txtLong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLong.SelectedText = "";
            this.txtLong.Size = new System.Drawing.Size(415, 22);
            this.txtLong.TabIndex = 3;
            this.txtLong.UseSelectable = true;
            // 
            // txtShort
            // 
            this.txtShort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShort.Lines = new string[0];
            this.txtShort.Location = new System.Drawing.Point(59, 20);
            this.txtShort.MaxLength = 32767;
            this.txtShort.Name = "txtShort";
            this.txtShort.PasswordChar = '\0';
            this.txtShort.ReadOnly = true;
            this.txtShort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtShort.SelectedText = "";
            this.txtShort.Size = new System.Drawing.Size(415, 22);
            this.txtShort.TabIndex = 2;
            this.txtShort.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "长链接:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "短链接:";
            // 
            // btnShare
            // 
            this.btnShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShare.Location = new System.Drawing.Point(430, 271);
            this.btnShare.Name = "btnShare";
            this.btnShare.TabIndex = 2;
            this.btnShare.Text = "分享";
            this.btnShare.UseSelectable = true;
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(349, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(227, 122);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(64, 64);
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 50;
            // 
            // ShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 309);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShareForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "分享文件";
            this.Load += new System.EventHandler(this.ShareForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtPwd;
        private MetroFramework.Controls.MetroLabel label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private MetroFramework.Controls.MetroTextBox txtPath;
        private MetroFramework.Controls.MetroLabel label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtShort;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroTextBox txtLong;
        private MetroFramework.Controls.MetroButton btnShare;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}