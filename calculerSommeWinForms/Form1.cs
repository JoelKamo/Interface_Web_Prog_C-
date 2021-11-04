using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labo_00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void additionner_Click(object sender, EventArgs e)
        {
            int nbr1;
            int nbr2;
            int somme;

            nbr1 = int.Parse(tb_nbr1.Text);
            nbr2 = int.Parse(tb_nbr2.Text);

            somme = nbr1 + nbr2;

            lbl_somme.Text = somme.ToString();
        }
    }
}
