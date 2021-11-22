using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFactureClient.couche_persistance
{
    interface IClientMySqlRepository
    {

        public Client select(int id);
        public List<Client> selectAll();
        public void insert(Client client);
        public void updateClient(Client c);
        public void delete(int id);


    }
}
