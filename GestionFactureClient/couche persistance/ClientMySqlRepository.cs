using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionFactureClient.couche_persistance
{
    class ClientMySqlRepository : MysqlRepository, IClientMySqlRepository
    {

        internal ClientMySqlRepository(string adresseServeur, string nomBD,
          string nomUtilisateur, string motDePasse, int port = 3306) :
          base(adresseServeur, nomBD, nomUtilisateur, motDePasse, port)
        {

        }

        public Client select(int id) {

            Client x = null;
            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand("select * FROM Client where idClient = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            using MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                string nom = reader.GetString("nomClient");
                string prenom = reader.GetString("prenomClient");
                string adresse = reader.GetString("adresseClient");
                string ville = reader.GetString("villeClient");
                int idClient = reader.GetInt32("idClient");

                x = new Client(nom, prenom, adresse, ville);
                x.IdClient = idClient;
                



            }

            return x;


        }

        public List<Client> selectAll()
        {
            List<Client> liste = new List<Client>();

            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand("Select * From Client", conn);
            cmd.Prepare();

            using MySqlDataReader rea = cmd.ExecuteReader();
            while (rea.Read())
            {
                Client x = new Client(rea.GetString("nomClient"), rea.GetString("prenomClient"), rea.GetString("adresseClient"), rea.GetString("villeClient"));
                x.IdClient = Convert.ToInt32(rea.GetInt64("idClient"));
                liste.Add(x);



            }
            return liste;


        }

        public void insert(Client client) {
            
            
            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand("INSERT INTO Client(nomClient,prenomClient,adresseClient,villeClient) VALUES(@nom,@pre,@ad,@v)", conn);
            cmd.Parameters.AddWithValue("nomClient", client.Nom);
            cmd.Parameters.AddWithValue("prenomClient", client.Prenom);
            cmd.Parameters.AddWithValue("addresseClient",client.Adresse);
            cmd.Parameters.AddWithValue("villeClient",client.Ville);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            client.IdClient = Convert.ToInt32(cmd.LastInsertedId);


        }

        
        public void updateClient(Client c)
        {
           using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand("UPDATE Client SET nomCLient = @n, prenomClient = @p, adresseClient = @a, villeClient = @v where idClient = @id", conn);
            cmd.Parameters.AddWithValue("id", c.IdClient);
            cmd.Parameters.AddWithValue("n", c.Nom);
            cmd.Parameters.AddWithValue("p", c.Prenom);
            cmd.Parameters.AddWithValue("a",c.Adresse);
            cmd.Parameters.AddWithValue("v",c.Ville);
            cmd.Prepare();
            cmd.ExecuteNonQuery();



        }

        public void delete(int id)
        {
            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();

            using MySqlCommand cmd = new MySqlCommand("DELETE FROM Client where idClient = @id", conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();



        }
        
    }
}
