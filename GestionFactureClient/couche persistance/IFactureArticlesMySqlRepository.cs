using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFactureClient.couche_persistance
{
    interface IFactureArticlesMySqlRepository
    {

  
        public List<FactureArticle> getAllElement();

        public void insert(FactureArticle x);

        public void deleteElement(int idFacture, int idArticle);

    }
}
