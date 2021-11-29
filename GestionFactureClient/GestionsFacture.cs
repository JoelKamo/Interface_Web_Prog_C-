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
        systemeController smc = new systemeController();
        public GestionsFacture()
        {
            InitializeComponent();
            GetClients();
            GetFacture();
            charger();
        }

        public void charger()
        {
            List<Facture> liste = smc.FactureSelectAll();
            dgv_FactureClients.Rows.Clear();
            for (int i = 0; i < liste.Count; i++)
            {
                dgv_FactureClients.Rows.Add(liste[i].IdFacture,
                liste[i].ClientFacture.Nom, liste[i].ListeArticles.Count, liste[i].TotalVente);
            }
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

            GetClients();




        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        // Lui il dois renvoyez le prix total de tous les articles qui sont dans le dataView
        private void txt_TotalArticle_TextChanged(object sender, EventArgs e)
        {
            double somme = 0;
            for(int i = 0; i < dgv_FactureClients.Rows.Count; i++)
            {
                somme += Convert.ToInt32(dgv_FactureClients.Rows[i].Cells[3].Value);
            }

            MessageBox.Show(somme.ToString());
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

           // txt_id.Text = dgv_FactureClients.CurrentRow.Cells[0].Value.ToString();
           // cb_Clients.Text = dgv_FactureClients.CurrentRow.Cells[1].Value.ToString();
            //cb_Articles.Text = dgv_FactureClients.CurrentRow.Cells[2].Value.ToString();
            //txt_PrixArticle.Text = dgv_FactureClients.CurrentRow.Cells[3].Value.ToString();
          

        }

        //Ajouter une nouvelle facture
        private void button1_Click(object sender, EventArgs e)
        {
            List<Client> liste = smc.ClientGetAll();
            string var = comboBox1.SelectedItem.ToString();
            
            Client x = null;

            for (int i = 0; i < liste.Count; i++)
            {
                if (var.Contains(liste[i].Nom) && var.Contains(liste[i].Prenom))
                {
                    x = liste[i];
                }

            }

            smc.FactureCreate(x);
            GetClients();
            GetFacture();
            charger();

        }


    

        //Modifier Article dans le dataView
        private void button2_Click(object sender, EventArgs e)
        {
            GestionFactureArticles gfc = new GestionFactureArticles();
            gfc.Show();
        }

        //Supprimer Article dans le dataView
        private void button3_Click(object sender, EventArgs e)
        {

            List<Facture> listeF = smc.FactureSelectAll();
            string var = comboBox2.SelectedItem.ToString();
            Facture x = null;
            for (int i = 0; i < listeF.Count; i++)
           
            {
                if (var.Contains($"id:{listeF[i].IdFacture}"))
                {
                    x = listeF[i];
                }

            }

            smc.FactureDelete(x.IdFacture);
            GetClients();
            GetFacture();
            charger();
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

        public void GetClients()
        {
            comboBox1.Items.Clear();
            List<Client> liste = smc.ClientGetAll();
            List<String> listeNom = new List<string>();
            for (int i = 0; i < liste.Count; i++)
            {
                listeNom.Add(liste[i].Nom + " " + liste[i].Prenom);

            }

            for (int i = 0; i < listeNom.Count; i++)
            {
                comboBox1.Items.Add(listeNom[i].ToString());
                comboBox1.DisplayMember = (listeNom[i].ToString());
            }

        }

        public void GetFacture()
        {
            comboBox2.Items.Clear();
            List<Facture> listeF = smc.FactureSelectAll();
            List<String> listeNomF = new List<string>();
            for (int i = 0; i < listeF.Count; i++)
            {
                listeNomF.Add("id:" + listeF[i].IdFacture + " - " + listeF[i].ClientFacture.Nom + " " + listeF[i].ClientFacture.Prenom + ": " + " " + listeF[i].ListeArticles.Count + " articles, total:" + listeF[i].PrixFinal + "$");
            }

            for (int i = 0; i < listeNomF.Count; i++)
            {
                comboBox2.Items.Add(listeNomF[i].ToString());
                comboBox2.DisplayMember = (listeNomF[i].ToString());

            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
    }
}
