using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace GestionFactureClient.couche_persistance
{
    class ArticleMySqlRepository : MysqlRepository , IArticleMySqlRepository
    {

        internal ArticleMySqlRepository(string adresseServeur, string nomBD, string nomUtilisateur, string motDePasse,  int port = 3306) : base(adresseServeur, nomBD, nomUtilisateur, motDePasse, port)
        {
        
        }

        public Articles Select(int idArticle) {

            Articles x = null;

            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Articles WHERE idArticle =@idArticle", conn);
            cmd.Parameters.AddWithValue("@idArticle", idArticle);
            cmd.Prepare();

            using MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                
                string NomArticle= reader.GetString("nomArticle");
                double PrixDetail = reader.GetDouble("prixDetail");
                double PrixVente = reader.GetDouble("prixVente");
                int QuantInventaire = reader.GetInt32("quantiteInventaire");
                int id = reader.GetInt32("IdArticle");
                x = new Articles(NomArticle, QuantInventaire, PrixDetail, PrixVente);
                x.IdArticle = id;



            }
            return x;
        }

        public List<Articles> selectAll()
        {
            List<Articles> x = new List<Articles>();
            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand("Select * From Articles", conn);
            cmd.Prepare();

            using MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                Articles y = new Articles(read.GetString("nomArticle"), read.GetInt32("quantiteInventaire"), read.GetDouble("prixDetail"), read.GetDouble("prixVente"));
                y.IdArticle = Convert.ToInt32(read.GetInt64("idArticle"));
                x.Add(y);

            }

            return x;

        }

        public void Insert(Articles x)
        {
            using MySqlConnection connection = new MySqlConnection(base.chaineDeConnexion);
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO Articles(nomArticle,quantiteInventaire,prixDetail,prixVente) VALUES(@nom,@quant,@detail,@vente)", connection);
            command.Parameters.AddWithValue("@nom", x.NomArticle);
            command.Parameters.AddWithValue("@quant", x.QuantiteInventaire);
            command.Parameters.AddWithValue("@detail", x.PrixDetail);
            command.Parameters.AddWithValue("@vente", x.PrixVendu);
            command.Prepare();
            command.ExecuteNonQuery();
            x.IdArticle = Convert.ToInt32(command.LastInsertedId);


        }
        public void ModifyArticle( Articles article)
        {
            using MySqlConnection connection = new MySqlConnection(base.chaineDeConnexion);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Update Articles SET nomArticle = @nom, quantiteInventaire = @quant, prixDetail = @detail, prixVente = @vente where idArticle = @id", connection );
            cmd.Parameters.AddWithValue("@id", article.IdArticle );
            cmd.Parameters.AddWithValue("@nom", article.NomArticle);
            cmd.Parameters.AddWithValue("@quant", article.QuantiteInventaire);
            cmd.Parameters.AddWithValue("@detail", article.PrixDetail);
            cmd.Parameters.AddWithValue("@vente", article.PrixVendu);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
         }

        public void DeleteArticle(int idArticle)
        {
            using MySqlConnection connection = new MySqlConnection(base.chaineDeConnexion);
            connection.Open();
            using MySqlCommand cmd = new MySqlCommand("DELETE FROM Articles WHERE IdArticle = @id", connection);
            cmd.Parameters.AddWithValue("@id", idArticle);
            cmd.Prepare();
            cmd.ExecuteNonQuery();



        }
    }
}
