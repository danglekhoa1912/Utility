using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Utility.NhacLichLamViec
{
    public partial class FormNhacLichLamViec : Form
    {
        private string filePath = "data.xml";
        private ListJobs jobs;
        FlowLayoutPanel fPanel = new FlowLayoutPanel() { AutoScroll = true };

        public ListJobs Jobs { get => jobs; set => jobs = value; }

        public FormNhacLichLamViec()
        {
            InitializeComponent();
            pnlJob.Controls.Add(fPanel);
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;

            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\BTLon");
            //mo registry khoi dong cung win
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            //string subkey = "Software\\ManhQuyen";
            try
            {
                //chen gia tri key
                regkey.SetValue("Index", keyvalue);
                //regstart.SetValue("taoregistrytronghethong", "E:\\Studing\\Bai Tap\\CSharp\\Channel 4\\bai temp\\tao registry trong he thong\\tao registry trong he thong\\bin\\Debug\\tao registry trong he thong.exe");
                regstart.SetValue("BTLon", Application.StartupPath + "\\BTLon.exe");
                ////dong tien trinh ghi key
                //regkey.Close();
            }
            catch (System.Exception ex)
            {
            }

            try
            {
                Jobs = Deserialize(filePath) as ListJobs;
            }
            catch
            {
            }
            LoadListJob(dtpDay.Value);
        }

        void LoadListJob(DateTime datePick)
        {
            fPanel.Controls.Clear();
            if (jobs != null)
            {
                List<Job> jobToday = getJobToday(datePick);
                if (jobToday.Count > 0)
                    for (int i = 0; i < jobToday.Count; i++)
                        AddJob(jobToday[i]);
                else
                    NoJob();
            }
            else
                NoJob();
        }

        void aJob_Deleted(object sender, EventArgs e)
        {
            FormTungViec cv = sender as FormTungViec;
            Job job = cv.Job;
            fPanel.Controls.Remove(cv);
            jobs.Job.Remove(job);
            if (fPanel.Controls.Count == 0)
                NoJob();
        }

        void aJob_Edited(object sender, EventArgs e)
        {

        }

        void AddJob(Job item)
        {
            FormTungViec job = new FormTungViec(item);
            job.Edited += aJob_Edited;
            job.Deleted += aJob_Deleted;
            fPanel.Controls.Add(job);
        }
        void NoJob()
        {
            Label lb = new Label()
            {
                Text = "Hôm nay bạn không có việc gì cần làm",
                Width = fPanel.Width - 10,
                Height = fPanel.Height - 10,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 18)
            };
            fPanel.Controls.Add(lb);
        }
        //void SetDefaultJob()
        //{

        //    jobs.Job.Add(new Job()
        //    {
        //        Content = "hihihih",
        //        IsDone = false,
        //        TimeStart = new Point(4, 15),
        //        DayJob = new DateTime(2021,10,24)
        //    });
        //    jobs.Job.Add(new Job()
        //    {
        //        Content = "hihihih",
        //        IsDone = false,
        //        TimeStart = new Point(4, 15),
        //        DayJob = new DateTime(2021, 10, 24)
        //    });
        //    jobs.Job.Add(new Job()
        //    {
        //        Content = "hihihih",
        //        IsDone = false,
        //        TimeStart = new Point(4, 15),
        //        DayJob = new DateTime(2021, 10, 24)
        //    });
        //    jobs.Job.Add(new Job()
        //    {
        //        Content = "hihihih",
        //        IsDone = true,
        //        TimeStart = new Point(5, 15),
        //        DayJob = new DateTime(2021, 10, 24)
        //    });

        //}

        private void Serialize(object data, string path)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(ListJobs));
            sr.Serialize(fs, data);
            fs.Close();
        }
        private object Deserialize(string path)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
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

        private void NhacLichLamViec_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialize(jobs, filePath);
        }

        private void dtpDay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDay.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                lbTitle.Text = "Công việc hôm nay";
            else
                lbTitle.Text = String.Format("Công việc ngày {0}/{1}/{2}", dtpDay.Value.Day, dtpDay.Value.Month, dtpDay.Value.Year);
            LoadListJob((sender as DateTimePicker).Value);
            if (dtpDay.Value.Ticks < DateTime.Today.Ticks)
                btnThem.Enabled = false;
            else
                btnThem.Enabled = true;
        }

        List<Job> getJobToday(DateTime today)
        {
            // loc mang voi dieu kien
            jobs.Job.Sort((a, b) => a.TimeStart.X - b.TimeStart.X);
            return jobs.Job.Where(job => today.Day == job.DayJob.Day && today.Month == job.DayJob.Month && today.Year == job.DayJob.Year).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (jobs == null || jobs.Job == null)
            {
                jobs = new ListJobs();
                jobs.Job = new List<Job>();
            }
            if (getJobToday(dtpDay.Value).Count == 0)
                fPanel.Controls.Clear();
            Job job = new Job() { DayJob = dtpDay.Value };
            jobs.Job.Add(job);
            AddJob(job);
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

        private void NhacLichLamViec_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notify.Visible = true;
            }
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notify.Visible = false;
        }

        private void FormNhacLichLamViec_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            GiaoDienChinh giaoDienChinh = new GiaoDienChinh();
            giaoDienChinh.ShowDialog();
            this.Close();
        }
    }
}
