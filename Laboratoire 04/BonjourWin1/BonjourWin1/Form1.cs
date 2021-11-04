// Projet BonjourWin1
// Programme C#
// Ecrit par Joel Kamo
// Ecrit le 03 Novembre 2021

/* Ce programme affiche le texte "Bonjour le monde!" et des boutons permettant d'en modifier la taille, de 
 l'effacer et de le faire reapparaitre
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonjourWin1
{
    public partial class frmPrincipale : Form
    {


        public frmPrincipale()
        {
            InitializeComponent();
            // faire disparaitre l'etiquette a l'ouverture de la fenetre
            lblAffichage.Visible = false;
            // variable nombre_label qui recupere le contenu
            //int nombre_label = int.Parse(lblAffichage.Text);
        }

        private void cmdAfficher_Click(object sender, EventArgs e)
        {
            // faire apparaitre l'etiquette a l'ouverture de la fenetre
            lblAffichage.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontFamily Tahoma = new FontFamily("Tahoma");
            lblAffichage.Font = new Font(Tahoma, 11, FontStyle.Regular);
            lblAffichage.Visible = true;
        }

        private void cmdGrandCractere_Click(object sender, EventArgs e)
        {
            FontFamily TNR = new FontFamily("Times New Roman");
            lblAffichage.Font = new Font(TNR, 20, FontStyle.Bold);
            lblAffichage.Visible = true;
            //lblAffichage.TextAlign = HorizontalAlignment.Center;

        }

        private void cmdEffacer_Click(object sender, EventArgs e)
        {
            lblAffichage.Visible = false;
        }

        private void lblAffichage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
