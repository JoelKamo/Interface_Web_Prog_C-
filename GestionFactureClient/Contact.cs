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
        public Contact()
        {
            InitializeComponent();
        }

        // Ajouter Client
        private void button1_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.NoClient = txt_NoClient.Text;
            c.Nom = txt_Nom.Text;
            c.Prenom = txt_Prenom.Text;
            c.Adresse = txt_Adresse.Text;
            c.Ville = txt_Ville.Text;


            Program.Client.Add(c);

            charger();

        }


        // Fonction Charger 
        public void charger()
        {
            dgv_Client.Rows.Clear();
            for (int i = 0; i < Program.Client.Count; i++)
            {
                dgv_Client.Rows.Add(Program.Client[i].IDClient, Program.Client[i].NoClient,
                Program.Client[i].Nom, Program.Client[i].Prenom, Program.Client[i].Adresse,
                Program.Client[i].Ville);
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
            if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Réponse", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < Program.Client.Count; i++)
                {
                    if (txt_IDClient.Text.Equals(Program.Client[i].IDClient.ToString()))
                    {
                        Program.Client.RemoveAt(i);

                    }
                }

                charger();
            }
        }


        // Modifier Contact Client
        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.Client.Count; i++)
            {
                if (txt_IDClient.Text.Equals(Program.Client[i].IDClient.ToString()))
                {
                    Program.Client[i].NoClient = txt_NoClient.Text;
                    Program.Client[i].Nom = txt_Nom.Text;
                    Program.Client[i].Prenom = txt_Prenom.Text;
                    Program.Client[i].Adresse = txt_Adresse.Text;
                    Program.Client[i].Ville = txt_Ville.Text;

                }
            }

            charger();

        }

        // Mettre les donnes des clients dans la table View
        private void dgv_Client_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_IDClient.Text = dgv_Client.CurrentRow.Cells[0].Value.ToString();
            txt_NoClient.Text = dgv_Client.CurrentRow.Cells[1].Value.ToString();
            txt_Nom.Text = dgv_Client.CurrentRow.Cells[2].Value.ToString();
            txt_Prenom.Text = dgv_Client.CurrentRow.Cells[3].Value.ToString();
            txt_Adresse.Text = dgv_Client.CurrentRow.Cells[4].Value.ToString();
            txt_Ville.Text = dgv_Client.CurrentRow.Cells[5].Value.ToString();

        }




    }
}



