
namespace GestionFacturesClients
{
    partial class Gestions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_NoFacture = new System.Windows.Forms.TextBox();
            this.txt_NomArticle = new System.Windows.Forms.TextBox();
            this.txt_PrixArticle = new System.Windows.Forms.TextBox();
            this.cb_Clients = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Recherche = new System.Windows.Forms.TextBox();
            this.dgv_Clients = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TotalArticle = new System.Windows.Forms.TextBox();
            this.lb_cmp = new System.Windows.Forms.Label();
            this.txt_QuantiteArticle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_TypeClients = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NoFacture : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "NomArticle :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "QuantiteArticle :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "PrixArticle :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clients :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(122, 79);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(249, 23);
            this.txt_id.TabIndex = 6;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_NoFacture
            // 
            this.txt_NoFacture.Location = new System.Drawing.Point(122, 108);
            this.txt_NoFacture.Name = "txt_NoFacture";
            this.txt_NoFacture.Size = new System.Drawing.Size(249, 23);
            this.txt_NoFacture.TabIndex = 7;
            this.txt_NoFacture.TextChanged += new System.EventHandler(this.txt_NoFacture_TextChanged);
            // 
            // txt_NomArticle
            // 
            this.txt_NomArticle.Location = new System.Drawing.Point(122, 137);
            this.txt_NomArticle.Name = "txt_NomArticle";
            this.txt_NomArticle.Size = new System.Drawing.Size(249, 23);
            this.txt_NomArticle.TabIndex = 8;
            this.txt_NomArticle.TextChanged += new System.EventHandler(this.txt_NomArticle_TextChanged);
            // 
            // txt_PrixArticle
            // 
            this.txt_PrixArticle.Location = new System.Drawing.Point(122, 195);
            this.txt_PrixArticle.Name = "txt_PrixArticle";
            this.txt_PrixArticle.Size = new System.Drawing.Size(249, 23);
            this.txt_PrixArticle.TabIndex = 10;
            this.txt_PrixArticle.TextChanged += new System.EventHandler(this.txt_PrixArticle_TextChanged);
            // 
            // cb_Clients
            // 
            this.cb_Clients.FormattingEnabled = true;
            this.cb_Clients.Location = new System.Drawing.Point(122, 14);
            this.cb_Clients.Name = "cb_Clients";
            this.cb_Clients.Size = new System.Drawing.Size(249, 23);
            this.cb_Clients.TabIndex = 12;
            this.cb_Clients.SelectedIndexChanged += new System.EventHandler(this.cb_Clients_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(395, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Rechercher";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 461);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Previous ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(122, 461);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "<";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(345, 461);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = ">";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(438, 461);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "Next";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Recherche par Numero Facture : ";
            // 
            // txt_Recherche
            // 
            this.txt_Recherche.Location = new System.Drawing.Point(232, 265);
            this.txt_Recherche.Name = "txt_Recherche";
            this.txt_Recherche.Size = new System.Drawing.Size(139, 23);
            this.txt_Recherche.TabIndex = 23;
            // 
            // dgv_Clients
            // 
            this.dgv_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clients.Location = new System.Drawing.Point(22, 304);
            this.dgv_Clients.Name = "dgv_Clients";
            this.dgv_Clients.RowTemplate.Height = 25;
            this.dgv_Clients.Size = new System.Drawing.Size(491, 141);
            this.dgv_Clients.TabIndex = 24;
            this.dgv_Clients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clients_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "TotalArticle :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_TotalArticle
            // 
            this.txt_TotalArticle.Location = new System.Drawing.Point(122, 228);
            this.txt_TotalArticle.Name = "txt_TotalArticle";
            this.txt_TotalArticle.Size = new System.Drawing.Size(249, 23);
            this.txt_TotalArticle.TabIndex = 26;
            this.txt_TotalArticle.TextChanged += new System.EventHandler(this.txt_TotalArticle_TextChanged);
            // 
            // lb_cmp
            // 
            this.lb_cmp.AutoSize = true;
            this.lb_cmp.Location = new System.Drawing.Point(258, 465);
            this.lb_cmp.Name = "lb_cmp";
            this.lb_cmp.Size = new System.Drawing.Size(24, 15);
            this.lb_cmp.TabIndex = 27;
            this.lb_cmp.Text = "../..";
            // 
            // txt_QuantiteArticle
            // 
            this.txt_QuantiteArticle.Location = new System.Drawing.Point(122, 166);
            this.txt_QuantiteArticle.Name = "txt_QuantiteArticle";
            this.txt_QuantiteArticle.Size = new System.Drawing.Size(249, 23);
            this.txt_QuantiteArticle.TabIndex = 9;
            this.txt_QuantiteArticle.TextChanged += new System.EventHandler(this.txt_QuantiteArticle_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "TypeClients :";
            // 
            // cb_TypeClients
            // 
            this.cb_TypeClients.FormattingEnabled = true;
            this.cb_TypeClients.Location = new System.Drawing.Point(122, 46);
            this.cb_TypeClients.Name = "cb_TypeClients";
            this.cb_TypeClients.Size = new System.Drawing.Size(249, 23);
            this.cb_TypeClients.TabIndex = 29;
            // 
            // Gestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 496);
            this.Controls.Add(this.cb_TypeClients);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_cmp);
            this.Controls.Add(this.txt_TotalArticle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_Clients);
            this.Controls.Add(this.txt_Recherche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Clients);
            this.Controls.Add(this.txt_PrixArticle);
            this.Controls.Add(this.txt_QuantiteArticle);
            this.Controls.Add(this.txt_NomArticle);
            this.Controls.Add(this.txt_NoFacture);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gestions";
            this.Text = "Gestion Factures Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_NoFacture;
        private System.Windows.Forms.TextBox txt_NomArticle;
        private System.Windows.Forms.TextBox txt_PrixArticle;
        private System.Windows.Forms.ComboBox cb_Clients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Recherche;
        private System.Windows.Forms.DataGridView dgv_Clients;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TotalArticle;
        private System.Windows.Forms.Label lb_cmp;
        private System.Windows.Forms.TextBox txt_QuantiteArticle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_TypeClients;
    }
}

