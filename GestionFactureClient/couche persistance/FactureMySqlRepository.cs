using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionFactureClient.couche_persistance
{
    class FactureMySqlRepository: MysqlRepository, IFactureMySqlRepository
    {
        private ClientMySqlRepository clientRepo;
        private FactureArticlesMySqlRepository faArRepo;
        internal FactureMySqlRepository(string adresseServeur, string nomBD, string nomUtilisateur, string motDePasse, ClientMySqlRepository ClientRepo
            , FactureArticlesMySqlRepository FaArRepo, int port = 3306) : base(adresseServeur, nomBD, nomUtilisateur, motDePasse, port)
        {
            this.clientRepo = ClientRepo;
            this.faArRepo = FaArRepo;
        }
        
        public Facture select(int id)
        {
            Facture x = null;

            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();
            using MySqlCommand cmd = new MySqlCommand("Select * FROM Facture where IdFacture = @id ", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            using MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                int fId = read.GetInt32("IdFacture");
                int cId = read.GetInt32("clientFacture");
                DateTime date = read.GetDateTime("dateFacture");

                // Pour alle chercher l'objet client de la facture
                List<Client> listeC = this.clientRepo.selectAll();
                Client clientF = null;
                for (int i = 0; i < listeC.Count; i++)
                {
                    if(listeC[i].IdClient == cId)
                    {

                        clientF = listeC[i];

                    }
                }
                

                //on ajoute les attributs a la facture
                x = new Facture();
                x.IdFacture = fId;
                if (clientF != null) {
                    x.ClientFacture = clientF;
                }
                x.DateFacture = date;

                
            }
            return x;

        }

        public List<Facture> selectAll() {
            
            
            List<Facture> listeFacture = new List<Facture>();
            using MySqlConnection connection = new MySqlConnection(base.chaineDeConnexion);
            connection.Open();
            using MySqlCommand command = new MySqlCommand("SELECT * FROM Facture", connection);
            command.Prepare();
            using MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                int id = reader.GetInt32("IdFacture");
                Facture x = select(id);
                listeFacture.Add(x);


            }

            return listeFacture;







        }

        public void insert(Facture x)
        {
            /*int id = x.ClientFacture.IdClient + 1;*/
            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();
            using MySqlCommand cmd = new MySqlCommand("INSERT INTO Facture(clientFacture,dateFacture,totalVente,totalTaxe,totalCout,prixFinal) VALUES(@cFa,@dFa,@tVen,@tTax,@tCou,@pFin)", conn);
            cmd.Parameters.AddWithValue("@cFa", x.ClientFacture.IdClient);
            cmd.Parameters.AddWithValue("@dFa", x.DateFacture);
            cmd.Parameters.AddWithValue("@tVen", x.TotalVente);
            cmd.Parameters.AddWithValue("@tTax", x.TotalTaxe);
            cmd.Parameters.AddWithValue("@tCou", x.TotalCout);
            cmd.Parameters.AddWithValue("@pFin", x.PrixFinal);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            x.IdFacture = Convert.ToInt32(cmd.LastInsertedId);

            



        }

        public void update(Facture x)
        {
         

            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();
            using MySqlCommand cmd = new MySqlCommand("UPDATE Facture SET clientFacture = @cFa,dateFacture = @dFa,totalVente = @tVen,totalTaxe = @tTax,totalCout =@tCou,prixFinal = @pFin where IdFacture =@id ", conn);
            
            cmd.Parameters.AddWithValue("@id", x.IdFacture);
            cmd.Parameters.AddWithValue("@cFa", x.ClientFacture.IdClient);
            cmd.Parameters.AddWithValue("@dFa", x.DateFacture);
            cmd.Parameters.AddWithValue("@tVen", x.TotalVente);
            cmd.Parameters.AddWithValue("@tTax", x.TotalTaxe);
            cmd.Parameters.AddWithValue("@tCou", x.TotalCout);
            cmd.Parameters.AddWithValue("@pFin", x.PrixFinal);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
           
            
        }

        public void delete(int x)
        {
            using MySqlConnection conn = new MySqlConnection(base.chaineDeConnexion);
            conn.Open();
            using MySqlCommand cmd = new MySqlCommand("DELETE FROM Facture where IdFacture = @id", conn);
            cmd.Parameters.AddWithValue("@id", x);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            

        }
        
    }
}
