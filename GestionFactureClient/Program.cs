using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFactureClient
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static List<Articles> Articles = new List<Articles>();
        public static List<Client> Client = new List<Client>();

        //systemeController smc = new systemeController();

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            systemeController smc = new systemeController();
        }
    }
}
