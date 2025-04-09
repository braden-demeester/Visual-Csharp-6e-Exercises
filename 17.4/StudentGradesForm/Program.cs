using System;
using System.Windows.Forms;

namespace StudentGradesForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and run an instance of StudentGradesForm
            Application.Run(new StudentGradesForm());
        }
    }
}
