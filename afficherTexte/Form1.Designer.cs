
namespace afficherTexte
{
    partial class cmdafficherTexte
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAnneeDeNaissance = new System.Windows.Forms.Label();
            this.cmdafficheNomPrenomButton = new System.Windows.Forms.Button();
            this.cmdcalculAgeButton = new System.Windows.Forms.Button();
            this.cmdafficheBoiteMsgButton = new System.Windows.Forms.Button();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.anneeTextBox = new System.Windows.Forms.TextBox();
            this.nomPrenomLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNom.Location = new System.Drawing.Point(33, 71);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(64, 22);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrenom.Location = new System.Drawing.Point(33, 128);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(89, 22);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // lblAnneeDeNaissance
            // 
            this.lblAnneeDeNaissance.AutoSize = true;
            this.lblAnneeDeNaissance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnneeDeNaissance.Location = new System.Drawing.Point(33, 192);
            this.lblAnneeDeNaissance.Name = "lblAnneeDeNaissance";
            this.lblAnneeDeNaissance.Size = new System.Drawing.Size(179, 22);
            this.lblAnneeDeNaissance.TabIndex = 2;
            this.lblAnneeDeNaissance.Text = "Année de naissance :";
            // 
            // cmdafficheNomPrenomButton
            // 
            this.cmdafficheNomPrenomButton.BackColor = System.Drawing.Color.LightGray;
            this.cmdafficheNomPrenomButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdafficheNomPrenomButton.Location = new System.Drawing.Point(456, 71);
            this.cmdafficheNomPrenomButton.Name = "cmdafficheNomPrenomButton";
            this.cmdafficheNomPrenomButton.Size = new System.Drawing.Size(176, 79);
            this.cmdafficheNomPrenomButton.TabIndex = 3;
            this.cmdafficheNomPrenomButton.Text = "Afficher le texte dans une étiquette";
            this.cmdafficheNomPrenomButton.UseVisualStyleBackColor = false;
            this.cmdafficheNomPrenomButton.Click += new System.EventHandler(this.cmdafficheNomPrenomButton_Click);
            // 
            // cmdcalculAgeButton
            // 
            this.cmdcalculAgeButton.BackColor = System.Drawing.Color.LightGray;
            this.cmdcalculAgeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdcalculAgeButton.Location = new System.Drawing.Point(456, 164);
            this.cmdcalculAgeButton.Name = "cmdcalculAgeButton";
            this.cmdcalculAgeButton.Size = new System.Drawing.Size(176, 79);
            this.cmdcalculAgeButton.TabIndex = 4;
            this.cmdcalculAgeButton.Text = "Calcul l\'âge et l\'affiche dans une étiquette";
            this.cmdcalculAgeButton.UseVisualStyleBackColor = false;
            this.cmdcalculAgeButton.Click += new System.EventHandler(this.cmdcalculAgeButton_Click);
            // 
            // cmdafficheBoiteMsgButton
            // 
            this.cmdafficheBoiteMsgButton.BackColor = System.Drawing.Color.LightGray;
            this.cmdafficheBoiteMsgButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdafficheBoiteMsgButton.Location = new System.Drawing.Point(345, 305);
            this.cmdafficheBoiteMsgButton.Name = "cmdafficheBoiteMsgButton";
            this.cmdafficheBoiteMsgButton.Size = new System.Drawing.Size(382, 47);
            this.cmdafficheBoiteMsgButton.TabIndex = 5;
            this.cmdafficheBoiteMsgButton.Text = "Afficher \"Allo\" dans une boîte de message";
            this.cmdafficheBoiteMsgButton.UseVisualStyleBackColor = false;
            this.cmdafficheBoiteMsgButton.Click += new System.EventHandler(this.cmdafficheBoiteMsgButton_Click);
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(224, 71);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(150, 23);
            this.nomTextBox.TabIndex = 6;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(224, 127);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(150, 23);
            this.prenomTextBox.TabIndex = 7;
            // 
            // anneeTextBox
            // 
            this.anneeTextBox.Location = new System.Drawing.Point(291, 194);
            this.anneeTextBox.Name = "anneeTextBox";
            this.anneeTextBox.Size = new System.Drawing.Size(83, 23);
            this.anneeTextBox.TabIndex = 8;
            // 
            // nomPrenomLabel
            // 
            this.nomPrenomLabel.Location = new System.Drawing.Point(738, 82);
            this.nomPrenomLabel.Name = "nomPrenomLabel";
            this.nomPrenomLabel.Size = new System.Drawing.Size(277, 68);
            this.nomPrenomLabel.TabIndex = 9;
            // 
            // ageLabel
            // 
            this.ageLabel.Location = new System.Drawing.Point(738, 175);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(277, 68);
            this.ageLabel.TabIndex = 10;
            // 
            // cmdafficherTexte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nomPrenomLabel);
            this.Controls.Add(this.anneeTextBox);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.cmdafficheBoiteMsgButton);
            this.Controls.Add(this.cmdcalculAgeButton);
            this.Controls.Add(this.cmdafficheNomPrenomButton);
            this.Controls.Add(this.lblAnneeDeNaissance);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "cmdafficherTexte";
            this.Text = "Labo 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAnneeDeNaissance;
        private System.Windows.Forms.Button cmdafficheNomPrenomButton;
        private System.Windows.Forms.Button cmdcalculAgeButton;
        private System.Windows.Forms.Button cmdafficheBoiteMsgButton;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox anneeTextBox;
        private System.Windows.Forms.Label nomPrenomLabel;
        private System.Windows.Forms.Label ageLabel;
    }
}

