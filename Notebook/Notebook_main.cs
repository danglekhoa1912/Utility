using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Utility.Notebook
{
    public partial class Notebook_main : MetroFramework.Forms.MetroForm
    {
        private int scr = 94;
        private listnotes notes;

        public listnotes Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        private string filePath = "datanote.xml";
        FlowLayoutPanel fPanel = new FlowLayoutPanel() { AutoScroll = true };

        public Notebook_main()
        {
            InitializeComponent();
            lblnote.Controls.Add(fPanel);
            fPanel.Width =lblnote.Width;
            fPanel.Height =lblnote.Height;
            try
            {
                notes = Deserialize() as listnotes;
            }
            catch 
            { 
            }
            loadListNote();
        }

        void loadListNote()
        {
            fPanel.Controls.Clear();
            if(notes != null)
            {
                foreach(var note in notes.Note)
                {
                    AddNote(note);
                    scr += 150;
                }
            }
        }

        void AddNote(Note item)
        {
            ANote note = new ANote(item);
            note.Edited += aNote_Edited;
            note.Deleted += aNote_Deleted;
            fPanel.Controls.Add(note);

            //fPanel.Controls[notes.Note.Count].Focus();
        }
        void aNote_Deleted(object sender, EventArgs e)
        {
            ANote cv = sender as ANote;
            Note note = cv.Note;
            fPanel.Controls.Remove(cv);
            notes.Note.Remove(note);
        }

        void aNote_Edited(object sender, EventArgs e)
        {

        }
        private void Serialize(object data)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(listnotes));
            sr.Serialize(fs, data);
            fs.Close();
        }   
        private object Deserialize()
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(listnotes));
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

        private void mnsAddnb_Click(object sender, EventArgs e)
        {
            if (notes == null || notes.Note == null)
            {
                notes = new listnotes();
                notes.Note = new List<Note>();
            }
            if (notes.Note.Count == 0)
                fPanel.Controls.Clear();
            Note note=new Note();
            notes.Note.Add(note);
            AddNote(note);
            fPanel.AutoScrollPosition= new Point(0,scr);
            scr += 150;
        }


        private void Notebook_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialize(notes);
        }
    }
}
