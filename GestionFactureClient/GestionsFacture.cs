using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFactureClient
{
    public partial class GestionsFacture : Form
    {
        public GestionsFacture()
        {
            InitializeComponent();
        }


        // Cette partie charge l'interface ( on ne la code pas ) 
        private void Form1_Load(object sender, EventArgs e)
        {

         
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        // Ici on dois pouvoir recuperer les noms des clients enregistrer dans Contact 
        private void cb_Clients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        // Lui il dois renvoyez le prix total de tous les articles qui sont dans le dataView
        private void txt_TotalArticle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        // Ici le prix dois correspondre au prix de l'article que le client aura choisit 
        private void txt_PrixArticle_TextChanged(object sender, EventArgs e)
        {

        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }


        //cette partie fais apparaitre les donnees entres (A savoir ID, Client, NomArticle, prixArticle...)pluhaut dans le dataView 
        private void dgv_Clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Ajouter Article dans le dataView
        private void button1_Click(object sender, EventArgs e)
        {
     


        }

        //Modifier Article dans le dataView
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Supprimer Article dans le dataView
        private void button3_Click(object sender, EventArgs e)
        {

        }


        //Quitter dans la fenetre Gestion facture
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Ici on dois pouvoir recuperer les noms des Articles entres dans la classe Articles ou dans l'interface Gestion
        private void cb_TypeClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
