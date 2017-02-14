namespace exercice03 {
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
            this.definirMessage = new System.Windows.Forms.Button();
            this.definirTitre = new System.Windows.Forms.Button();
            this.afficherMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // definirMessage
            // 
            this.definirMessage.Location = new System.Drawing.Point(32, 26);
            this.definirMessage.Name = "definirMessage";
            this.definirMessage.Size = new System.Drawing.Size(612, 62);
            this.definirMessage.TabIndex = 0;
            this.definirMessage.Text = "Définir le message";
            this.definirMessage.UseVisualStyleBackColor = true;
            this.definirMessage.Click += new System.EventHandler(this.definirMessage_Click);
            // 
            // definirTitre
            // 
            this.definirTitre.Location = new System.Drawing.Point(32, 125);
            this.definirTitre.Name = "definirTitre";
            this.definirTitre.Size = new System.Drawing.Size(612, 62);
            this.definirTitre.TabIndex = 1;
            this.definirTitre.Text = "Définir le titre";
            this.definirTitre.UseVisualStyleBackColor = true;
            this.definirTitre.Click += new System.EventHandler(this.definirTitre_Click);
            // 
            // afficherMessage
            // 
            this.afficherMessage.Location = new System.Drawing.Point(32, 221);
            this.afficherMessage.Name = "afficherMessage";
            this.afficherMessage.Size = new System.Drawing.Size(612, 62);
            this.afficherMessage.TabIndex = 2;
            this.afficherMessage.Text = "Afficher le message";
            this.afficherMessage.UseVisualStyleBackColor = true;
            this.afficherMessage.Click += new System.EventHandler(this.afficherMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 321);
            this.Controls.Add(this.afficherMessage);
            this.Controls.Add(this.definirTitre);
            this.Controls.Add(this.definirMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button definirMessage;
        private System.Windows.Forms.Button definirTitre;
        private System.Windows.Forms.Button afficherMessage;
    }
}

