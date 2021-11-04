
namespace BonjourWin1
{
    partial class frmPrincipale
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
            this.cmdAfficher = new System.Windows.Forms.Button();
            this.cmdEffacer = new System.Windows.Forms.Button();
            this.cmdPetitCaractere = new System.Windows.Forms.Button();
            this.cmdGrandCaractere = new System.Windows.Forms.Button();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAfficher
            // 
            this.cmdAfficher.Location = new System.Drawing.Point(23, 229);
            this.cmdAfficher.Name = "cmdAfficher";
            this.cmdAfficher.Size = new System.Drawing.Size(60, 25);
            this.cmdAfficher.TabIndex = 0;
            this.cmdAfficher.Text = "Afficher";
            this.cmdAfficher.UseVisualStyleBackColor = true;
            this.cmdAfficher.Click += new System.EventHandler(this.cmdAfficher_Click);
            // 
            // cmdEffacer
            // 
            this.cmdEffacer.Location = new System.Drawing.Point(401, 229);
            this.cmdEffacer.Name = "cmdEffacer";
            this.cmdEffacer.Size = new System.Drawing.Size(60, 25);
            this.cmdEffacer.TabIndex = 1;
            this.cmdEffacer.Text = "Effacer";
            this.cmdEffacer.UseVisualStyleBackColor = true;
            this.cmdEffacer.Click += new System.EventHandler(this.cmdEffacer_Click);
            // 
            // cmdPetitCaractere
            // 
            this.cmdPetitCaractere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdPetitCaractere.Location = new System.Drawing.Point(122, 229);
            this.cmdPetitCaractere.Name = "cmdPetitCaractere";
            this.cmdPetitCaractere.Size = new System.Drawing.Size(110, 25);
            this.cmdPetitCaractere.TabIndex = 2;
            this.cmdPetitCaractere.Text = "Petits carateres";
            this.cmdPetitCaractere.UseVisualStyleBackColor = true;
            this.cmdPetitCaractere.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdGrandCaractere
            // 
            this.cmdGrandCaractere.Location = new System.Drawing.Point(265, 229);
            this.cmdGrandCaractere.Name = "cmdGrandCaractere";
            this.cmdGrandCaractere.Size = new System.Drawing.Size(110, 25);
            this.cmdGrandCaractere.TabIndex = 3;
            this.cmdGrandCaractere.Text = "Grands carateres";
            this.cmdGrandCaractere.UseVisualStyleBackColor = true;
            this.cmdGrandCaractere.Click += new System.EventHandler(this.cmdGrandCractere_Click);
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAffichage.ForeColor = System.Drawing.Color.White;
            this.lblAffichage.Location = new System.Drawing.Point(134, 68);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(158, 18);
            this.lblAffichage.TabIndex = 4;
            this.lblAffichage.Text = "Bonjour tout le monde!";
            this.lblAffichage.Click += new System.EventHandler(this.lblAffichage_Click);
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.cmdGrandCaractere);
            this.Controls.Add(this.cmdPetitCaractere);
            this.Controls.Add(this.cmdEffacer);
            this.Controls.Add(this.cmdAfficher);
            this.Name = "frmPrincipale";
            this.Text = "BonjourWin1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAfficher;
        private System.Windows.Forms.Button cmdEffacer;
        private System.Windows.Forms.Button cmdPetitCaractere;
        private System.Windows.Forms.Button cmdGrandCaractere;
        private System.Windows.Forms.Label lblAffichage;
    }
}

