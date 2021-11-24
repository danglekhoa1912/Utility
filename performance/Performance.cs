using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.performance
{
    public partial class FormCPUandRAM : MetroFramework.Forms.MetroForm
    {
        public FormCPUandRAM()
        {
            InitializeComponent();
        }

        int i ;
        int j ;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Timer.Start();
            i = 0;
            j = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled =false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram= pRam.NextValue();
            ProgressBarCpu.Value = (int) fcpu;
            ProgressBarRam.Value = (int) fram;
            lbcpu.Text = string.Format("{0:0.00}%", fcpu);
            lbram.Text = string.Format("{0:0.00}%", fram);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
            if (i >= 10)
            {
                chart1.ChartAreas[0].AxisX.Maximum = j+10;
                chart1.ChartAreas[0].AxisX.Minimum = j;
                j++;
            }
            else
            {
                i++;
            }
        }
        private void FormCPUandRAM_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            GiaoDienChinh giaoDienChinh = new GiaoDienChinh();
            giaoDienChinh.ShowDialog();
            this.Close();
        }
    }
}
