using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFactureClient
{
    class Articles
    {


        public int ID
        {
            get; set;
        }

        public string NoFacture { get; set; }

        //Caracteristique de l'objet Facture

        public string NoSerie { get; set; }
        public string NomArticle { get; set; }
        public int QuantiteInventaire { get; set; }
        public double PrixDetail { get; set; }
        public double PrixVendu { get; set; }

        /*
        public Clients C { get; set; }
         */

        public static int cmp = 0;
       

        public Articles()
        {
            cmp++;
            this.ID = cmp;
        }

        public Articles(String NoSerie)
        {
            cmp++;
            this.ID = cmp;
            this.NoSerie = NoSerie;


        }



    }
}
