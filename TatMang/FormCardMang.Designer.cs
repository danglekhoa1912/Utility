
namespace Utility.TatMang
{
    partial class FormCardMang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAdminSate = new System.Windows.Forms.Label();
            this.lbNameCard = new System.Windows.Forms.Label();
            this.tgOnOff = new MetroFramework.Controls.MetroToggle();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbAdminSate);
            this.panel1.Controls.Add(this.lbNameCard);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 74);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tgOnOff);
            this.panel2.Location = new System.Drawing.Point(438, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 42);
            this.panel2.TabIndex = 3;
            // 
            // lbAdminSate
            // 
            this.lbAdminSate.AutoSize = true;
            this.lbAdminSate.Location = new System.Drawing.Point(270, 31);
            this.lbAdminSate.Name = "lbAdminSate";
            this.lbAdminSate.Size = new System.Drawing.Size(63, 17);
            this.lbAdminSate.TabIndex = 2;
            this.lbAdminSate.Text = "Disabled";
            // 
            // lbNameCard
            // 
            this.lbNameCard.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbNameCard.Location = new System.Drawing.Point(0, 27);
            this.lbNameCard.Name = "lbNameCard";
            this.lbNameCard.Size = new System.Drawing.Size(238, 20);
            this.lbNameCard.TabIndex = 1;
            this.lbNameCard.Text = "Ethernet";
            this.lbNameCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tgOnOff
            // 
            this.tgOnOff.AutoSize = true;
            this.tgOnOff.Location = new System.Drawing.Point(51, 11);
            this.tgOnOff.Name = "tgOnOff";
            this.tgOnOff.Size = new System.Drawing.Size(80, 21);
            this.tgOnOff.TabIndex = 0;
            this.tgOnOff.Text = "Off";
            this.tgOnOff.UseSelectable = true;
            this.tgOnOff.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // FormCardMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCardMang";
            this.Size = new System.Drawing.Size(622, 74);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNameCard;
        private System.Windows.Forms.Label lbAdminSate;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroToggle tgOnOff;
    }
}
