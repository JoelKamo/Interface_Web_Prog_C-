using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionFactureClient
{
    public partial class Contact : Form
    {

        systemeController smc = new systemeController();
        public Contact()
        {
            InitializeComponent();
        }

        // Ajouter Client
        private void button1_Click(object sender, EventArgs e)
        {


            string Nom = txt_Nom.Text;
            string Prenom = txt_Prenom.Text;
            string Adresse = txt_Adresse.Text;
            string Ville = txt_Ville.Text;
            Client c = smc.ClientCreate(Nom, Prenom, Adresse, Ville);

            charger();

        }


        // Fonction Charger 
        public void charger()
        {
            List<Client> liste = smc.ClientGetAll();
            dgv_Client.Rows.Clear();
            for (int i = 0; i < liste.Count; i++)
            {
                dgv_Client.Rows.Add(liste[i].IdClient, 0,
                liste[i].Nom, liste[i].Prenom, liste[i].Adresse,
                liste[i].Ville);
            }
        }



        private void Contact_Load(object sender, EventArgs e)
        {

        }

        //Quitter l'application
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Supprimer les articles
        private void button5_Click_1(object sender, EventArgs e)
        {
            List<Client> liste = smc.ClientGetAll();

            if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Réponse", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (Convert.ToInt32(txt_IDClient.Text).Equals(liste[i].IdClient))
                    {
                        smc.ClientDelete(liste[i].IdClient);

                    }
                }

                charger();
            }
        }


        // Modifier Contact Client
        private void button2_Click_1(object sender, EventArgs e)
        {
            List<Client> liste = smc.ClientGetAll();

            for (int i = 0; i < liste.Count; i++)
            {
                if (Convert.ToInt32(txt_IDClient.Text).Equals(liste[i].IdClient))
                {

                    string Nom = txt_Nom.Text;
                    string Prenom = txt_Prenom.Text;
                    string Adresse = txt_Adresse.Text;
                    string Ville = txt_Ville.Text;

                    smc.ClientUpdate(liste[i].IdClient, Nom, Prenom, Adresse, Ville);
                }
            }

            charger();

        }

        // Mettre les donnes des clients dans la table View
        private void dgv_Client_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDClient.Text = dgv_Client.CurrentRow.Cells[0].Value.ToString();
            //txt_NoClient.Text = dgv_Client.CurrentRow.Cells[1].Value.ToString();
            txt_Nom.Text = dgv_Client.CurrentRow.Cells[2].Value.ToString();
            txt_Prenom.Text = dgv_Client.CurrentRow.Cells[3].Value.ToString();
            txt_Adresse.Text = dgv_Client.CurrentRow.Cells[4].Value.ToString();
            txt_Ville.Text = dgv_Client.CurrentRow.Cells[5].Value.ToString();

        }




    }
}



