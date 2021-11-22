using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFactureClient.couche_persistance
{
    interface IFactureMySqlRepository
    {

        public Facture select(int id);

        public List<Facture> selectAll();

        public void insert(Facture x);

        public void update(Facture x);

        public void delete(int x);



    }
}
