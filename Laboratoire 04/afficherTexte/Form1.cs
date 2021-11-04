using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace afficherTexte
{
    public partial class cmdafficherTexte : Form
    {
        public cmdafficherTexte()
        {
            InitializeComponent();
        }

        private void cmdafficheNomPrenomButton_Click(object sender, EventArgs e)
        {
            string nom;
            string prenom;

            nom = nomTextBox.Text;
            prenom = prenomTextBox.Text;

            nomPrenomLabel.Text = "Cette personne se nomme " + nom + " " + prenom;

        }

        private void cmdcalculAgeButton_Click(object sender, EventArgs e)
        {
            int age;

            //L’année de référence sera 2021 que nous ajouterons en constante. Ajoutez à votre codel’instruction suivante :
            const int anReference = 2021;
            // il faut lire le TextBox contenant l’année de naissance, convertir ce texte en nombre
            //entier à l’aide de la méthode int.Parse() et déposer le tout dans la variable « age », ajoutez à
            //votre code l’ instruction suivante :
            age = anReference - int.Parse(anneeTextBox.Text);

            /*Ensuite pour afficher le résultat(l’âge) en format texte, ajoutez à votre code l’instruction
              suivante :*/
            ageLabel.Text = "Cette personne a " + Environment.NewLine + age.ToString() + "an(s)";

            /*La méthode « .ToString() » permet de convertir un nombre en texte(string), cette méthode est
              facultative ici car le compilateur reconnaîtra la chaîne de caractère et convertira implicitement le
              int en string*/

        }

        private void cmdafficheBoiteMsgButton_Click(object sender, EventArgs e)
        {
            const int anReference = 2021;
            int age = anReference - int.Parse(anneeTextBox.Text);
            MessageBox.Show("Allo");

            MessageBox.Show(nomTextBox.Text + " " + prenomTextBox.Text + " " +"fete son " + age + "e anniversaire. " +
                " Cette personne est nee en" +" " + int.Parse(anneeTextBox.Text));

      
        }
    }
}
