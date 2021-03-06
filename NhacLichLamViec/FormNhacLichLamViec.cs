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
    public partial class FormNhacLichLamViec : MetroFramework.Forms.MetroForm
    {
        private string filePath = "data.xml";
        private ListJobs jobs;
         NotifyIcon notifyUtility;
        FlowLayoutPanel fPanel = new FlowLayoutPanel() { AutoScroll = true };

        public ListJobs Jobs { get => jobs; set => jobs = value; }
        public NotifyIcon NotifyUtility { get => notifyUtility; set => notifyUtility = value; }

        public FormNhacLichLamViec()
        {
            InitializeComponent();
            pnlJob.Controls.Add(fPanel);
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;
            try
            {
                if(File.Exists(Application.StartupPath + "\\data.xml"))
                    Jobs = DeserializeJobs() as ListJobs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            FormTungViec cv = sender as FormTungViec;
            Job job = cv.Job;
            if (cv.isSave())
                jobs.Job.Add(job);
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
       
        
        //Luu file XML
        private void SerializeJobs(object data, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(ListJobs));
                sr.Serialize(fs, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            fs.Close();
        }

        //Doc file XML
        private object DeserializeJobs()
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
            SerializeJobs(jobs, filePath);
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
                        notifyUtility.ShowBalloonTip(5000, "Việc bạn cần làm", jobToday[i].Content, ToolTipIcon.Info);
                    }
                }
            }
        }


    }
}
