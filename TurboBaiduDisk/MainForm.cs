using APIClient;
using APIClient.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboBaiduDisk
{
    public partial class MainForm : MetroForm
    {
        Client client;
        string[] fileOpCacheList;

        int opType = 0; // 0 - none, 1 - copy, 2 - move
        int OpType
        {
            get { return opType; }
            set
            {
                opType = value;
                if (value == 0)
                    toolStripMenuItem1.Enabled = false;
                else
                    toolStripMenuItem1.Enabled = true;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            client = new Client();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            new Thread(Init).Start();
        }
        private void Init()
        {
            this.Invoke(new Action(() => { metroProgressSpinner1.Visible = true; }));
            UserInfoResult uinfo = client.GetUserInfo();
            QuotaResult quota = client.GetQuota();
            lblUserName.Text = uinfo.records[0].uname;
            pictureBox1.Image = Image.FromStream(WebRequest.Create(uinfo.records[0].avatar_url).GetResponse().GetResponseStream());
            lblQuota.Text = $"\t{(double)quota.used / 1024 / 1024 / 1024:#.##}GB/{(double)quota.total / 1024 / 1024 / 1024:#.##}GB";

            RefreshPath("/");
            metroProgressSpinner1.Visible = false;
        }

        public static DateTime TimeStamp2DateTime(string timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dateTimeStart.Add(toNow);
        }
        private void RefreshPath(string path)
        {
            string rpath = (path == "" ? "/" : path);
            ListFileResult flst = client.GetFileList(rpath);
            if (flst.list == null)
            {
                return;
            }
            if (flst.list.Length == (rpath == "/" ? listView1.Items.Count : listView1.Items.Count - 1))
            {
                foreach (Item item in flst.list)
                {
                    if (!listView1.Items.ContainsKey(item.path))
                    {
                        metroProgressSpinner1.Visible = false;
                        return;
                    }
                }
            }
            listView1.BeginUpdate();
            listView1.Items.Clear();
            if (rpath != "/")
                listView1.Items.Add(new ListViewItem("..", "FolderType"));
            foreach (Item item in flst.list)
            {
                ListViewItem lvItem = new ListViewItem(item.server_filename);
                if (item.isdir == 1)
                {
                    if (item.server_filename == "apps")
                        lvItem.ImageKey = "Apps";
                    else
                        lvItem.ImageKey = "FolderType";

                    lvItem.SubItems.AddRange(new string[] { "", TimeStamp2DateTime(item.server_ctime.ToString()).ToString() });
                }
                else
                {
                    if (item.server_filename.Contains("."))
                        switch (item.server_filename.Substring(item.server_filename.LastIndexOf(".")).ToLower())
                        {
                            #region TypeSwitch
                            case ".apk":
                                lvItem.ImageKey = "ApkType";
                                break;
                            case ".cad":
                                lvItem.ImageKey = "CadType";
                                break;
                            case ".doc":
                            case ".docx":
                                lvItem.ImageKey = "DocType";
                                break;
                            case ".exe":
                                lvItem.ImageKey = "ExeType";
                                break;
                            case ".png":
                            case ".jpg":
                            case ".jpeg":
                            case ".gif":
                            case ".bmp":
                            case ".tiff":
                                lvItem.ImageKey = "ImgType";
                                break;
                            case ".ipa":
                                lvItem.ImageKey = "IpaType";
                                break;
                            case ".mp3":
                            case ".flac":
                            case ".ogg":
                            case ".wav":
                            case ".wma":
                            case ".aac":
                            case ".ape":
                                lvItem.ImageKey = "MusicType";
                                break;
                            case ".ppt":
                            case ".pptx":
                                lvItem.ImageKey = "PptType";
                                break;
                            case ".rar":
                            case ".zip":
                            case ".7z":
                            case ".tar":
                            case ".gz":
                                lvItem.ImageKey = "RarType";
                                break;
                            case ".torrent":
                                lvItem.ImageKey = "TorrentType";
                                break;
                            case ".txt":
                                lvItem.ImageKey = "TxtType";
                                break;
                            case ".mp4":
                            case ".avi":
                            case ".mkv":
                            case ".rm":
                            case ".rmvb":
                            case ".flv":
                            case ".wmv":
                            case ".3gp":
                            case ".mov":
                                lvItem.ImageKey = "VideoType";
                                break;
                            case ".vsd":
                                lvItem.ImageKey = "VsdType";
                                break;
                            case ".xls":
                            case ".xlsx":
                            case ".csv":
                                lvItem.ImageKey = "XlsType";
                                break;
                            default:
                                lvItem.ImageKey = "OtherType";
                                break;
                                #endregion
                        }
                    else
                        lvItem.ImageKey = "OtherType";

                    lvItem.SubItems.AddRange(new string[] { GetSizeString(item.size), TimeStamp2DateTime(item.server_ctime.ToString()).ToString() });
                }
                listView1.Items.Add(lvItem);
            }
            listView1.EndUpdate();
            textBox1.Text = rpath;
            listView1.Items[0].Selected = true;
            listView1.SelectedItems.Clear();
            metroProgressSpinner1.Visible = false;
        }
        private string GetSizeString(long size)
        {
            if (size > 1000 * 1000 * 1000)
                return $"{(double)size / 1024 / 1024 / 1024:#.##}GB";
            else if (size > 1000 * 1000)
                return $"{(double)size / 1024 / 1024:#.##}MB";
            else if (size > 1000)
                return $"{(double)size / 1024:#.##}KB";
            else
                return $"{size}B";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                listView1.ContextMenuStrip = contextMenuStrip2;
            }
            else
            {
                listView1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            if (listView1.SelectedItems[0].ImageKey == "FolderType" || listView1.SelectedItems[0].ImageKey == "Apps")
            {
                this.Invoke(new Action(() =>{ metroProgressSpinner1.Visible = true;}));
                if (listView1.SelectedItems[0].Text == "..")
                {
                    string oPath = textBox1.Text;
                    Task.Run(new Action(() =>
                    {
                        RefreshPath(oPath.Remove(oPath.LastIndexOf('/')));
                    }));
                }
                else
                {
                    Task.Run(new Action(() =>
                    {
                        RefreshPath((textBox1.Text.EndsWith("/") ? textBox1.Text : textBox1.Text + "/") + listView1.SelectedItems[0].Text);
                    }));
                }
            }
            else
            {
                下载ToolStripMenuItem.PerformClick();
            }
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void 平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void 图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(PointToScreen(btnSettings.Location));
        }

        private void 进入回收站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://pan.baidu.com/disk/recyclebin");
        }

        private void 访问百度网盘网站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://pan.baidu.com/disk/home");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Config.Save();
            Environment.Exit(0);
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.Logout();
            Program.Config.SavedCredential = null;
            Program.Config.Save();
            Application.Restart();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            metroProgressSpinner1.Visible = true;
            Task.Run(new Action(() =>
            {
                pictureBox2.Enabled = false;
                RefreshPath(textBox1.Text);
                pictureBox2.Enabled = true;
            }));
        }

        private void tmrAutoRefresh_Tick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                RefreshPath(textBox1.Text);
        }
        

        private void 下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (item.ImageKey == "FolderType")
                    new FolderDownloadForm(Path.Combine(textBox1.Text, item.Text).Replace('\\', '/')).Show();
                else
                    new CreateDownloadForm(Path.Combine(textBox1.Text,item.Text).Replace('\\','/'), item.Text, item.SubItems[1].Text).Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            访问百度网盘网站ToolStripMenuItem.PerformClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(null, null);
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                list.Add((textBox1.Text.EndsWith("/") ? textBox1.Text : textBox1.Text + "/") + item.Text);
            }
            fileOpCacheList = list.ToArray();
            opType = 1;
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                list.Add((textBox1.Text.EndsWith("/") ? textBox1.Text : textBox1.Text + "/") + item.Text);
                item.ForeColor = Color.Gray;
            }
            fileOpCacheList = list.ToArray();
            opType = 2;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fileOpCacheList == null)
                return;
            if (fileOpCacheList.Length == 0)
                return;

            FileOperationResult result = null;
            List<CopyMoveRequest> requests = new List<CopyMoveRequest>();
            foreach (string p in fileOpCacheList)
            {
                requests.Add(new CopyMoveRequest() { path = p, dest = textBox1.Text, newname = p.Substring(p.LastIndexOf('/')) });
            }

            switch (opType)
            {
                case 1:
                    result = client.CopyFiles(requests.ToArray());
                    break;
                case 2:
                    result = client.MoveFiles(requests.ToArray());
                    break;
            }
            if (result.errno != 0)
                MessageBox.Show($"{Errno.Instance.GetDescription(result.errno)}. 操作失败.");
            pictureBox2_Click(null, null);
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            ListViewItem item = listView1.Items[e.Item];
            client.RenameFiles(new RenameRequest[] { new RenameRequest() { path = (textBox1.Text.EndsWith("/") ? textBox1.Text : textBox1.Text + "/") + item.Text, newname = e.Label } });
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                list.Add((textBox1.Text.EndsWith("/") ? textBox1.Text : textBox1.Text + "/") + item.Text);
                item.ForeColor = Color.Gray;
            }
            client.DeleteFiles(list.ToArray());
            pictureBox2_Click(null, null);
        }

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                删除ToolStripMenuItem.PerformClick();
                return;
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                复制ToolStripMenuItem.PerformClick();
                return;
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                剪切ToolStripMenuItem.PerformClick();
                return;
            }
            if (e.Control && e.KeyCode == Keys.V)
            {
                toolStripMenuItem1.PerformClick();
                return;
            }
        }

        private void 分享ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                list.Add((textBox1.Text.EndsWith("/") ? textBox1.Text : textBox1.Text + "/") + item.Text);
                item.ForeColor = Color.Gray;
            }
            new ShareForm(list.ToArray()).ShowDialog();
        }

        private void 打开toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = "v" + Application.ProductVersion;
        }
    }
}