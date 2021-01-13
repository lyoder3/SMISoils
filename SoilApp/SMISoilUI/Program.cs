using SoilLibrary;
using System;
using System.Windows.Forms;

namespace SMISoilUI
{
    static class Program
    {
        // TODO - Comment everything with XML comments
        // TODO - WANT: Make new UI with WPF using Caliburn.Micro to do MVVM

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.Initialize();
            Application.Run(new CreateAnalysisForm());
        }
    }
}
