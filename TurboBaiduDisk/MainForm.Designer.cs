namespace TurboBaiduDisk
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.lblQuota = new MetroFramework.Controls.MetroLabel();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMainBody = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分享ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelNavigateBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.上传ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排序方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.访问百度网盘网站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进入回收站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrAutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMainBody.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelNavigateBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnSettings);
            this.panelHeader.Controls.Add(this.lblQuota);
            this.panelHeader.Controls.Add(this.lblUserName);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(20, 60);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(706, 83);
            this.panelHeader.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(142)))), ((int)(((byte)(231)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(619, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "更多..";
            this.btnSettings.UseSelectable = true;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblQuota
            // 
            this.lblQuota.AutoSize = true;
            this.lblQuota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuota.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuota.ForeColor = System.Drawing.Color.Black;
            this.lblQuota.Location = new System.Drawing.Point(72, 49);
            this.lblQuota.Name = "lblQuota";
            this.lblQuota.Size = new System.Drawing.Size(46, 19);
            this.lblQuota.TabIndex = 2;
            this.lblQuota.Text = "Quota";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(72, 19);
            this.lblUserName.Name = "label1";
            this.lblUserName.Size = new System.Drawing.Size(74, 19);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "正在获取...";
            this.lblUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelMainBody
            // 
            this.panelMainBody.Controls.Add(this.listView1);
            this.panelMainBody.Controls.Add(this.panelNavigateBar);
            this.panelMainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainBody.Location = new System.Drawing.Point(20, 143);
            this.panelMainBody.Name = "panelMainBody";
            this.panelMainBody.Size = new System.Drawing.Size(706, 293);
            this.panelMainBody.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(0, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(706, 260);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView1_KeyPress);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "大小";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "修改日期";
            this.columnHeader3.Width = 201;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开toolStripMenuItem,
            this.下载ToolStripMenuItem,
            this.分享ToolStripMenuItem,
            this.toolStripSeparator1,
            this.复制ToolStripMenuItem,
            this.剪切ToolStripMenuItem,
            this.toolStripSeparator2,
            this.删除ToolStripMenuItem,
            this.属性ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 170);
            // 
            // 打开toolStripMenuItem
            // 
            this.打开toolStripMenuItem.Name = "打开toolStripMenuItem";
            this.打开toolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开toolStripMenuItem.Text = "打开";
            this.打开toolStripMenuItem.Click += new System.EventHandler(this.打开toolStripMenuItem_Click);
            // 
            // 下载ToolStripMenuItem
            // 
            this.下载ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.下载ToolStripMenuItem.Name = "下载ToolStripMenuItem";
            this.下载ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.下载ToolStripMenuItem.Text = "下载";
            this.下载ToolStripMenuItem.Click += new System.EventHandler(this.下载ToolStripMenuItem_Click);
            // 
            // 分享ToolStripMenuItem
            // 
            this.分享ToolStripMenuItem.Name = "分享ToolStripMenuItem";
            this.分享ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.分享ToolStripMenuItem.Text = "分享";
            this.分享ToolStripMenuItem.Click += new System.EventHandler(this.分享ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.属性ToolStripMenuItem.Text = "属性";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "ApkType");
            this.imageList2.Images.SetKeyName(1, "Apps");
            this.imageList2.Images.SetKeyName(2, "CadType");
            this.imageList2.Images.SetKeyName(3, "DocType");
            this.imageList2.Images.SetKeyName(4, "ExeType");
            this.imageList2.Images.SetKeyName(5, "FolderType");
            this.imageList2.Images.SetKeyName(6, "ImgType");
            this.imageList2.Images.SetKeyName(7, "IpaType");
            this.imageList2.Images.SetKeyName(8, "MixFileType");
            this.imageList2.Images.SetKeyName(9, "MusicType");
            this.imageList2.Images.SetKeyName(10, "OtherType");
            this.imageList2.Images.SetKeyName(11, "PdfType");
            this.imageList2.Images.SetKeyName(12, "PptType");
            this.imageList2.Images.SetKeyName(13, "RarType");
            this.imageList2.Images.SetKeyName(14, "TorrentType");
            this.imageList2.Images.SetKeyName(15, "TxtType");
            this.imageList2.Images.SetKeyName(16, "VideoType");
            this.imageList2.Images.SetKeyName(17, "VsdType");
            this.imageList2.Images.SetKeyName(18, "XlsType");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ApkType");
            this.imageList1.Images.SetKeyName(1, "Apps");
            this.imageList1.Images.SetKeyName(2, "CadType");
            this.imageList1.Images.SetKeyName(3, "DocType");
            this.imageList1.Images.SetKeyName(4, "ExeType");
            this.imageList1.Images.SetKeyName(5, "FolderType");
            this.imageList1.Images.SetKeyName(6, "ImgType");
            this.imageList1.Images.SetKeyName(7, "IpaType");
            this.imageList1.Images.SetKeyName(8, "MusicType");
            this.imageList1.Images.SetKeyName(9, "OtherType");
            this.imageList1.Images.SetKeyName(10, "PdfType");
            this.imageList1.Images.SetKeyName(11, "PptType");
            this.imageList1.Images.SetKeyName(12, "RarType");
            this.imageList1.Images.SetKeyName(13, "TorrentType");
            this.imageList1.Images.SetKeyName(14, "TxtType");
            this.imageList1.Images.SetKeyName(15, "VideoType");
            this.imageList1.Images.SetKeyName(16, "VsdType");
            this.imageList1.Images.SetKeyName(17, "XlsType");
            // 
            // panelNavigateBar
            // 
            this.panelNavigateBar.Controls.Add(this.pictureBox2);
            this.panelNavigateBar.Controls.Add(this.textBox1);
            this.panelNavigateBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigateBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavigateBar.Name = "panelNavigateBar";
            this.panelNavigateBar.Size = new System.Drawing.Size(706, 33);
            this.panelNavigateBar.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(25, 6);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(669, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSelectable = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上传ToolStripMenuItem,
            this.新建文件夹ToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripMenuItem1,
            this.toolStripSeparator4,
            this.查看ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.排序方式ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(137, 148);
            // 
            // 上传ToolStripMenuItem
            // 
            this.上传ToolStripMenuItem.Name = "上传ToolStripMenuItem";
            this.上传ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.上传ToolStripMenuItem.Text = "上传";
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            this.新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "粘贴";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(133, 6);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.详细信息ToolStripMenuItem,
            this.平铺ToolStripMenuItem,
            this.图标ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            this.详细信息ToolStripMenuItem.Click += new System.EventHandler(this.详细信息ToolStripMenuItem_Click);
            // 
            // 平铺ToolStripMenuItem
            // 
            this.平铺ToolStripMenuItem.Name = "平铺ToolStripMenuItem";
            this.平铺ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.平铺ToolStripMenuItem.Text = "平铺";
            this.平铺ToolStripMenuItem.Click += new System.EventHandler(this.平铺ToolStripMenuItem_Click);
            // 
            // 图标ToolStripMenuItem
            // 
            this.图标ToolStripMenuItem.Name = "图标ToolStripMenuItem";
            this.图标ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.图标ToolStripMenuItem.Text = "图标";
            this.图标ToolStripMenuItem.Click += new System.EventHandler(this.图标ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 排序方式ToolStripMenuItem
            // 
            this.排序方式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件名称ToolStripMenuItem,
            this.文件大小ToolStripMenuItem,
            this.修改时间ToolStripMenuItem});
            this.排序方式ToolStripMenuItem.Name = "排序方式ToolStripMenuItem";
            this.排序方式ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.排序方式ToolStripMenuItem.Text = "排序方式";
            // 
            // 文件名称ToolStripMenuItem
            // 
            this.文件名称ToolStripMenuItem.Name = "文件名称ToolStripMenuItem";
            this.文件名称ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.文件名称ToolStripMenuItem.Text = "文件名";
            // 
            // 文件大小ToolStripMenuItem
            // 
            this.文件大小ToolStripMenuItem.Name = "文件大小ToolStripMenuItem";
            this.文件大小ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.文件大小ToolStripMenuItem.Text = "大小";
            // 
            // 修改时间ToolStripMenuItem
            // 
            this.修改时间ToolStripMenuItem.Name = "修改时间ToolStripMenuItem";
            this.修改时间ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改时间ToolStripMenuItem.Text = "修改时间";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.访问百度网盘网站ToolStripMenuItem,
            this.进入回收站ToolStripMenuItem,
            this.toolStripSeparator5,
            this.设置ToolStripMenuItem,
            this.退出登录ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(173, 120);
            // 
            // 访问百度网盘网站ToolStripMenuItem
            // 
            this.访问百度网盘网站ToolStripMenuItem.Name = "访问百度网盘网站ToolStripMenuItem";
            this.访问百度网盘网站ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.访问百度网盘网站ToolStripMenuItem.Text = "访问百度网盘网站";
            this.访问百度网盘网站ToolStripMenuItem.Click += new System.EventHandler(this.访问百度网盘网站ToolStripMenuItem_Click);
            // 
            // 进入回收站ToolStripMenuItem
            // 
            this.进入回收站ToolStripMenuItem.Name = "进入回收站ToolStripMenuItem";
            this.进入回收站ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.进入回收站ToolStripMenuItem.Text = "进入回收站";
            this.进入回收站ToolStripMenuItem.Click += new System.EventHandler(this.进入回收站ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(169, 6);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.设置ToolStripMenuItem.Text = "设置..";
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // tmrAutoRefresh
            // 
            this.tmrAutoRefresh.Enabled = true;
            this.tmrAutoRefresh.Interval = 5000;
            this.tmrAutoRefresh.Tick += new System.EventHandler(this.tmrAutoRefresh_Tick);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(341, 196);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(64, 64);
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.Text = "Loading";
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 50;
            this.metroProgressSpinner1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 456);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.panelMainBody);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "TurboBaiduDisk";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMainBody.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelNavigateBar.ResumeLayout(false);
            this.panelNavigateBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMainBody;
        private System.Windows.Forms.Panel panelNavigateBar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分享ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 上传ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 排序方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件名称ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改时间ToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnSettings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 访问百度网盘网站ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进入回收站ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer tmrAutoRefresh;
        private System.Windows.Forms.ToolStripMenuItem 打开toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel lblQuota;
    }
}