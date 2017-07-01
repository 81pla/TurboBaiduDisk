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
    public partial class AskForBandwidthForm : MetroForm
    {
        public AskForBandwidthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Config.MaxSpeed = (long)(int.Parse(textBox1.Text) / (double)8) * 1024 * 1024;
            Program.Config.Save();
            Close();
        }
    }
}
