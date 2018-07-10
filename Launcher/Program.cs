using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace Launcher
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main mainForm = new main();
            Application.Run(mainForm);
        }

    }


   
}


    

