using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Utility.performance;
using System.Windows.Forms;
using Utility.HenGioTatMay;
using Utility.NhacLichLamViec;
using Utility.TatMang;
using System.Diagnostics;

namespace Utility
{
    public partial class GiaoDienChinh : MetroFramework.Forms.MetroForm
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.ShowDialog();
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shutdowntimer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHenGioTatMay shutDownTimer = new FormHenGioTatMay();
            shutDownTimer.ShowDialog();
            this.Close();
        }

        private void remind_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNhacLichLamViec reminder = new FormNhacLichLamViec();
            reminder.ShowDialog();
            this.Close();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTatMang network = new FormTatMang();
            network.ShowDialog();
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCPUandRAM performance = new FormCPUandRAM();
            performance.ShowDialog();
            this.Close();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            string cmd = @"/c rd %temp%\ /s /q";
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = cmd;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            MessageBox.Show(@"Xoa file tam thanh cong !");
        }

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {

        }
    }
}
