using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility.NhacLichLamViec
{
    public partial class FormTungViec : UserControl
    {
        private Job job;

        public Job Job { get => job; set => job = value; }

        public FormTungViec(Job job)
        {
            InitializeComponent();
            this.Job = job;
            if (job.Content == null)
            {
                btnEdit.Text = "Ok";
                txbJob.Enabled = true;
                nmToHours.Enabled = true;
                nmToMinute.Enabled = true;
                txbJob.Focus();
            }
            else
                ShowInfor();
        }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        void ShowInfor()
        {
            if (Job.DayJob.Day <= DateTime.Now.Day && Job.DayJob.Month <= DateTime.Now.Month && Job.DayJob.Year <= DateTime.Now.Year && Job.TimeStart.X <= DateTime.Now.Hour && Job.TimeStart.Y < DateTime.Now.Minute)
                this.BackColor = Color.Gray;
            else
                this.BackColor = Color.White;
            ckbDone.Checked = Job.IsDone;
            txbJob.Text = Job.Content;
            nmToMinute.Value = Job.TimeStart.Y;
            nmToHours.Value = Job.TimeStart.X;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (btnEdit.Text == "Sửa")
                {
                    btnEdit.Text = "Ok";
                    txbJob.Enabled = true;
                    nmToHours.Enabled = true;
                    nmToMinute.Enabled = true;

                }
                else
                {
                    btnEdit.Text = "Sửa";
                    txbJob.Enabled = false;
                    nmToHours.Enabled = false;
                    nmToMinute.Enabled = false;
                    Job.Content = txbJob.Text;
                    Job.TimeStart = new Point((int)nmToHours.Value, (int)nmToMinute.Value);
                    Job.IsDone = ckbDone.Checked;
                    ShowInfor();
                }
                if (edited != null)
                    edited(this, new EventArgs());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void ckbDone_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDone.Checked)
                this.BackColor = Color.Gray;
            else this.BackColor = Color.White;
        }

        private void txbJob_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txbJob.Text))
            {
                e.Cancel = true;
                txbJob.Focus();
                errorProvider1.SetError(txbJob, "Vui lòng nhập công việc");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txbJob, null);
            }
        }
    }
}
