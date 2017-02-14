namespace ex_window_control_01 {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.conversion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMetreCube = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.sauver = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.RichTextBox();
            this.lbOuvrirFichier = new System.Windows.Forms.LinkLabel();
            this.txtLitre = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtLitre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMetreCube);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.conversion);
            this.panel1.Location = new System.Drawing.Point(26, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 247);
            this.panel1.TabIndex = 0;
            // 
            // conversion
            // 
            this.conversion.Location = new System.Drawing.Point(475, 87);
            this.conversion.Name = "conversion";
            this.conversion.Size = new System.Drawing.Size(153, 39);
            this.conversion.TabIndex = 1;
            this.conversion.Text = "conversion";
            this.conversion.UseVisualStyleBackColor = true;
            this.conversion.Click += new System.EventHandler(this.conversion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(690, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Litres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(710, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "m3";
            // 
            // txtMetreCube
            // 
            this.txtMetreCube.Location = new System.Drawing.Point(433, 168);
            this.txtMetreCube.Name = "txtMetreCube";
            this.txtMetreCube.Size = new System.Drawing.Size(246, 22);
            this.txtMetreCube.TabIndex = 4;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(74, 296);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(153, 39);
            this.ajouter.TabIndex = 6;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // sauver
            // 
            this.sauver.Location = new System.Drawing.Point(285, 296);
            this.sauver.Name = "sauver";
            this.sauver.Size = new System.Drawing.Size(153, 39);
            this.sauver.TabIndex = 7;
            this.sauver.Text = "Sauver";
            this.sauver.UseVisualStyleBackColor = true;
            this.sauver.Click += new System.EventHandler(this.sauver_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(26, 379);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(1123, 227);
            this.txtSave.TabIndex = 8;
            this.txtSave.Text = "";
            // 
            // lbOuvrirFichier
            // 
            this.lbOuvrirFichier.AutoSize = true;
            this.lbOuvrirFichier.Enabled = false;
            this.lbOuvrirFichier.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOuvrirFichier.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbOuvrirFichier.Location = new System.Drawing.Point(512, 302);
            this.lbOuvrirFichier.Name = "lbOuvrirFichier";
            this.lbOuvrirFichier.Size = new System.Drawing.Size(142, 33);
            this.lbOuvrirFichier.TabIndex = 9;
            this.lbOuvrirFichier.TabStop = true;
            this.lbOuvrirFichier.Text = "Ouvrir fichier";
            // 
            // txtLitre
            // 
            this.txtLitre.Location = new System.Drawing.Point(433, 35);
            this.txtLitre.Name = "txtLitre";
            this.txtLitre.Size = new System.Drawing.Size(246, 22);
            this.txtLitre.TabIndex = 6;
            this.txtLitre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtLitre_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 628);
            this.Controls.Add(this.lbOuvrirFichier);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.sauver);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Conversion des litres en m cube";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMetreCube;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button conversion;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button sauver;
        private System.Windows.Forms.RichTextBox txtSave;
        private System.Windows.Forms.LinkLabel lbOuvrirFichier;
        private System.Windows.Forms.MaskedTextBox txtLitre;
    }
}

