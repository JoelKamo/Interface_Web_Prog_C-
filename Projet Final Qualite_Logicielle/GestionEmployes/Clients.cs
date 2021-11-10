using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFacturesClients
{
    class Clients
    {

        public int ID
        {
            get; set;
        }

        public string Libelle { get; set; }
        public static int cmp = 0;

        public Clients ()
        {
            cmp++;
            this.ID = cmp;
        }

        public Clients(String Libelle)
        {
            cmp++;
            this.ID = cmp;
            this.Libelle = Libelle;
        }
    }
}
