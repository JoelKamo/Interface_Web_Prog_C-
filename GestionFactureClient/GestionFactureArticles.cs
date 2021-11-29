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
    public partial class GestionFactureArticles : Form
    {
        systemeController smc = new systemeController();
        public GestionFactureArticles()
        {
            InitializeComponent();
            GetFacture();
            GetArticles();
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
            double somme = 0;
            for (int i = 0; i < dgv_FactureClients.Rows.Count; i++)
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
           // comboBox2.Text = dgv_FactureClients.CurrentRow.Cells[1].Value.ToString();
           // comboBox1.Text = dgv_FactureClients.CurrentRow.Cells[2].Value.ToString();
           // txt_PrixArticle.Text = dgv_FactureClients.CurrentRow.Cells[3].Value.ToString();


        }

        //Ajouter Article dans le dataView
        private void button1_Click(object sender, EventArgs e)
        {

            List<Articles> listeA = smc.ArticleGetAll();
            string var = comboBox1.SelectedItem.ToString();
            Articles x = null;
            for (int i = 0; i < listeA.Count; i++)

            {
                if (var.Contains($"id:{listeA[i].IdArticle}"))
                {
                    x = listeA[i];
                }

            }

            smc.ArticleSelect(x.IdArticle);

            List<Facture> listeF = smc.FactureSelectAll();
            string var2 = comboBox2.SelectedItem.ToString();
            Facture y = null;
            for (int i = 0; i < listeF.Count; i++)

            {
                if (var2.Contains($"id:{listeF[i].IdFacture}"))
                {
                    y = listeF[i];
                }

            }

            smc.FactureSelect(y.IdFacture);

            smc.FacturesupprimerArticle(x, y, 1);

            charger();

        }




        //Modifier Article dans le dataView
        private void button2_Click(object sender, EventArgs e)
        {
            charger();
        }

        //Supprimer Article dans le dataView
        private void button3_Click(object sender, EventArgs e)
        {
            List<Articles> listeA = smc.ArticleGetAll();
            string var = comboBox1.SelectedItem.ToString();
            Articles y = null;
            for (int i = 0; i < listeA.Count; i++)

            {
                if (var.Contains($"id:{listeA[i].IdArticle}"))
                {
                    y = listeA[i];
                }

            }

            List<Facture> listeF = smc.FactureSelectAll();
            string var2 = comboBox2.SelectedItem.ToString();
            Facture x = null;
            for (int i = 0; i < listeF.Count; i++)

            {
                if (var2.Contains($"id:{listeF[i].IdFacture}"))
                {
                    x = listeF[i];
                }

            }

            smc.FactureAjouterArticle(y, x);
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

        public void GetArticles()
        {
            comboBox1.Items.Clear();
            List<Articles> listeA = smc.ArticleGetAll();
            List<String> listeNomA = new List<string>();
            for (int i = 0; i < listeA.Count; i++)
            {
                listeNomA.Add("id:" + listeA[i].IdArticle + " nom: " + listeA[i].NomArticle + "  prix :" + listeA[i].PrixVendu);

            }

            for (int i = 0; i < listeNomA.Count; i++)
            {
                comboBox1.Items.Add(listeNomA[i].ToString());
                comboBox1.DisplayMember = (listeNomA[i].ToString());

            }

        }
        public void charger()
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

            smc.FactureSelect(x.IdFacture);
            List<Articles> listeA = x.ListeArticles;
  
           

                dgv_FactureClients.Rows.Clear();
                for (int i = 0; i < listeA.Count; i++)
                {
                    dgv_FactureClients.Rows.Add(listeA[i].IdArticle,
                    listeA[i].NomArticle,listeA[i].PrixVendu, listeA[i].PrixVendu * 0.1495, listeA[i].PrixVendu + listeA[i].PrixVendu * 0.1495) ;
                }

            dgv_FactureClients.Rows.Add("-", "-", "-", "-", x.PrixFinal);






        }
    }
}
