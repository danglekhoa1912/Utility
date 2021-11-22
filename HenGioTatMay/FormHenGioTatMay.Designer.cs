
namespace Utility.HenGioTatMay
{
    partial class FormHenGioTatMay
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gio = new System.Windows.Forms.NumericUpDown();
            this.phut = new System.Windows.Forms.NumericUpDown();
            this.giay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.rbShutDown = new System.Windows.Forms.RadioButton();
            this.rbRestart = new System.Windows.Forms.RadioButton();
            this.btHuy = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giay)).BeginInit();
            this.SuspendLayout();
            // 
            // gio
            // 
            this.gio.Location = new System.Drawing.Point(21, 25);
            this.gio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gio.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.gio.Name = "gio";
            this.gio.Size = new System.Drawing.Size(53, 22);
            this.gio.TabIndex = 0;
            // 
            // phut
            // 
            this.phut.Location = new System.Drawing.Point(132, 24);
            this.phut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phut.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.phut.Name = "phut";
            this.phut.Size = new System.Drawing.Size(53, 22);
            this.phut.TabIndex = 0;
            this.phut.ValueChanged += new System.EventHandler(this.phut_ValueChanged);
            // 
            // giay
            // 
            this.giay.Location = new System.Drawing.Point(249, 24);
            this.giay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.giay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.giay.Name = "giay";
            this.giay.Size = new System.Drawing.Size(53, 22);
            this.giay.TabIndex = 0;
            this.giay.ValueChanged += new System.EventHandler(this.giay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phút";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giây";
            // 
            // btXacNhan
            // 
            this.btXacNhan.Location = new System.Drawing.Point(377, 25);
            this.btXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(94, 23);
            this.btXacNhan.TabIndex = 2;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // rbShutDown
            // 
            this.rbShutDown.AutoSize = true;
            this.rbShutDown.Checked = true;
            this.rbShutDown.Location = new System.Drawing.Point(63, 70);
            this.rbShutDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbShutDown.Name = "rbShutDown";
            this.rbShutDown.Size = new System.Drawing.Size(97, 21);
            this.rbShutDown.TabIndex = 3;
            this.rbShutDown.TabStop = true;
            this.rbShutDown.Text = "Shut Down";
            this.rbShutDown.UseVisualStyleBackColor = true;
            // 
            // rbRestart
            // 
            this.rbRestart.AutoSize = true;
            this.rbRestart.Location = new System.Drawing.Point(207, 70);
            this.rbRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRestart.Name = "rbRestart";
            this.rbRestart.Size = new System.Drawing.Size(75, 21);
            this.rbRestart.TabIndex = 3;
            this.rbRestart.Text = "Restart";
            this.rbRestart.UseVisualStyleBackColor = true;
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(377, 69);
            this.btHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(94, 23);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy lệnh";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 100);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(487, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormHenGioTatMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 122);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rbRestart);
            this.Controls.Add(this.rbShutDown);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giay);
            this.Controls.Add(this.phut);
            this.Controls.Add(this.gio);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormHenGioTatMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ hẹn giờ tắt máy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHenGioTatMay_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown gio;
        private System.Windows.Forms.NumericUpDown phut;
        private System.Windows.Forms.NumericUpDown giay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.RadioButton rbShutDown;
        private System.Windows.Forms.RadioButton rbRestart;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
    }
}