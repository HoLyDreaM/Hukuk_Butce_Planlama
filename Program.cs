﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Verda_Hukuk_Raporlama
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        internal static ApplicationContext ac = new ApplicationContext();
        [STAThread]
        static void Main()
        {
            try
            {
                DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                ac.MainForm = new LoginForm();
                Application.Run(ac);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
