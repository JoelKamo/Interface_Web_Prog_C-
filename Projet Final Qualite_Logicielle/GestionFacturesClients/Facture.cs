using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFacturesClients
{
    class Facture
    {

        public int ID
        {
            get; set;
        }

        public string NoFacture { get; set; }

        //Caracteristique de l'objet Facture

        public string NomArticle { get; set; }
        public int QuantiteArticle { get; set; }
        public double PrixArticle { get; set; }
        public  double TotalArticle { get; set; }

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
