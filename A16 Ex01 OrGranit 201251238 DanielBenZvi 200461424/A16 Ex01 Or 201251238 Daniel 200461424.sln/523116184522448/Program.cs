﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _523116184522448
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new MainForm());
            }
            catch(Exception ex)
            {
                MessageBox.Show("App overflow");
            }
        }
    }
}
