using System;
using System.Windows.Forms;

namespace GuessTheNumberGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize and run the form for the game
            Application.Run(new GuessTheNumberForm());
        }
    }
}
