using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Utility.TatMang
{
    public class CardMang
    {
        string name, adminState;

        public CardMang(string adminState, string name)
        {
            this.name = name;
            this.adminState = adminState;
        }

        public string Name { get => name; set => name = value; }
        public string AdminState { get => adminState; set => adminState = value; }

        public void XuLy(string handle)
        {
            string cmdCommand = "/C netsh interface set interface \"" + this.Name + "\" " + handle;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = cmdCommand;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            adminState = handle +"d";
        }
    }
}
