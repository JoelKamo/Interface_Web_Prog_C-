using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFactureClient
{
    public class FactureArticle
    {
        private int idFacture;
        private int idArticle;
        private int idItemFacture;
    


        internal FactureArticle(int IdFacture, int IdArticle )
        {
            this.idFacture = IdFacture;
            this.idArticle = IdArticle;
          

        }

        public int IdItemFacture { get { return idItemFacture; } set { this.idItemFacture = value; } }
  
        public int IdFacture { get{ return idFacture; } }
        public int IdArticle { get{ return idArticle; } }

    }
}
