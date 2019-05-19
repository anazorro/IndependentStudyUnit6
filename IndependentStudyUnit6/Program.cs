using System;
using System.Windows.Forms;

namespace IndependentStudyUnit6
{
    static class Program
    {
        /// <summary>
        /// CO453 Application Programming
        /// BNU Student ID 21903356
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DrawingAHouse());
        }
    }
}