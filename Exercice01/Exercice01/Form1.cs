using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice01
{
    public partial class cmdTexte1 : Form
    {
        public cmdTexte1()
        {
            InitializeComponent();
            lblAffichage.Visible = false;
        }

        private void cmdTexte1_Load(object sender, EventArgs e)
        {
            FontFamily TNR = new FontFamily("Times New Roman");
            lblAffichage.Font = new Font(TNR, 14, FontStyle.Bold);
            lblAffichage.Visible = true;
            
        }

        private void cmdTNRG14_Click(object sender, EventArgs e)
        {

        }

        private void cmdArialG14_Click(object sender, EventArgs e)
        {

        }

        private void cmdTexte1_Load_1(object sender, EventArgs e)
        {

        }

        private void cmdTNRG14_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdArialG14_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdTNRG14_Click_2(object sender, EventArgs e)
        {

        }
    }
}
