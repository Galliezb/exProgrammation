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
            this.lbPays.Location = new System.Drawing.Point(16, 13);
            this.lbPays.Name = "lbPays";
            this.lbPays.Size = new System.Drawing.Size(48, 17);
            this.lbPays.TabIndex = 0;
            this.lbPays.Text = "Pays:";
            // 
            // frCapitale
            // 
            this.frCapitale.AutoSize = true;
            this.frCapitale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frCapitale.Location = new System.Drawing.Point(16, 56);
            this.frCapitale.Name = "frCapitale";
            this.frCapitale.Size = new System.Drawing.Size(70, 16);
            this.frCapitale.TabIndex = 1;
            this.frCapitale.Text = "Capitale:";
            // 
            // lbValider
            // 
            this.lbValider.AutoSize = true;
            this.lbValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValider.Location = new System.Drawing.Point(16, 99);
            this.lbValider.Name = "lbValider";
            this.lbValider.Size = new System.Drawing.Size(196, 16);
            this.lbValider.TabIndex = 2;
            this.lbValider.Text = "Valider en appuyant sur OK";
            // 
            // cbPays
            // 
            this.cbPays.FormattingEnabled = true;
            this.cbPays.Location = new System.Drawing.Point(145, 13);
            this.cbPays.Name = "cbPays";
            this.cbPays.Size = new System.Drawing.Size(121, 21);
            this.cbPays.TabIndex = 3;
            this.cbPays.Text = "Allemagne";
            this.cbPays.SelectedIndexChanged += new System.EventHandler(this.cbPays_SelectedIndexChanged);
            // 
            // txtCapitale
            // 
            this.txtCapitale.Location = new System.Drawing.Point(145, 52);
            this.txtCapitale.Name = "txtCapitale";
            this.txtCapitale.Size = new System.Drawing.Size(121, 20);
            this.txtCapitale.TabIndex = 4;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(234, 96);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(59, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // pbDrapeau
            // 
            this.pbDrapeau.Location = new System.Drawing.Point(78, 148);
            this.pbDrapeau.Name = "pbDrapeau";
            this.pbDrapeau.Size = new System.Drawing.Size(107, 68);
            this.pbDrapeau.TabIndex = 6;
            this.pbDrapeau.TabStop = false;
            this.pbDrapeau.Click += new System.EventHandler(this.pbDrapeau_Click);
            // 
            // lbErreur
            // 
            this.lbErreur.AutoSize = true;
            this.lbErreur.ForeColor = System.Drawing.Color.Red;
            this.lbErreur.Location = new System.Drawing.Point(24, 115);
            this.lbErreur.Name = "lbErreur";
            this.lbErreur.Size = new System.Drawing.Size(0, 13);
            this.lbErreur.TabIndex = 7;
            // 
            // lbDateJour
            // 
            this.lbDateJour.AutoSize = true;
            this.lbDateJour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDateJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateJour.Location = new System.Drawing.Point(19, 225);
            this.lbDateJour.Name = "lbDateJour";
            this.lbDateJour.Size = new System.Drawing.Size(2, 18);
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
            this.lbHeureCourante.Location = new System.Drawing.Point(22, 258);
            this.lbHeureCourante.Name = "lbHeureCourante";
            this.lbHeureCourante.Size = new System.Drawing.Size(2, 18);
            this.lbHeureCourante.TabIndex = 9;
            // 
            // btInitialiser
            // 
            this.btInitialiser.Location = new System.Drawing.Point(234, 125);
            this.btInitialiser.Name = "btInitialiser";
            this.btInitialiser.Size = new System.Drawing.Size(75, 23);
            this.btInitialiser.TabIndex = 10;
            this.btInitialiser.Text = "Réinitialiser";
            this.btInitialiser.UseVisualStyleBackColor = true;
            this.btInitialiser.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTempsEcoule
            // 
            this.lbTempsEcoule.AutoSize = true;
            this.lbTempsEcoule.Location = new System.Drawing.Point(20, 292);
            this.lbTempsEcoule.Name = "lbTempsEcoule";
            this.lbTempsEcoule.Size = new System.Drawing.Size(0, 13);
            this.lbTempsEcoule.TabIndex = 11;
            // 
            // btChoisir
            // 
            this.btChoisir.Location = new System.Drawing.Point(238, 158);
            this.btChoisir.Name = "btChoisir";
            this.btChoisir.Size = new System.Drawing.Size(75, 23);
            this.btChoisir.TabIndex = 12;
            this.btChoisir.Text = "Choisir";
            this.btChoisir.UseVisualStyleBackColor = true;
            this.btChoisir.Click += new System.EventHandler(this.btChoisir_Click);
            // 
            // frInfoPays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 318);
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

