
namespace Utility.NhacLichLamViec
{
    partial class FormNhacLichLamViec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhacLichLamViec));
            this.pnlJob = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlJob
            // 
            this.pnlJob.AutoScroll = true;
            this.pnlJob.BackColor = System.Drawing.Color.White;
            this.pnlJob.Location = new System.Drawing.Point(10, 100);
            this.pnlJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(869, 278);
            this.pnlJob.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpDay);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Location = new System.Drawing.Point(10, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 34);
            this.panel2.TabIndex = 2;
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(602, 7);
            this.dtpDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(250, 22);
            this.dtpDay.TabIndex = 0;
            this.dtpDay.ValueChanged += new System.EventHandler(this.dtpDay_ValueChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(331, 6);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(192, 28);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Công việc hôm nay";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(18, 382);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 59);
            this.panel3.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(61, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(733, 57);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "+";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "notifyIcon1";
            // 
            // FormNhacLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 451);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlJob);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormNhacLichLamViec";
            this.Resizable = false;
            this.Text = "Nhắc Lịch Làm Việc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhacLichLamViec_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNhacLichLamViec_FormClosed);
            this.Load += new System.EventHandler(this.FormNhacLichLamViec_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notify;
    }
}