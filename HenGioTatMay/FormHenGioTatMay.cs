using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Utility.HenGioTatMay
{
    public partial class FormHenGioTatMay : Form
    {
        public FormHenGioTatMay()
        {
            InitializeComponent();
            LoadStatus();
        }
        decimal Time = 0;
        ToolStripLabel countDownTime = new ToolStripLabel();
        ToolStripLabel statusHandle = new ToolStripLabel();

        private void giay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown value = sender as NumericUpDown;
            if (value.Value == 60)
            {
                phut.Value++;
                value.Value = 0;
            }
        }

        private void phut_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown value = sender as NumericUpDown;
            if (value.Value == 60)
            {
                gio.Value++;
                value.Value = 0;
            }
        }

        void LoadStatus()
        {
            statusStrip1.Items.Add(statusHandle);
            statusStrip1.Items.Add(countDownTime);
            statusHandle.Text = "Waiting....";
        }

        void XuLy(string command)
        {
            Process.Start("shutdown", command);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            //Huy lenh
            XuLy("-a");
            statusHandle.Text = "Waiting....";
            countDownTime.Text = "";
            timer1.Stop();
            btXacNhan.Enabled = true;
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            Time = gio.Value * 3600 + phut.Value * 60 + giay.Value;
            if (rbShutDown.Checked)
            {
                //Shut down
                XuLy("-s -t " + Time);
                statusHandle.Text = "Shut down....";
                countDownTime.Text = Time.ToString();
            }
            else
            {
                //Restart
                XuLy("-r -t " + Time);
                statusHandle.Text = "Restart....";
                countDownTime.Text = Time.ToString();
            }
            timer1.Start();
            btXacNhan.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time--;
            countDownTime.Text = Time.ToString();
        }

        private void FormHenGioTatMay_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            GiaoDienChinh giaoDienChinh = new GiaoDienChinh();
            giaoDienChinh.ShowDialog();
            this.Close();
        }
    }
}
