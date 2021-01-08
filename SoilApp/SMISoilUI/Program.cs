using SoilLibrary;
using System;
using System.Windows.Forms;

namespace SMISoilUI
{
    static class Program
    {
        // TODO - Comment everything with XML comments 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.InitializeConnection();
            Application.Run(new HomeForm());
        }
    }
}
