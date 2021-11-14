using GestionFacturesClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFacturesClients
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static List<Clients> Clients = new List<Clients>();
        public static List<Facture> Facture = new List<Facture>();
        [STAThread]
        static void Main()
        {

            Clients.Add(new Clients("Joel Kamo"));
            Clients.Add(new Clients("Samira"));
            Clients.Add(new Clients("James"));
            Clients.Add(new Clients("Dominique"));
            Clients.Add(new Clients("Hind"));





            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gestions());
        }
    }
}
