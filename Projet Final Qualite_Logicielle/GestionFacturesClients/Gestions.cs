using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFacturesClients
{
    public partial class Gestions : Form
    {
        public Gestions()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // pour ajouter ou charger les types de clients dans la liste deroulante <TypeClients>

            cb_TypeClients.Items.Add("VIP");
            cb_TypeClients.Items.Add("Senior");
            cb_TypeClients.Items.Add("Normal");
            cb_TypeClients.Items.Add("Saisonnier");

            
            // pour ajouter ou charger les clients dans la liste deroulante <Clients>, nous avons besoin d'une boucle for pour pacourir tout 
            // le Program principale, c'est une collection et la classe est static

            for(int i = 0 ; i < Program.Clients.Count; i++)
            {
                cb_Clients.Items.Add(Program.Clients[i].Libelle);
            }
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cb_Clients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_TotalArticle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_PrixArticle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_QuantiteArticle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_NomArticle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NoFacture_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pour ajouter une collection de cliens je dois avoir un objet clients, on fait appel au constructeur ici 

            Facture F = new Facture();
            F.NoFacture = txt_NoFacture.Text;
            F.TypeClients = cb_TypeClients.Text;
            F.NomArticle = txt_NomArticle.Text;
            F.QuantiteArticle = int.Parse(txt_QuantiteArticle.Text);
            F.PrixArticle = double.Parse(txt_PrixArticle.Text);
            F.TotalArticle = F.QuantiteArticle * F.PrixArticle ;

            for(int i = 0; i < Program.Clients.Count; i++)
            {
                if (cb_Clients.Text.Equals(Program.Clients[i].Libelle))
                {
                    F.C = Program.Clients[i];
                    break;
                }
            }
            Program.Facture.Add(F);


        }
    }
}
