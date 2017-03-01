namespace ex_window_control_04 {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbGenerer = new System.Windows.Forms.Button();
            this.lbLigne = new System.Windows.Forms.Label();
            this.lbColonne = new System.Windows.Forms.Label();
            this.nbligne = new System.Windows.Forms.TextBox();
            this.nbcolonne = new System.Windows.Forms.TextBox();
            this.ctrlImage = new System.Windows.Forms.ImageList(this.components);
            this.monpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbGenerer
            // 
            this.lbGenerer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenerer.Location = new System.Drawing.Point(446, 21);
            this.lbGenerer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbGenerer.Name = "lbGenerer";
            this.lbGenerer.Size = new System.Drawing.Size(69, 26);
            this.lbGenerer.TabIndex = 0;
            this.lbGenerer.Text = "Générer";
            this.lbGenerer.UseVisualStyleBackColor = true;
            this.lbGenerer.Click += new System.EventHandler(this.lbGenerer_Click);
            // 
            // lbLigne
            // 
            this.lbLigne.AutoSize = true;
            this.lbLigne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLigne.Location = new System.Drawing.Point(34, 25);
            this.lbLigne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLigne.Name = "lbLigne";
            this.lbLigne.Size = new System.Drawing.Size(117, 20);
            this.lbLigne.TabIndex = 1;
            this.lbLigne.Text = "Nombre de lignes";
            this.lbLigne.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbColonne
            // 
            this.lbColonne.AutoSize = true;
            this.lbColonne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColonne.Location = new System.Drawing.Point(224, 25);
            this.lbColonne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbColonne.Name = "lbColonne";
            this.lbColonne.Size = new System.Drawing.Size(136, 20);
            this.lbColonne.TabIndex = 2;
            this.lbColonne.Text = "Nombre de colonnes";
            // 
            // nbligne
            // 
            this.nbligne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbligne.Location = new System.Drawing.Point(151, 20);
            this.nbligne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nbligne.MaxLength = 2;
            this.nbligne.Name = "nbligne";
            this.nbligne.Size = new System.Drawing.Size(44, 26);
            this.nbligne.TabIndex = 3;
            this.nbligne.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nbcolonne
            // 
            this.nbcolonne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbcolonne.Location = new System.Drawing.Point(357, 23);
            this.nbcolonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nbcolonne.MaxLength = 2;
            this.nbcolonne.Name = "nbcolonne";
            this.nbcolonne.Size = new System.Drawing.Size(44, 26);
            this.nbcolonne.TabIndex = 4;
            // 
            // ctrlImage
            // 
            this.ctrlImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ctrlImage.ImageStream")));
            this.ctrlImage.TransparentColor = System.Drawing.Color.Transparent;
            this.ctrlImage.Images.SetKeyName(0, "allemagne.bmp");
            this.ctrlImage.Images.SetKeyName(1, "belgique.bmp");
            this.ctrlImage.Images.SetKeyName(2, "france.bmp");
            this.ctrlImage.Images.SetKeyName(3, "italie.bmp");
            // 
            // monpanel
            // 
            this.monpanel.AutoScroll = true;
            this.monpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.monpanel.Location = new System.Drawing.Point(0, 54);
            this.monpanel.Name = "monpanel";
            this.monpanel.Size = new System.Drawing.Size(554, 382);
            this.monpanel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 436);
            this.Controls.Add(this.monpanel);
            this.Controls.Add(this.nbcolonne);
            this.Controls.Add(this.nbligne);
            this.Controls.Add(this.lbColonne);
            this.Controls.Add(this.lbLigne);
            this.Controls.Add(this.lbGenerer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbGenerer;
        private System.Windows.Forms.Label lbLigne;
        private System.Windows.Forms.Label lbColonne;
        private System.Windows.Forms.TextBox nbligne;
        private System.Windows.Forms.TextBox nbcolonne;
        private System.Windows.Forms.ImageList ctrlImage;
        private System.Windows.Forms.Panel monpanel;
    }
}

