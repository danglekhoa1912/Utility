using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace Utility.TatMang
{
    public partial class FormTatMang : Form
    {
        ArrayList listCardNet = new ArrayList();
        public FormTatMang()
        {
            InitializeComponent();
            getNameCardNetEthernet();
            Load();
        }

        //


        //Load list card network

        void Load()
        {
            fPanel.Controls.Clear();
            foreach (CardMang i in listCardNet)
            {
                FormCardMang ctrCardMang = new FormCardMang(i);
                fPanel.Controls.Add(ctrCardMang);
            }
        }

        //Xu ly tat mang
        void XuLy(string handle)
        {
            foreach (CardMang i in listCardNet)
            {
                i.XuLy(handle);
            }
            Load();
        }

        //Lay ten card mang Ethernet
        void getNameCardNetEthernet()
        {
            //chay lenh ipconfig
            string cmdCommand = "netsh interface show interface";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;

            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

            p.StandardInput.WriteLine(cmdCommand);
            p.StandardInput.Flush();
            p.StandardInput.Close();
            p.WaitForExit();

            //cu ly tach tung dong ket qua trong cmd de lay ten card mang va trang thai
            string nameCard;
            while (!p.StandardOutput.EndOfStream)
            {
                nameCard = p.StandardOutput.ReadLine();
                if (nameCard.IndexOf("Enabled") != -1 || nameCard.IndexOf("Disabled") != -1)
                {
                    nameCard = xuLyChuoi(nameCard);
                    MessageBox.Show(nameCard);
                    string[] test = nameCard.Split(' ', '4');

                    listCardNet.Add(new CardMang(test[0], test[3]));
                }
            }

        }

        //Lay ten card mang Wireless


        private void btnDisconnect_Click(object sender, EventArgs e)
        {

            XuLy("Disable");
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            XuLy("Enable");
        }


        string xuLyChuoi(string s)
        {
            while (s.IndexOf("  ") != -1)
            {
                s = s.Replace("  ", " ");
            }
            return s;
        }
    }
}
