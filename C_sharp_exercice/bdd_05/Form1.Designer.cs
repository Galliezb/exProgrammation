namespace bdd_05 {
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
            this.lbIdentifiant = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbDomaine = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.tbIdentifiant = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbDomaine = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.btCreation = new System.Windows.Forms.Button();
            this.btAjout = new System.Windows.Forms.Button();
            this.btAffichage = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIdentifiant
            // 
            this.lbIdentifiant.AutoSize = true;
            this.lbIdentifiant.Location = new System.Drawing.Point(119, 69);
            this.lbIdentifiant.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbIdentifiant.Name = "lbIdentifiant";
            this.lbIdentifiant.Size = new System.Drawing.Size(117, 25);
            this.lbIdentifiant.TabIndex = 0;
            this.lbIdentifiant.Text = "Identifiant";
            this.lbIdentifiant.Visible = false;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(379, 69);
            this.lbNom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(56, 25);
            this.lbNom.TabIndex = 1;
            this.lbNom.Text = "nom";
            this.lbNom.Visible = false;
            // 
            // lbDomaine
            // 
            this.lbDomaine.AutoSize = true;
            this.lbDomaine.Location = new System.Drawing.Point(624, 69);
            this.lbDomaine.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDomaine.Name = "lbDomaine";
            this.lbDomaine.Size = new System.Drawing.Size(98, 25);
            this.lbDomaine.TabIndex = 2;
            this.lbDomaine.Text = "domaine";
            this.lbDomaine.Visible = false;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(889, 69);
            this.lbAge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(50, 25);
            this.lbAge.TabIndex = 3;
            this.lbAge.Text = "Age";
            this.lbAge.Visible = false;
            this.lbAge.Click += new System.EventHandler(this.lbAge_Click);
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(91, 142);
            this.tbIdentifiant.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(160, 32);
            this.tbIdentifiant.TabIndex = 4;
            this.tbIdentifiant.Visible = false;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(325, 142);
            this.tbNom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(160, 32);
            this.tbNom.TabIndex = 5;
            this.tbNom.Visible = false;
            // 
            // tbDomaine
            // 
            this.tbDomaine.Location = new System.Drawing.Point(591, 142);
            this.tbDomaine.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbDomaine.Name = "tbDomaine";
            this.tbDomaine.Size = new System.Drawing.Size(160, 32);
            this.tbDomaine.TabIndex = 6;
            this.tbDomaine.Visible = false;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(842, 142);
            this.tbAge.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(160, 32);
            this.tbAge.TabIndex = 7;
            this.tbAge.Visible = false;
            // 
            // btCreation
            // 
            this.btCreation.Location = new System.Drawing.Point(174, 230);
            this.btCreation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btCreation.Name = "btCreation";
            this.btCreation.Size = new System.Drawing.Size(196, 58);
            this.btCreation.TabIndex = 8;
            this.btCreation.Text = "Creation";
            this.btCreation.UseVisualStyleBackColor = true;
            this.btCreation.Click += new System.EventHandler(this.btCreation_Click);
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(432, 230);
            this.btAjout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(191, 58);
            this.btAjout.TabIndex = 9;
            this.btAjout.Text = "Ajout";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // btAffichage
            // 
            this.btAffichage.Location = new System.Drawing.Point(679, 230);
            this.btAffichage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btAffichage.Name = "btAffichage";
            this.btAffichage.Size = new System.Drawing.Size(200, 58);
            this.btAffichage.TabIndex = 10;
            this.btAffichage.Text = "btAffichage";
            this.btAffichage.UseVisualStyleBackColor = true;
            // 
            // lbError
            // 
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(13, 13);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(1053, 39);
            this.lbError.TabIndex = 11;
            this.lbError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 752);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btAffichage);
            this.Controls.Add(this.btAjout);
            this.Controls.Add(this.btCreation);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbDomaine);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbIdentifiant);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbDomaine);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbIdentifiant);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdentifiant;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbDomaine;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox tbIdentifiant;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbDomaine;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Button btCreation;
        private System.Windows.Forms.Button btAjout;
        private System.Windows.Forms.Button btAffichage;
        private System.Windows.Forms.Label lbError;
    }
}

