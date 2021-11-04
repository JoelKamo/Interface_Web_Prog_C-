using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices1
{
    public partial class cmdTexte1 : Form
    {
        public cmdTexte1()
        {
            InitializeComponent();
            lblAffichage.Visible = false;
        }

        private void cmdTNRG14_Click(object sender, EventArgs e)
        {
            FontFamily TNR = new FontFamily("Times New Roman");
            lblAffichage.Font = new Font(TNR, 14, FontStyle.Bold);
            lblAffichage.Visible = true;
        }

        private void cmdArialG14_Click(object sender, EventArgs e)
        {
            FontFamily ARL = new FontFamily("Arial");
            lblAffichage.Font = new Font(ARL, 14, FontStyle.Bold);
            lblAffichage.Visible = true;

        }

        private void cmdScriptG18_Click(object sender, EventArgs e)
        {
            FontFamily SPT = new FontFamily("Script MT Bold");
            lblAffichage.Font = new Font(SPT, 18, FontStyle.Bold);
            lblAffichage.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontFamily TNR = new FontFamily("Times New Roman");
            lblAffichage.Font = new Font(TNR, 24, FontStyle.Bold);
            lblAffichage.Visible = true;
        }

        private void cmdArialG24_Click(object sender, EventArgs e)
        {
            FontFamily ARL = new FontFamily("Arial");
            lblAffichage.Font = new Font(ARL, 24, FontStyle.Bold);
            lblAffichage.Visible = true;
        }

        private void cmdScriptG36_Click(object sender, EventArgs e)
        {
            FontFamily SPT = new FontFamily("Script MT Bold");
            lblAffichage.Font = new Font(SPT, 36, FontStyle.Bold);
            lblAffichage.Visible = true;
        }

        private void lblAffichage_Click(object sender, EventArgs e)
        {
            lblAffichage.Visible = false;
        }
    }
}
