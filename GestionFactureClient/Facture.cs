using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFactureClient
{
    public class Facture
    {

        private int idFacture;
        private List<Articles> listeArticles;
        private Client clientFacture;
        private DateTime dateFacture;
        private double totalVente;
        private double totalTaxe;
        private double totalCout;
        private double prixFinal;

        internal Facture()
        {
            this.listeArticles = new List<Articles>();
            this.dateFacture = DateTime.Now;
        }
        public List<Articles> ListeArticles { get { return listeArticles; } set { this.listeArticles = value; } }
        public Client ClientFacture { get { return clientFacture; } set { this.clientFacture = value; } }

        public DateTime DateFacture { get { return dateFacture; } set { dateFacture = value; } }

        public int IdFacture { get { return idFacture; } set { idFacture = value; } }
        public double TotalVente
        {

            get
            {
                double total = 0;

                for (int i = 0; i < this.ListeArticles.Count; i++)
                {
                    total = total + this.ListeArticles[i].PrixVendu;

                }
                total = Math.Round(total, 2);
                return total;
            }
        }

        public double TotalTaxe
        {
            get
            {
                return Math.Round(this.TotalVente * 0.1495,2);
            }
        }

        public double TotalCout
        {
            get
            {
                double total = 0;
                for (int i = 0; i < this.ListeArticles.Count; i++)
                {
                    total = total + this.ListeArticles[i].PrixDetail;

                }
                total = Math.Round(total, 2);
                return total;
            }
        }
        public double PrixFinal { get { return Math.Round(this.TotalVente + this.TotalTaxe, 2); } }




        public override string ToString()
        {
            return $"idFacture:{this.IdFacture}, client:{this.ClientFacture.Prenom} nb article:{ this.ListeArticles.Count} \n cout d'achat : { this.TotalCout} \n vente total : {this.TotalVente} \n taxe :{this.TotalTaxe}\n Prix vente final:{this.PrixFinal} ";
        }

  
        //public string NoFacture { get; set; }

        //Caracteristique de l'objet Facture

        /*
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

        */







    }
}
