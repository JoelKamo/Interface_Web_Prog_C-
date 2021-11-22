using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFactureClient
{
    public class Articles
    {

        private string nomArticle;
        private int quantInventaire;
        private double prixDetail;
        private double prixVente;
        private int idArticle;
        public Articles(string NomArticle, int QuantInventaire, double PrixDetail, double PrixVente)
        {
            this.nomArticle = NomArticle;
            this.quantInventaire = QuantInventaire;
            this.prixDetail = PrixDetail;
            this.prixVente = PrixVente;

        }

        public int IdArticle
        {
            get { return idArticle; }
            set { this.idArticle = value; }
        }

        public string NoFacture { get; set; }

        //Caracteristique de l'objet Facture

        //public string NoSerie { get; set; }
        public string NomArticle { get { return nomArticle; } set { this.nomArticle = value; } }
        public int QuantiteInventaire { get { return quantInventaire; } set { this.quantInventaire = value; } }
        public double PrixDetail { get { return prixDetail; } set { this.prixDetail = value; } }
        public double PrixVendu { get { return prixVente; } set { this.prixVente = value; } }

        /*
        public Clients C { get; set; }
         */

        public static int cmp = 0;



        /*
        public Articles(String NoSerie)
        {
            cmp++;
            this.ID = cmp;
            this.NoSerie = NoSerie;


        }
        */

        public override string ToString()
        {
            return $"id: {this.IdArticle} nom : {this.NomArticle}, Inventaire:{this.QuantiteInventaire}, Prix coutant : {this.prixDetail}, prix vente {this.prixVente}";
        }



    }
}
