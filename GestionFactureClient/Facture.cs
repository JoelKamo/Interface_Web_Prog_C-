using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFactureClient
{
    class Facture
    {

        public int ID
        {
            get; set;
        }

        public string NoFacture { get; set; }

        //Caracteristique de l'objet Facture


        public static List<Contact> NewContact = new List<Contact>();
        

        //public int QuantiteArticle { get; set; }
        public string NomArticle { get; set; }
        public double PrixArticle { get; set; }
        public string TypeClients { get; set; }

        public Contact C { get; set; }

        public static int cmp = 0;

        public Facture()
        {
            cmp++;
            this.ID = cmp;
        }

        public Facture(String NoFacture)
        {
            cmp++;
            this.ID = cmp;
            this.NoFacture = NoFacture;
        }

    }
}
