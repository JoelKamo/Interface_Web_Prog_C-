using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFactureClient
{
    class Client
    {

        public int IDClient
        {
            get; set;
        }

        public string NoClient { get; set; }


        //Caracteristique de l'objet Client

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }




        public static int cmp = 0;


        public Client()
        {
            cmp++;
            this.IDClient = cmp;
        }

        public Client(String NoClient)
        {
            cmp++;
            this.IDClient = cmp;
            this.NoClient = NoClient;


        }





    }
}
