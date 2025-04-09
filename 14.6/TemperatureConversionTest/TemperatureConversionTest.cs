using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TemperatureConversionTest
{
    public static class TemperatureConversionTest
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TemperatureConversionForm());

        }
    }
}
