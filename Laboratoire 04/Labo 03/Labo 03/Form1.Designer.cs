namespace Labo_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQBleu = new System.Windows.Forms.TextBox();
            this.tbQRose = new System.Windows.Forms.TextBox();
            this.tbPrixBleu = new System.Windows.Forms.TextBox();
            this.tbPrixRose = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotBleu = new System.Windows.Forms.Label();
            this.lblTotRose = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotAvantTx = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTps = new System.Windows.Forms.Label();
            this.lblTvq = new System.Windows.Forms.Label();
            this.lblTauxTps = new System.Windows.Forms.Label();
            this.lblTauxTvq = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotCommande = new System.Windows.Forms.Label();
            this.picIPad = new System.Windows.Forms.PictureBox();
            this.btnNouvCommande = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnVisible = new System.Windows.Forms.Button();
            this.btnInvisible = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIPad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscrire votre prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inscrire votre nom :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(180, 23);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(288, 26);
            this.tbPrenom.TabIndex = 5;
            this.tbPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPrenom.TextChanged += new System.EventHandler(this.tbPrenom_TextChanged);
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(180, 59);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(288, 26);
            this.tbNom.TabIndex = 8;
            this.tbNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculer.Location = new System.Drawing.Point(29, 393);
            this.btnCalculer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(198, 37);
            this.btnCalculer.TabIndex = 6;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantité ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix unitaire";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bleu :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rose :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbQBleu
            // 
            this.tbQBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQBleu.Location = new System.Drawing.Point(170, 125);
            this.tbQBleu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQBleu.Name = "tbQBleu";
            this.tbQBleu.Size = new System.Drawing.Size(78, 26);
            this.tbQBleu.TabIndex = 3;
            this.tbQBleu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbQRose
            // 
            this.tbQRose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQRose.Location = new System.Drawing.Point(170, 155);
            this.tbQRose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQRose.Name = "tbQRose";
            this.tbQRose.Size = new System.Drawing.Size(78, 26);
            this.tbQRose.TabIndex = 4;
            this.tbQRose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPrixBleu
            // 
            this.tbPrixBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrixBleu.Location = new System.Drawing.Point(251, 125);
            this.tbPrixBleu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrixBleu.Name = "tbPrixBleu";
            this.tbPrixBleu.Size = new System.Drawing.Size(78, 26);
            this.tbPrixBleu.TabIndex = 1;
            this.tbPrixBleu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPrixRose
            // 
            this.tbPrixRose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrixRose.Location = new System.Drawing.Point(251, 155);
            this.tbPrixRose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrixRose.Name = "tbPrixRose";
            this.tbPrixRose.Size = new System.Drawing.Size(78, 26);
            this.tbPrixRose.TabIndex = 7;
            this.tbPrixRose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(103, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQTotal
            // 
            this.lblQTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQTotal.Location = new System.Drawing.Point(170, 188);
            this.lblQTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQTotal.Name = "lblQTotal";
            this.lblQTotal.Size = new System.Drawing.Size(78, 24);
            this.lblQTotal.TabIndex = 14;
            this.lblQTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sous-totaux";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotBleu
            // 
            this.lblTotBleu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotBleu.Location = new System.Drawing.Point(346, 125);
            this.lblTotBleu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotBleu.Name = "lblTotBleu";
            this.lblTotBleu.Size = new System.Drawing.Size(120, 24);
            this.lblTotBleu.TabIndex = 16;
            this.lblTotBleu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotRose
            // 
            this.lblTotRose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotRose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotRose.Location = new System.Drawing.Point(346, 155);
            this.lblTotRose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotRose.Name = "lblTotRose";
            this.lblTotRose.Size = new System.Drawing.Size(120, 24);
            this.lblTotRose.TabIndex = 17;
            this.lblTotRose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(206, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total avant taxes :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotAvantTx
            // 
            this.lblTotAvantTx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotAvantTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotAvantTx.Location = new System.Drawing.Point(347, 224);
            this.lblTotAvantTx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotAvantTx.Name = "lblTotAvantTx";
            this.lblTotAvantTx.Size = new System.Drawing.Size(120, 24);
            this.lblTotAvantTx.TabIndex = 20;
            this.lblTotAvantTx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(285, 263);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "TPS :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(285, 295);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "TVQ :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(472, 263);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Taux TPS :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(472, 293);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Taux TVQ :";
            // 
            // lblTps
            // 
            this.lblTps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTps.Location = new System.Drawing.Point(347, 263);
            this.lblTps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTps.Name = "lblTps";
            this.lblTps.Size = new System.Drawing.Size(120, 24);
            this.lblTps.TabIndex = 25;
            this.lblTps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTvq
            // 
            this.lblTvq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTvq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTvq.Location = new System.Drawing.Point(347, 295);
            this.lblTvq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTvq.Name = "lblTvq";
            this.lblTvq.Size = new System.Drawing.Size(120, 24);
            this.lblTvq.TabIndex = 10;
            this.lblTvq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTauxTps
            // 
            this.lblTauxTps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTauxTps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTauxTps.Location = new System.Drawing.Point(554, 262);
            this.lblTauxTps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTauxTps.Name = "lblTauxTps";
            this.lblTauxTps.Size = new System.Drawing.Size(61, 20);
            this.lblTauxTps.TabIndex = 27;
            this.lblTauxTps.Text = "0,05";
            // 
            // lblTauxTvq
            // 
            this.lblTauxTvq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTauxTvq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTauxTvq.Location = new System.Drawing.Point(554, 292);
            this.lblTauxTvq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTauxTvq.Name = "lblTauxTvq";
            this.lblTauxTvq.Size = new System.Drawing.Size(61, 20);
            this.lblTauxTvq.TabIndex = 28;
            this.lblTauxTvq.Text = "0,09975";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(173, 344);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Total de la commande :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotCommande
            // 
            this.lblTotCommande.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCommande.Location = new System.Drawing.Point(347, 344);
            this.lblTotCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotCommande.Name = "lblTotCommande";
            this.lblTotCommande.Size = new System.Drawing.Size(120, 24);
            this.lblTotCommande.TabIndex = 0;
            this.lblTotCommande.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picIPad
            // 
            this.picIPad.Image = ((System.Drawing.Image)(resources.GetObject("picIPad.Image")));
            this.picIPad.Location = new System.Drawing.Point(546, 23);
            this.picIPad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picIPad.Name = "picIPad";
            this.picIPad.Size = new System.Drawing.Size(174, 191);
            this.picIPad.TabIndex = 32;
            this.picIPad.TabStop = false;
            // 
            // btnNouvCommande
            // 
            this.btnNouvCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvCommande.Location = new System.Drawing.Point(292, 393);
            this.btnNouvCommande.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouvCommande.Name = "btnNouvCommande";
            this.btnNouvCommande.Size = new System.Drawing.Size(198, 37);
            this.btnNouvCommande.TabIndex = 9;
            this.btnNouvCommande.Text = "Nouvelle commande";
            this.btnNouvCommande.UseVisualStyleBackColor = true;
            this.btnNouvCommande.Click += new System.EventHandler(this.btnNouvCommande_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(541, 393);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(198, 37);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(624, 290);
            this.btnVisible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(146, 25);
            this.btnVisible.TabIndex = 35;
            this.btnVisible.Text = "Rendre les taux visibles";
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // btnInvisible
            // 
            this.btnInvisible.Location = new System.Drawing.Point(624, 260);
            this.btnInvisible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInvisible.Name = "btnInvisible";
            this.btnInvisible.Size = new System.Drawing.Size(146, 25);
            this.btnInvisible.TabIndex = 36;
            this.btnInvisible.Text = "Rendre les taux invisibles";
            this.btnInvisible.UseVisualStyleBackColor = true;
            this.btnInvisible.Click += new System.EventHandler(this.btnInvisible_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 448);
            this.Controls.Add(this.btnInvisible);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnNouvCommande);
            this.Controls.Add(this.picIPad);
            this.Controls.Add(this.lblTotCommande);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblTauxTvq);
            this.Controls.Add(this.lblTauxTps);
            this.Controls.Add(this.lblTvq);
            this.Controls.Add(this.lblTps);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotAvantTx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotRose);
            this.Controls.Add(this.lblTotBleu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblQTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrixRose);
            this.Controls.Add(this.tbPrixBleu);
            this.Controls.Add(this.tbQRose);
            this.Controls.Add(this.tbQBleu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Bon de commande IPad, réalisé par VotreNom";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIPad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQBleu;
        private System.Windows.Forms.TextBox tbQRose;
        private System.Windows.Forms.TextBox tbPrixBleu;
        private System.Windows.Forms.TextBox tbPrixRose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblQTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotBleu;
        private System.Windows.Forms.Label lblTotRose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotAvantTx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTps;
        private System.Windows.Forms.Label lblTvq;
        private System.Windows.Forms.Label lblTauxTps;
        private System.Windows.Forms.Label lblTauxTvq;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotCommande;
        private System.Windows.Forms.PictureBox picIPad;
        private System.Windows.Forms.Button btnNouvCommande;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnVisible;
        private System.Windows.Forms.Button btnInvisible;
    }
}

