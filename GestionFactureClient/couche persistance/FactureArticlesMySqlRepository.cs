using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionFactureClient.couche_persistance
{
    class FactureArticlesMySqlRepository : MysqlRepository, IFactureArticlesMySqlRepository
    {
        private ArticleMySqlRepository articleRepo;

        internal FactureArticlesMySqlRepository(string adresseServeur, string nomBD,
        string nomUtilisateur, string motDePasse, ArticleMySqlRepository ArticleRepo, int port = 3306) :
        base(adresseServeur, nomBD, nomUtilisateur, motDePasse, port)
        {
            this.articleRepo = ArticleRepo;
        }

    
    

        public List<FactureArticle> getAllElement()
        {
            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();
            List<FactureArticle> liste = new List<FactureArticle>();


            using MySqlCommand cmd = new MySqlCommand("SELECT * FROM FactureArticle", conn);
            cmd.Prepare();
            using MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                int idF = reader.GetInt32("idFacture");
                int idA = reader.GetInt32("idArticle");

                FactureArticle x = new FactureArticle(idF, idA);
                x.IdItemFacture = Convert.ToInt32(cmd.LastInsertedId);

                liste.Add(x);

            }

            return liste;

        }

        public void insert(FactureArticle x)
        {     
            using MySqlConnection connect = new MySqlConnection(base.chaineDeConnexion);
            connect.Open();

            using MySqlCommand cmd = new MySqlCommand("INSERT INTO FactureArticle(idFacture,idArticle) Values(@idf,@ida)", connect);
            cmd.Parameters.AddWithValue("@idf", x.IdFacture);
            cmd.Parameters.AddWithValue("@ida", x.IdArticle);
          
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            x.IdItemFacture = Convert.ToInt32(cmd.LastInsertedId);

        }

 

        public void deleteElement(int idFacture, int idArticle)
        {
            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();


            using MySqlCommand cmd = new MySqlCommand("DELETE FROM FactureArticle where idFacture = @id && idArticle = @id2", conn);
            cmd.Parameters.AddWithValue("@id2", idArticle);
            cmd.Parameters.AddWithValue("@id", idFacture);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }
      

    }
}
