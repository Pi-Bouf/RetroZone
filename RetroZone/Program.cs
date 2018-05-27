using RetroZone.Forms;
using System;
using System.Windows.Forms;

namespace RetroZone
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
            Application.Run(new FormMain());
#else
            Application.Run(new SplashScreen());
#endif
        }
    }
}
