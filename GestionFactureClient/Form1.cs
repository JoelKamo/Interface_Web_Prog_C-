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

        Gestion gest = new Gestion();
        Contact cont = new Contact();
        Gestions GestionFacture = new Gestions();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gest.Show();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cont.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionFacture.Show();
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
