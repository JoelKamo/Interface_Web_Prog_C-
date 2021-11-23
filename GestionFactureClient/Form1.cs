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
    public partial class Form1 : Form
    {

        // Declarartion des variables de type interfaces, pour que le clic sur nos trois onglets fonctionnent
        Gestion Gestion = new Gestion();
        Contact Contact = new Contact();
        GestionsFacture Factures = new GestionsFacture();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestion.Show();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Contact.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Factures.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
