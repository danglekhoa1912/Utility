﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utility.HenGioTatMay;
using Utility.NhacLichLamViec;
using Utility.TatMang;
using Utility.Notebook;

namespace Utility
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new Notebook_main());
        }
    }
}
