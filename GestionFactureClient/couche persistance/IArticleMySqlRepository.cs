using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionFactureClient.couche_persistance
{
    interface IArticleMySqlRepository
    {
        public Articles Select(int idArticle);

        public List<Articles> selectAll();
        public void Insert(Articles article);
        public void ModifyArticle( Articles article);
        
        public void DeleteArticle(int idArticle);
        


    }
}
