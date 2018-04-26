using System;
using System.Windows.Forms;

namespace CST_117_Exercise_1_EWilson
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
            Application.Run(new Exercises1And2());
        }
    }
}
