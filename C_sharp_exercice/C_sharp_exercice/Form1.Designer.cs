namespace WindowsFormsApplication1
{
    partial class frInfoPays
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbPays = new System.Windows.Forms.Label();
            this.frCapitale = new System.Windows.Forms.Label();
            this.lbValider = new System.Windows.Forms.Label();
            this.cbPays = new System.Windows.Forms.ComboBox();
            this.txtCapitale = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.pbDrapeau = new System.Windows.Forms.PictureBox();
            this.lbErreur = new System.Windows.Forms.Label();
            this.lbDateJour = new System.Windows.Forms.Label();
            this.tiHorloge = new System.Windows.Forms.Timer(this.components);
            this.lbHeureCourante = new System.Windows.Forms.Label();
            this.btInitialiser = new System.Windows.Forms.Button();
            this.lbTempsEcoule = new System.Windows.Forms.Label();
            this.btChoisir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrapeau)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPays
            // 
            this.lbPays.AutoSize = true;
            this.lbPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPays.Location = new System.Drawing.Point(21, 16);
            this.lbPays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPays.Name = "lbPays";
            this.lbPays.Size = new System.Drawing.Size(56, 20);
            this.lbPays.TabIndex = 0;
            this.lbPays.Text = "Pays:";
            // 
            // frCapitale
            // 
            this.frCapitale.AutoSize = true;
            this.frCapitale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frCapitale.Location = new System.Drawing.Point(21, 69);
            this.frCapitale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frCapitale.Name = "frCapitale";
            this.frCapitale.Size = new System.Drawing.Size(84, 20);
            this.frCapitale.TabIndex = 1;
            this.frCapitale.Text = "Capitale:";
            // 
            // lbValider
            // 
            this.lbValider.AutoSize = true;
            this.lbValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValider.Location = new System.Drawing.Point(21, 122);
            this.lbValider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValider.Name = "lbValider";
            this.lbValider.Size = new System.Drawing.Size(240, 20);
            this.lbValider.TabIndex = 2;
            this.lbValider.Text = "Valider en appuyant sur OK";
            // 
            // cbPays
            // 
            this.cbPays.FormattingEnabled = true;
            this.cbPays.Location = new System.Drawing.Point(193, 16);
            this.cbPays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPays.Name = "cbPays";
            this.cbPays.Size = new System.Drawing.Size(160, 24);
            this.cbPays.TabIndex = 3;
            this.cbPays.Text = "Allemagne";
            this.cbPays.SelectedIndexChanged += new System.EventHandler(this.cbPays_SelectedIndexChanged);
            // 
            // txtCapitale
            // 
            this.txtCapitale.Location = new System.Drawing.Point(193, 64);
            this.txtCapitale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCapitale.Name = "txtCapitale";
            this.txtCapitale.Size = new System.Drawing.Size(160, 22);
            this.txtCapitale.TabIndex = 4;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(312, 118);
            this.btOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(79, 28);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // pbDrapeau
            // 
            this.pbDrapeau.Location = new System.Drawing.Point(104, 182);
            this.pbDrapeau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDrapeau.Name = "pbDrapeau";
            this.pbDrapeau.Size = new System.Drawing.Size(143, 84);
            this.pbDrapeau.TabIndex = 6;
            this.pbDrapeau.TabStop = false;
            // 
            // lbErreur
            // 
            this.lbErreur.AutoSize = true;
            this.lbErreur.ForeColor = System.Drawing.Color.Red;
            this.lbErreur.Location = new System.Drawing.Point(32, 142);
            this.lbErreur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErreur.Name = "lbErreur";
            this.lbErreur.Size = new System.Drawing.Size(0, 17);
            this.lbErreur.TabIndex = 7;
            // 
            // lbDateJour
            // 
            this.lbDateJour.AutoSize = true;
            this.lbDateJour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDateJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateJour.Location = new System.Drawing.Point(25, 277);
            this.lbDateJour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateJour.Name = "lbDateJour";
            this.lbDateJour.Size = new System.Drawing.Size(2, 22);
            this.lbDateJour.TabIndex = 8;
            // 
            // tiHorloge
            // 
            this.tiHorloge.Enabled = true;
            this.tiHorloge.Interval = 1000;
            this.tiHorloge.Tick += new System.EventHandler(this.tiHorloge_Tick);
            // 
            // lbHeureCourante
            // 
            this.lbHeureCourante.AutoSize = true;
            this.lbHeureCourante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHeureCourante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeureCourante.Location = new System.Drawing.Point(29, 318);
            this.lbHeureCourante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeureCourante.Name = "lbHeureCourante";
            this.lbHeureCourante.Size = new System.Drawing.Size(2, 22);
            this.lbHeureCourante.TabIndex = 9;
            // 
            // btInitialiser
            // 
            this.btInitialiser.Location = new System.Drawing.Point(312, 154);
            this.btInitialiser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btInitialiser.Name = "btInitialiser";
            this.btInitialiser.Size = new System.Drawing.Size(100, 28);
            this.btInitialiser.TabIndex = 10;
            this.btInitialiser.Text = "Réinitialiser";
            this.btInitialiser.UseVisualStyleBackColor = true;
            this.btInitialiser.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTempsEcoule
            // 
            this.lbTempsEcoule.AutoSize = true;
            this.lbTempsEcoule.Location = new System.Drawing.Point(27, 359);
            this.lbTempsEcoule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTempsEcoule.Name = "lbTempsEcoule";
            this.lbTempsEcoule.Size = new System.Drawing.Size(0, 17);
            this.lbTempsEcoule.TabIndex = 11;
            // 
            // btChoisir
            // 
            this.btChoisir.Location = new System.Drawing.Point(317, 194);
            this.btChoisir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btChoisir.Name = "btChoisir";
            this.btChoisir.Size = new System.Drawing.Size(100, 28);
            this.btChoisir.TabIndex = 12;
            this.btChoisir.Text = "Choisir";
            this.btChoisir.UseVisualStyleBackColor = true;
            this.btChoisir.Click += new System.EventHandler(this.btChoisir_Click);
            // 
            // frInfoPays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 391);
            this.Controls.Add(this.btChoisir);
            this.Controls.Add(this.lbTempsEcoule);
            this.Controls.Add(this.btInitialiser);
            this.Controls.Add(this.lbHeureCourante);
            this.Controls.Add(this.lbDateJour);
            this.Controls.Add(this.lbErreur);
            this.Controls.Add(this.pbDrapeau);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.txtCapitale);
            this.Controls.Add(this.cbPays);
            this.Controls.Add(this.lbValider);
            this.Controls.Add(this.frCapitale);
            this.Controls.Add(this.lbPays);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frInfoPays";
            this.Text = "Informations sur les pays";
            this.Load += new System.EventHandler(this.frInfoPays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrapeau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPays;
        private System.Windows.Forms.Label frCapitale;
        private System.Windows.Forms.Label lbValider;
        private System.Windows.Forms.ComboBox cbPays;
        private System.Windows.Forms.TextBox txtCapitale;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.PictureBox pbDrapeau;
        private System.Windows.Forms.Label lbErreur;
        private System.Windows.Forms.Label lbDateJour;
        private System.Windows.Forms.Timer tiHorloge;
        private System.Windows.Forms.Label lbHeureCourante;
        private System.Windows.Forms.Button btInitialiser;
        private System.Windows.Forms.Label lbTempsEcoule;
        private System.Windows.Forms.Button btChoisir;
    }
}

