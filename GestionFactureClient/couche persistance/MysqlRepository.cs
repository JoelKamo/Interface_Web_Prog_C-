using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace GestionFactureClient.couche_persistance
{
    abstract internal class MysqlRepository
    {
        protected string chaineDeConnexion = "";

        protected MysqlRepository(string adresseServeur, string nomBD, string nomUtilisateur, string motDePasse, int port = 3306)
        {
            chaineDeConnexion = $"server={"127.0.0.1"};" +
            $"port={3306};uid={"root"};" +
            $"pwd={"viveJesus123!"};database={"SystemeFacturation"}";
            using (MySqlConnection conn = new MySqlConnection(chaineDeConnexion))
            {

                conn.Open();
            }
        }


    }
}
