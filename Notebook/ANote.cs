using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Utility.Notebook
{
    public partial class ANote : UserControl
    {
        private Note note;

        public Note Note
        {
            get => note;
            set => note = value;
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

        public ANote(Note note)
        {
            
            InitializeComponent();
            this.note = note;
            if (note.Content == null)
            {
                btnEdit.Text = "Lưu";
                this.ActiveControl = txtb;
                txtb.Focus();
            }
            else
            {
                ShowInfor();
            }
        }
        void ShowInfor()
        {
            txtb.Text = note.Content;
            txtb.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)){
                if (btnEdit.Text == "Sửa")
                {
                    btnEdit.Text = "Lưu";
                    txtb.Enabled= true;
                }
                else
                {
                    btnEdit.Text = "Sửa";
                    txtb.Enabled = false;
                    note.Content= txtb.Text;
                    ShowInfor();
                }
                if (edited != null)
                {
                    edited(this, new EventArgs());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
            {
                deleted(this, new EventArgs());
                try
                {
                    System.IO.File.Delete(@"datanote.xml");
                }
                catch { }
            }
        }
    }
}
