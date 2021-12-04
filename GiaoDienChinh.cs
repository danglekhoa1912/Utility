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
using System.IO;
using System.Xml.Serialization;
using Utility.Notebook;

namespace Utility
{
    public partial class GiaoDienChinh : MetroFramework.Forms.MetroForm
    {
        private string filePath = "data.xml";
        private ListJobs jobs;
        private bool isClose = false;

        public bool IsClose { get => isClose; set => isClose = value; }

        public GiaoDienChinh()
        {
            InitializeComponent();
            try
            {
                load();
            }
            catch
            {

            }
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
            isClose = true;
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

        private void notebook_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notebook_main notebook = new Notebook_main();
            notebook.ShowDialog();
            this.Close();
        }

        private object Deserialize(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(ListJobs));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
            }
        }

        void load()
        {
            jobs = Deserialize(filePath) as ListJobs;
        }


        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                notify.Visible = false;
                Visible = true;
            }
        }

        List<Job> getJobToday(DateTime today)
        {
            // loc mang voi dieu kien
            jobs.Job.Sort((a, b) => a.TimeStart.X - b.TimeStart.X);
            return jobs.Job.Where(job => today.Day == job.DayJob.Day && today.Month == job.DayJob.Month && today.Year == job.DayJob.Year).ToList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Second < 60)
                timer1.Interval = (60 - DateTime.Now.Second) * 1000;
            else
                timer1.Interval = 60000;
            if (jobs != null)
            {
                List<Job> jobToday = getJobToday(DateTime.Now);
                for (int i = 0; i < jobToday.Count; i++)
                {
                    if (jobToday[i].TimeStart.X == DateTime.Now.Hour && jobToday[i].TimeStart.Y == DateTime.Now.Minute && !jobToday[i].IsDone)
                    {
                        notify.ShowBalloonTip(5000, "Việc bạn cần làm", jobToday[i].Content, ToolTipIcon.Info);
                    }
                }
            }
        }

        private void GiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                e.Cancel = true;
                notify.Visible = true;
                Visible = false;
            }
        }
    }
}
