using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utility
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh giaoDienChinh = new GiaoDienChinh();
            giaoDienChinh.UiLogin = this;
            giaoDienChinh.ShowDialog();
            //if (giaoDienChinh.IsClose==2)
            //{
            //    this.Close();
            //}
            //else if (giaoDienChinh.IsClose == 3)
            //{
            //    this.Show();
            //}

        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
