namespace ex_window_control_03 {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent () {
            this.dudProduit = new System.Windows.Forms.DomainUpDown();
            this.dudQuantite = new System.Windows.Forms.DomainUpDown();
            this.lbProduit = new System.Windows.Forms.Label();
            this.lbQuantite = new System.Windows.Forms.Label();
            this.buAjouter = new System.Windows.Forms.Button();
            this.buSupprimer = new System.Windows.Forms.Button();
            this.buVider = new System.Windows.Forms.Button();
            this.buDroite = new System.Windows.Forms.Button();
            this.buToutDroite = new System.Windows.Forms.Button();
            this.buGauche = new System.Windows.Forms.Button();
            this.buToutGauche = new System.Windows.Forms.Button();
            this.lbGauche = new System.Windows.Forms.ListBox();
            this.lbDroite = new System.Windows.Forms.ListBox();
            this.cbMultiLigne = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dudProduit
            // 
            this.dudProduit.Location = new System.Drawing.Point(338, 58);
            this.dudProduit.Name = "dudProduit";
            this.dudProduit.Size = new System.Drawing.Size(120, 30);
            this.dudProduit.TabIndex = 0;
            this.dudProduit.Text = "domainUpDown1";
            this.dudProduit.SelectedItemChanged += new System.EventHandler(this.dudProduit_SelectedItemChanged);
            // 
            // dudQuantite
            // 
            this.dudQuantite.Location = new System.Drawing.Point(338, 126);
            this.dudQuantite.Name = "dudQuantite";
            this.dudQuantite.Size = new System.Drawing.Size(120, 30);
            this.dudQuantite.TabIndex = 1;
            this.dudQuantite.Text = "domainUpDown2";
            // 
            // lbProduit
            // 
            this.lbProduit.AutoSize = true;
            this.lbProduit.Location = new System.Drawing.Point(55, 70);
            this.lbProduit.Name = "lbProduit";
            this.lbProduit.Size = new System.Drawing.Size(61, 24);
            this.lbProduit.TabIndex = 2;
            this.lbProduit.Text = "Produit";
            // 
            // lbQuantite
            // 
            this.lbQuantite.AutoSize = true;
            this.lbQuantite.Location = new System.Drawing.Point(59, 138);
            this.lbQuantite.Name = "lbQuantite";
            this.lbQuantite.Size = new System.Drawing.Size(72, 24);
            this.lbQuantite.TabIndex = 3;
            this.lbQuantite.Text = "Quantité";
            // 
            // buAjouter
            // 
            this.buAjouter.Location = new System.Drawing.Point(38, 214);
            this.buAjouter.Name = "buAjouter";
            this.buAjouter.Size = new System.Drawing.Size(89, 43);
            this.buAjouter.TabIndex = 4;
            this.buAjouter.Text = "Ajouter";
            this.buAjouter.UseVisualStyleBackColor = true;
            this.buAjouter.Click += new System.EventHandler(this.buAjouter_Click);
            // 
            // buSupprimer
            // 
            this.buSupprimer.Location = new System.Drawing.Point(203, 214);
            this.buSupprimer.Name = "buSupprimer";
            this.buSupprimer.Size = new System.Drawing.Size(94, 43);
            this.buSupprimer.TabIndex = 5;
            this.buSupprimer.Text = "Supprimer";
            this.buSupprimer.UseVisualStyleBackColor = true;
            this.buSupprimer.Click += new System.EventHandler(this.buSupprimer_Click);
            // 
            // buVider
            // 
            this.buVider.Location = new System.Drawing.Point(369, 214);
            this.buVider.Name = "buVider";
            this.buVider.Size = new System.Drawing.Size(89, 43);
            this.buVider.TabIndex = 6;
            this.buVider.Text = "Vider";
            this.buVider.UseVisualStyleBackColor = true;
            this.buVider.Click += new System.EventHandler(this.buVider_Click);
            // 
            // buDroite
            // 
            this.buDroite.Location = new System.Drawing.Point(338, 349);
            this.buDroite.Name = "buDroite";
            this.buDroite.Size = new System.Drawing.Size(78, 39);
            this.buDroite.TabIndex = 7;
            this.buDroite.Text = ">";
            this.buDroite.UseVisualStyleBackColor = true;
            this.buDroite.Click += new System.EventHandler(this.buDroite_Click);
            // 
            // buToutDroite
            // 
            this.buToutDroite.Location = new System.Drawing.Point(338, 414);
            this.buToutDroite.Name = "buToutDroite";
            this.buToutDroite.Size = new System.Drawing.Size(78, 39);
            this.buToutDroite.TabIndex = 8;
            this.buToutDroite.Text = ">>";
            this.buToutDroite.UseVisualStyleBackColor = true;
            this.buToutDroite.Click += new System.EventHandler(this.buToutDroite_Click);
            // 
            // buGauche
            // 
            this.buGauche.Location = new System.Drawing.Point(338, 481);
            this.buGauche.Name = "buGauche";
            this.buGauche.Size = new System.Drawing.Size(78, 39);
            this.buGauche.TabIndex = 9;
            this.buGauche.Text = "<";
            this.buGauche.UseVisualStyleBackColor = true;
            this.buGauche.Click += new System.EventHandler(this.buGauche_Click);
            // 
            // buToutGauche
            // 
            this.buToutGauche.Location = new System.Drawing.Point(338, 547);
            this.buToutGauche.Name = "buToutGauche";
            this.buToutGauche.Size = new System.Drawing.Size(78, 39);
            this.buToutGauche.TabIndex = 10;
            this.buToutGauche.Text = "<<";
            this.buToutGauche.UseVisualStyleBackColor = true;
            this.buToutGauche.Click += new System.EventHandler(this.buToutGauche_Click);
            // 
            // lbGauche
            // 
            this.lbGauche.FormattingEnabled = true;
            this.lbGauche.ItemHeight = 24;
            this.lbGauche.Location = new System.Drawing.Point(38, 349);
            this.lbGauche.Name = "lbGauche";
            this.lbGauche.Size = new System.Drawing.Size(250, 340);
            this.lbGauche.TabIndex = 11;
            // 
            // lbDroite
            // 
            this.lbDroite.FormattingEnabled = true;
            this.lbDroite.ItemHeight = 24;
            this.lbDroite.Location = new System.Drawing.Point(463, 349);
            this.lbDroite.Name = "lbDroite";
            this.lbDroite.Size = new System.Drawing.Size(250, 340);
            this.lbDroite.TabIndex = 12;
            // 
            // cbMultiLigne
            // 
            this.cbMultiLigne.AutoSize = true;
            this.cbMultiLigne.Location = new System.Drawing.Point(28, 711);
            this.cbMultiLigne.Name = "cbMultiLigne";
            this.cbMultiLigne.Size = new System.Drawing.Size(242, 28);
            this.cbMultiLigne.TabIndex = 13;
            this.cbMultiLigne.Text = "Autoriser la sélection multiple";
            this.cbMultiLigne.UseVisualStyleBackColor = true;
            this.cbMultiLigne.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 744);
            this.Controls.Add(this.cbMultiLigne);
            this.Controls.Add(this.lbDroite);
            this.Controls.Add(this.lbGauche);
            this.Controls.Add(this.buToutGauche);
            this.Controls.Add(this.buGauche);
            this.Controls.Add(this.buToutDroite);
            this.Controls.Add(this.buDroite);
            this.Controls.Add(this.buVider);
            this.Controls.Add(this.buSupprimer);
            this.Controls.Add(this.buAjouter);
            this.Controls.Add(this.lbQuantite);
            this.Controls.Add(this.lbProduit);
            this.Controls.Add(this.dudQuantite);
            this.Controls.Add(this.dudProduit);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dudProduit;
        private System.Windows.Forms.DomainUpDown dudQuantite;
        private System.Windows.Forms.Label lbProduit;
        private System.Windows.Forms.Label lbQuantite;
        private System.Windows.Forms.Button buAjouter;
        private System.Windows.Forms.Button buSupprimer;
        private System.Windows.Forms.Button buVider;
        private System.Windows.Forms.Button buDroite;
        private System.Windows.Forms.Button buToutDroite;
        private System.Windows.Forms.Button buGauche;
        private System.Windows.Forms.Button buToutGauche;
        private System.Windows.Forms.ListBox lbGauche;
        private System.Windows.Forms.ListBox lbDroite;
        private System.Windows.Forms.CheckBox cbMultiLigne;
    }
}

