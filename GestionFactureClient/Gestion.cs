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
        public Gestion()
        {
            InitializeComponent();
        }


        // Ajouter Articles
        private void button1_Click(object sender, EventArgs e)
        {
            Articles a = new Articles();
            a.NoSerie = txt_NoSerie.Text;
            a.NomArticle = txt_NomArticle.Text;
            a.QuantiteInventaire = int.Parse(txt_QuantiteInventaire.Text);
            a.PrixDetail = double.Parse(txt_PrixDetail.Text);
            a.PrixVendu = double.Parse(txt_PrixVendu.Text);

            Program.Articles.Add(a);

            charger();

        }


        // Fonction Charger 
        public void charger()
        {
            dgv_Articles.Rows.Clear();
            for (int i = 0; i < Program.Articles.Count; i++)
            {
                dgv_Articles.Rows.Add(Program.Articles[i].ID, Program.Articles[i].NoSerie,
                Program.Articles[i].NomArticle, Program.Articles[i].QuantiteInventaire,
                Program.Articles[i].PrixDetail, Program.Articles[i].PrixVendu);
            }
        }


        // Modifier Articles
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.Articles.Count; i++)
            {
                if(txt_ID.Text.Equals(Program.Articles[i].ID.ToString()))
                {
                    Program.Articles[i].NoSerie = txt_NoSerie.Text;
                    Program.Articles[i].NomArticle = txt_NomArticle.Text;
                    Program.Articles[i].QuantiteInventaire = int.Parse(txt_QuantiteInventaire.Text);
                    Program.Articles[i].PrixDetail = double.Parse(txt_PrixDetail.Text);
                    Program.Articles[i].PrixVendu = double.Parse(txt_PrixVendu.Text);
                   
                }  
            }

            charger();
        }


        // Mettre les articles dans la table View
        private void dgv_Articles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dgv_Articles.CurrentRow.Cells[0].Value.ToString();
            txt_NoSerie.Text = dgv_Articles.CurrentRow.Cells[1].Value.ToString();
            txt_NomArticle.Text = dgv_Articles.CurrentRow.Cells[2].Value.ToString();
            txt_QuantiteInventaire.Text = dgv_Articles.CurrentRow.Cells[3].Value.ToString();
            txt_PrixDetail.Text = dgv_Articles.CurrentRow.Cells[4].Value.ToString();
            txt_PrixVendu.Text = dgv_Articles.CurrentRow.Cells[5].Value.ToString();
        }


        //Supprimer les articles
        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment supprimer ?", "Réponse",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                for (int i = 0; i < Program.Articles.Count; i++)
                {
                    if (txt_ID.Text.Equals(Program.Articles[i].ID.ToString()))
                    {
                        Program.Articles.RemoveAt(i);

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
