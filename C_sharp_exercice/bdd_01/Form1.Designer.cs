namespace bdd_01 {
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
            this.gb01 = new System.Windows.Forms.GroupBox();
            this.btPremier = new System.Windows.Forms.Button();
            this.btPrecedent = new System.Windows.Forms.Button();
            this.btSuivant = new System.Windows.Forms.Button();
            this.btDernier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gb01
            // 
            this.gb01.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb01.Location = new System.Drawing.Point(277, 0);
            this.gb01.Name = "gb01";
            this.gb01.Size = new System.Drawing.Size(208, 385);
            this.gb01.TabIndex = 0;
            this.gb01.TabStop = false;
            this.gb01.Text = "groupBox1";
            // 
            // btPremier
            // 
            this.btPremier.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPremier.Location = new System.Drawing.Point(30, 27);
            this.btPremier.Name = "btPremier";
            this.btPremier.Size = new System.Drawing.Size(221, 70);
            this.btPremier.TabIndex = 1;
            this.btPremier.Text = "Premier";
            this.btPremier.UseVisualStyleBackColor = true;
            this.btPremier.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPrecedent
            // 
            this.btPrecedent.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrecedent.Location = new System.Drawing.Point(30, 103);
            this.btPrecedent.Name = "btPrecedent";
            this.btPrecedent.Size = new System.Drawing.Size(221, 70);
            this.btPrecedent.TabIndex = 2;
            this.btPrecedent.Text = "Précédent";
            this.btPrecedent.UseVisualStyleBackColor = true;
            // 
            // btSuivant
            // 
            this.btSuivant.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuivant.Location = new System.Drawing.Point(30, 179);
            this.btSuivant.Name = "btSuivant";
            this.btSuivant.Size = new System.Drawing.Size(221, 70);
            this.btSuivant.TabIndex = 3;
            this.btSuivant.Text = "Suivant";
            this.btSuivant.UseVisualStyleBackColor = true;
            // 
            // btDernier
            // 
            this.btDernier.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDernier.Location = new System.Drawing.Point(30, 255);
            this.btDernier.Name = "btDernier";
            this.btDernier.Size = new System.Drawing.Size(221, 70);
            this.btDernier.TabIndex = 4;
            this.btDernier.Text = "Dernier";
            this.btDernier.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 385);
            this.Controls.Add(this.btDernier);
            this.Controls.Add(this.btSuivant);
            this.Controls.Add(this.btPrecedent);
            this.Controls.Add(this.btPremier);
            this.Controls.Add(this.gb01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb01;
        private System.Windows.Forms.Button btPremier;
        private System.Windows.Forms.Button btPrecedent;
        private System.Windows.Forms.Button btSuivant;
        private System.Windows.Forms.Button btDernier;
    }
}

