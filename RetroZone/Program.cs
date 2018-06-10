using HttpClient;
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
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    switch (args[i])
                    {
                        case "--api-url":
                            {
                                ApiCaller.APIUrl = args[1];
                                break;
                            }
                        case "--version":
                            {
                                Console.WriteLine(ApiCaller.APIVersion);
                                Environment.Exit(0);
                                break;
                            }
                    }
                }
            }

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
