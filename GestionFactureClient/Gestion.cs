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

        private void button1_Click(object sender, EventArgs e)
        {
            Articles a = new Articles();
            a.NoSerie = txt_NoSerie.Text;
            a.NomArticle = txt_NomArticle.Text;
            a.QuantiteInventaire = int.Parse(txt_QuantiteInventaire.Text);
            a.PrixDetail = double.Parse(txt_PrixDetail.Text);
            a.PrixVendu = double.Parse(txt_PrixVendu.Text);

            Program.Articles.Add(a);

            dgv_Articles.Rows.Clear();

            for (int i = 0; i < Program.Articles.Count; i++)
            {
                dgv_Articles.Rows.Add(Program.Articles[i].ID, Program.Articles[i].NoSerie,
                Program.Articles[i].NomArticle, Program.Articles[i].QuantiteInventaire,
                Program.Articles[i].PrixDetail, Program.Articles[i].PrixVendu);
            }







        }

       
    }
}
