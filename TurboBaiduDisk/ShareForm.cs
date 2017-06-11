using APIClient;
using APIClient.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboBaiduDisk
{
    public partial class ShareForm : MetroForm
    {
        string[] path_list;
        public ShareForm()
        {
            InitializeComponent();
        }
        public ShareForm(string[] paths)
        {
            InitializeComponent();
            txtPath.Text = string.Join(",", paths);
            path_list = paths;
        }

        private void ShareForm_Load(object sender, EventArgs e)
        {
            txtPwd.Text = GetRandomPassword(4);
            metroProgressSpinner1.Visible = false;
        }

        public string GetRandomPassword(int passwordLen)
        {
            string randomChars = "abcdefghijklmnopqrstuvwxyz1234567890";
            string password = string.Empty;
            int randomNum;
            Random random = new Random();
            for (int i = 0; i < passwordLen; i++)
            {
                randomNum = random.Next(randomChars.Length);
                password += randomChars[randomNum];
            }
            return password;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtPwd.Enabled = true;
            else
                txtPwd.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            Task.Run(new Action(() =>
            {
                metroProgressSpinner1.Visible = true;
                Client client = new Client();
                if (checkBox1.Checked)
                {
                    ShareResult result = client.SharePrivate(path_list, txtPwd.Text);
                    if (result.errno != 0)
                    {
                        MessageBox.Show($"{Errno.Instance.GetDescription(result.errno)}. 分享失败.");
                        return;
                    }
                    txtShort.Text = result.shorturl;
                    txtLong.Text = result.link;
                }
                else
                {
                    ShareResult result = client.Share(path_list);
                    if (result.errno != 0)
                    {
                        MessageBox.Show($"{Errno.Instance.GetDescription(result.errno)}. 分享失败.");
                        return;
                    }
                    txtShort.Text = result.shorturl;
                    txtLong.Text = result.link;
                }
                metroProgressSpinner1.Visible = false;
            }));
        }

    }
}
