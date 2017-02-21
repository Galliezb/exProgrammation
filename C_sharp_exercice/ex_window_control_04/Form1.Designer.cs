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
            this.lbGenerer = new System.Windows.Forms.Button();
            this.lbLigne = new System.Windows.Forms.Label();
            this.lbColonne = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbGenerer
            // 
            this.lbGenerer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenerer.Location = new System.Drawing.Point(595, 26);
            this.lbGenerer.Name = "lbGenerer";
            this.lbGenerer.Size = new System.Drawing.Size(92, 32);
            this.lbGenerer.TabIndex = 0;
            this.lbGenerer.Text = "Générer";
            this.lbGenerer.UseVisualStyleBackColor = true;
            this.lbGenerer.Click += new System.EventHandler(this.lbGenerer_Click);
            // 
            // lbLigne
            // 
            this.lbLigne.AutoSize = true;
            this.lbLigne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLigne.Location = new System.Drawing.Point(45, 31);
            this.lbLigne.Name = "lbLigne";
            this.lbLigne.Size = new System.Drawing.Size(138, 24);
            this.lbLigne.TabIndex = 1;
            this.lbLigne.Text = "Nombre de lignes";
            this.lbLigne.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbColonne
            // 
            this.lbColonne.AutoSize = true;
            this.lbColonne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColonne.Location = new System.Drawing.Point(298, 31);
            this.lbColonne.Name = "lbColonne";
            this.lbColonne.Size = new System.Drawing.Size(161, 24);
            this.lbColonne.TabIndex = 2;
            this.lbColonne.Text = "Nombre de colonnes";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(201, 25);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(476, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 30);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 537);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbColonne);
            this.Controls.Add(this.lbLigne);
            this.Controls.Add(this.lbGenerer);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

