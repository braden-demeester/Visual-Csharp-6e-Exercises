using System;
using System.Windows.Forms;

namespace EnhancedPainter
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and run an instance of the form
            Application.Run(new PainterForm());
        }
    }
}
