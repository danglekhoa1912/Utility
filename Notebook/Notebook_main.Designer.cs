namespace Utility.Notebook
{
    partial class Notebook_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsAddnb = new System.Windows.Forms.ToolStripMenuItem();
            this.lblnote = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAddnb});
            this.menuStrip1.Location = new System.Drawing.Point(800, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsAddnb
            // 
            this.mnsAddnb.BackColor = System.Drawing.Color.White;
            this.mnsAddnb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnsAddnb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsAddnb.ForeColor = System.Drawing.Color.Black;
            this.mnsAddnb.Name = "mnsAddnb";
            this.mnsAddnb.Size = new System.Drawing.Size(35, 34);
            this.mnsAddnb.Text = "+";
            this.mnsAddnb.Click += new System.EventHandler(this.mnsAddnb_Click);
            // 
            // lblnote
            // 
            this.lblnote.BackColor = System.Drawing.Color.White;
            this.lblnote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblnote.Location = new System.Drawing.Point(20, 101);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(856, 550);
            this.lblnote.TabIndex = 2;
            // 
            // Notebook_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(896, 671);
            this.Controls.Add(this.lblnote);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Notebook_main";
            this.Resizable = false;
            this.Text = "Notebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notebook_main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsAddnb;
        private System.Windows.Forms.Panel lblnote;
    }
}