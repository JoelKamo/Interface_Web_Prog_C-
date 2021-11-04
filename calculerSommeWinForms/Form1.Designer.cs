namespace labo_00
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.additionner = new System.Windows.Forms.Button();
            this.lbl_somme = new System.Windows.Forms.Label();
            this.tb_nbr1 = new System.Windows.Forms.TextBox();
            this.tb_nbr2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez le nombre 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrez le nombre 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "La somme est:";
            // 
            // additionner
            // 
            this.additionner.Location = new System.Drawing.Point(131, 156);
            this.additionner.Name = "additionner";
            this.additionner.Size = new System.Drawing.Size(75, 23);
            this.additionner.TabIndex = 3;
            this.additionner.Text = "Additionner";
            this.additionner.UseVisualStyleBackColor = true;
            this.additionner.Click += new System.EventHandler(this.additionner_Click);
            // 
            // lbl_somme
            // 
            this.lbl_somme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_somme.Location = new System.Drawing.Point(243, 195);
            this.lbl_somme.Name = "lbl_somme";
            this.lbl_somme.Size = new System.Drawing.Size(74, 20);
            this.lbl_somme.TabIndex = 4;
            // 
            // tb_nbr1
            // 
            this.tb_nbr1.Location = new System.Drawing.Point(243, 77);
            this.tb_nbr1.Name = "tb_nbr1";
            this.tb_nbr1.Size = new System.Drawing.Size(74, 20);
            this.tb_nbr1.TabIndex = 5;
            // 
            // tb_nbr2
            // 
            this.tb_nbr2.Location = new System.Drawing.Point(243, 115);
            this.tb_nbr2.Name = "tb_nbr2";
            this.tb_nbr2.Size = new System.Drawing.Size(74, 20);
            this.tb_nbr2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 276);
            this.Controls.Add(this.tb_nbr2);
            this.Controls.Add(this.tb_nbr1);
            this.Controls.Add(this.lbl_somme);
            this.Controls.Add(this.additionner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button additionner;
        private System.Windows.Forms.Label lbl_somme;
        private System.Windows.Forms.TextBox tb_nbr1;
        private System.Windows.Forms.TextBox tb_nbr2;
    }
}

