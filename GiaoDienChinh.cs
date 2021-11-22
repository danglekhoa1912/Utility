using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility.HenGioTatMay;
using Utility.NhacLichLamViec;
using Utility.TatMang;

namespace Utility
{
    public partial class GiaoDienChinh : Form
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
    }
}
