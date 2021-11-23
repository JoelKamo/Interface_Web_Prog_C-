
namespace GestionFactureClient
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_PrixArticle = new System.Windows.Forms.TextBox();
            this.cb_Clients = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dgv_FactureClients = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PrixTotalArticle = new System.Windows.Forms.TextBox();
            this.lb_cmp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_TypeClients = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FactureClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 127);
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
            // txt_PrixArticle
            // 
            this.txt_PrixArticle.Location = new System.Drawing.Point(122, 122);
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
            this.button2.Location = new System.Drawing.Point(438, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // dgv_FactureClients
            // 
            this.dgv_FactureClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FactureClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FactureClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client,
            this.Articles,
            this.PrixArticle});
            this.dgv_FactureClients.Location = new System.Drawing.Point(22, 189);
            this.dgv_FactureClients.Name = "dgv_FactureClients";
            this.dgv_FactureClients.RowTemplate.Height = 25;
            this.dgv_FactureClients.Size = new System.Drawing.Size(491, 204);
            this.dgv_FactureClients.TabIndex = 24;
            this.dgv_FactureClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clients_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Client
            // 
            this.Client.HeaderText = "Clients";
            this.Client.Name = "Client";
            // 
            // Articles
            // 
            this.Articles.HeaderText = "Articles";
            this.Articles.Name = "Articles";
            // 
            // PrixArticle
            // 
            this.PrixArticle.HeaderText = "PrixArticle";
            this.PrixArticle.Name = "PrixArticle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Prix Total Article :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_PrixTotalArticle
            // 
            this.txt_PrixTotalArticle.Location = new System.Drawing.Point(264, 412);
            this.txt_PrixTotalArticle.Name = "txt_PrixTotalArticle";
            this.txt_PrixTotalArticle.Size = new System.Drawing.Size(249, 23);
            this.txt_PrixTotalArticle.TabIndex = 26;
            this.txt_PrixTotalArticle.TextChanged += new System.EventHandler(this.txt_TotalArticle_TextChanged);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Articles :";
            // 
            // cb_TypeClients
            // 
            this.cb_TypeClients.FormattingEnabled = true;
            this.cb_TypeClients.Location = new System.Drawing.Point(122, 46);
            this.cb_TypeClients.Name = "cb_TypeClients";
            this.cb_TypeClients.Size = new System.Drawing.Size(249, 23);
            this.cb_TypeClients.TabIndex = 29;
            this.cb_TypeClients.SelectedIndexChanged += new System.EventHandler(this.cb_TypeClients_SelectedIndexChanged);
            // 
            // Gestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 496);
            this.Controls.Add(this.cb_TypeClients);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_cmp);
            this.Controls.Add(this.txt_PrixTotalArticle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_FactureClients);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Clients);
            this.Controls.Add(this.txt_PrixArticle);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Gestions";
            this.Text = "Gestion Factures Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FactureClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_PrixArticle;
        private System.Windows.Forms.ComboBox cb_Clients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dgv_FactureClients;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PrixTotalArticle;
        private System.Windows.Forms.Label lb_cmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_TypeClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articles;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixArticle;
    }
}

