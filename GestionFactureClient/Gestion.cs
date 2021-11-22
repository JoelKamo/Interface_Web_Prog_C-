using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionFactureClient
{
    public partial class Gestion : Form
    {
        systemeController smc = new systemeController();
        public Gestion()
        {
            InitializeComponent();
        }


        // Ajouter Articles
        private void button1_Click(object sender, EventArgs e)
        {


            string NomArticle = txt_NomArticle.Text;
            int QuantiteInventaire = int.Parse(txt_QuantiteInventaire.Text);
            double PrixDetail = double.Parse(txt_PrixDetail.Text);
            double PrixVendu = double.Parse(txt_PrixVendu.Text);

            Articles article = smc.ArticleCreate(NomArticle, QuantiteInventaire, PrixDetail, PrixVendu);

            charger();

        }


        // Fonction Charger 
        public void charger()
        {
            List<Articles> liste = smc.ArticleGetAll();
            dgv_Articles.Rows.Clear();
            for (int i = 0; i < liste.Count; i++)
            {
                dgv_Articles.Rows.Add(liste[i].IdArticle, 0,
                liste[i].NomArticle, liste[i].QuantiteInventaire,
                liste[i].PrixDetail, liste[i].PrixVendu);
            }
        }


        // Modifier Articles
        private void button2_Click(object sender, EventArgs e)
        {
            List<Articles> liste = smc.ArticleGetAll();

            for (int i = 0; i < liste.Count; i++)
            {
                if (Convert.ToInt32(txt_ID.Text).Equals(liste[i].IdArticle))
                {

                    string NomArticle = txt_NomArticle.Text;
                    int QuantInventaire = int.Parse(txt_QuantiteInventaire.Text);
                    double PrixDetail = double.Parse(txt_PrixDetail.Text);
                    double PrixVente = double.Parse(txt_PrixVendu.Text);

                    smc.ArticleUpdate(liste[i].IdArticle, NomArticle, QuantInventaire, PrixDetail, PrixVente);

                }
            }

            charger();
        }


        // Mettre les articles dans la table View
        private void dgv_Articles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Articles.CurrentRow.Cells[0].Value.ToString();
            //txt_NoSerie.Text = dgv_Articles.CurrentRow.Cells[1].Value.ToString();
            txt_NomArticle.Text = dgv_Articles.CurrentRow.Cells[2].Value.ToString();
            txt_QuantiteInventaire.Text = dgv_Articles.CurrentRow.Cells[3].Value.ToString();
            txt_PrixDetail.Text = dgv_Articles.CurrentRow.Cells[4].Value.ToString();
            txt_PrixVendu.Text = dgv_Articles.CurrentRow.Cells[5].Value.ToString();
        }


        //Supprimer les articles
        private void button5_Click(object sender, EventArgs e)
        {
            List<Articles> liste = smc.ArticleGetAll();

            if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Réponse", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (Convert.ToInt32(txt_ID.Text).Equals(liste[i].IdArticle))
                    {
                        smc.ArticlesDelete(liste[i].IdArticle);

                    }
                }

                charger();
            }
        }


        //Quitter l'application
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }




    }
}
