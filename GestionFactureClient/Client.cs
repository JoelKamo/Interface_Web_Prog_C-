using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFactureClient
{
    public class Client
    {

        private string nom;
        private string prenom;
        private string adresse;
        private string ville;
        private int idClient;


        public Client(string Nom, string Prenom, string Adresse, string Ville)
        {

            this.nom = Nom;
            this.prenom = Prenom;
            this.adresse = Adresse;
            this.ville = Ville;


        }

        public int IDClient
        {
            get; set;
        }

        public string NoClient { get; set; }


        //Caracteristique de l'objet Client

        public string Nom { get { return nom; } set { this.nom = value; } }
        public string Prenom { get { return prenom; } set { this.prenom = value; } }
        public string Adresse { get { return adresse; } set { this.adresse = value; } }
        public string Ville { get { return ville; } set { this.ville = value; } }
        public int IdClient { get { return idClient; } set { this.idClient = value; } }




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

        public override string ToString()
        {
            return $"id:{this.IdClient} Nom: {this.Nom}, Prenom: {this.Prenom}, Adresse {this.Adresse}, Ville: {this.Ville}";
        }





    }
}
