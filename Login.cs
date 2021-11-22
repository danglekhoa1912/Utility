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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh giaoDienChinh = new GiaoDienChinh();
            giaoDienChinh.ShowDialog();
            this.Close();
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
