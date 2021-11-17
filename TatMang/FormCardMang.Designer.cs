
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
            this.btOnOff = new System.Windows.Forms.Button();
            this.lbAdminSate = new System.Windows.Forms.Label();
            this.lbNameCard = new System.Windows.Forms.Label();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 92);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btOnOff);
            this.panel2.Location = new System.Drawing.Point(438, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 52);
            this.panel2.TabIndex = 3;
            // 
            // btOnOff
            // 
            this.btOnOff.Location = new System.Drawing.Point(30, 9);
            this.btOnOff.Name = "btOnOff";
            this.btOnOff.Size = new System.Drawing.Size(116, 34);
            this.btOnOff.TabIndex = 0;
            this.btOnOff.Text = "Enabled";
            this.btOnOff.UseVisualStyleBackColor = true;
            this.btOnOff.Click += new System.EventHandler(this.btOnOff_Click);
            // 
            // lbAdminSate
            // 
            this.lbAdminSate.AutoSize = true;
            this.lbAdminSate.Location = new System.Drawing.Point(270, 39);
            this.lbAdminSate.Name = "lbAdminSate";
            this.lbAdminSate.Size = new System.Drawing.Size(68, 20);
            this.lbAdminSate.TabIndex = 2;
            this.lbAdminSate.Text = "Disabled";
            // 
            // lbNameCard
            // 
            this.lbNameCard.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNameCard.Location = new System.Drawing.Point(0, 34);
            this.lbNameCard.Name = "lbNameCard";
            this.lbNameCard.Size = new System.Drawing.Size(238, 25);
            this.lbNameCard.TabIndex = 1;
            this.lbNameCard.Text = "Ethernet";
            this.lbNameCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ControlCardMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ControlCardMang";
            this.Size = new System.Drawing.Size(622, 92);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNameCard;
        private System.Windows.Forms.Label lbAdminSate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btOnOff;
    }
}
