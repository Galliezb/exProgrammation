namespace C_sharp_exercice {
    partial class formPays {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPays));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPays = new System.Windows.Forms.ComboBox();
            this.txtCapitale = new System.Windows.Forms.TextBox();
            this.buOk = new System.Windows.Forms.Button();
            this.pbDrapeau = new System.Windows.Forms.PictureBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.tiHorloge = new System.Windows.Forms.Timer(this.components);
            this.lbErreur = new System.Windows.Forms.Label();
            this.lbHeure = new System.Windows.Forms.Label();
            this.PUTAINEUREKA = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrapeau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbPays
            // 
            this.cbPays.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cbPays.FormattingEnabled = true;
            this.cbPays.Items.AddRange(new object[] {
            resources.GetString("cbPays.Items"),
            resources.GetString("cbPays.Items1"),
            resources.GetString("cbPays.Items2"),
            resources.GetString("cbPays.Items3"),
            resources.GetString("cbPays.Items4"),
            resources.GetString("cbPays.Items5")});
            resources.ApplyResources(this.cbPays, "cbPays");
            this.cbPays.Name = "cbPays";
            this.cbPays.TabStop = false;
            this.cbPays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCapitale
            // 
            resources.ApplyResources(this.txtCapitale, "txtCapitale");
            this.txtCapitale.Name = "txtCapitale";
            this.txtCapitale.TextChanged += new System.EventHandler(this.tbCapitale_TextChanged);
            // 
            // buOk
            // 
            this.buOk.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.buOk, "buOk");
            this.buOk.Name = "buOk";
            this.buOk.UseVisualStyleBackColor = true;
            this.buOk.Click += new System.EventHandler(this.Form1_MouseOver);
            // 
            // pbDrapeau
            // 
            resources.ApplyResources(this.pbDrapeau, "pbDrapeau");
            this.pbDrapeau.Name = "pbDrapeau";
            this.pbDrapeau.TabStop = false;
            // 
            // lbDate
            // 
            this.lbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lbDate, "lbDate");
            this.lbDate.Name = "lbDate";
            // 
            // tiHorloge
            // 
            this.tiHorloge.Tick += new System.EventHandler(this.tiHorloge_Tick);
            // 
            // lbErreur
            // 
            resources.ApplyResources(this.lbErreur, "lbErreur");
            this.lbErreur.Name = "lbErreur";
            // 
            // lbHeure
            // 
            this.lbHeure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lbHeure, "lbHeure");
            this.lbHeure.Name = "lbHeure";
            this.lbHeure.Click += new System.EventHandler(this.lbHeure_Click);
            // 
            // PUTAINEUREKA
            // 
            resources.ApplyResources(this.PUTAINEUREKA, "PUTAINEUREKA");
            this.PUTAINEUREKA.Name = "PUTAINEUREKA";
            this.PUTAINEUREKA.UseVisualStyleBackColor = true;
            this.PUTAINEUREKA.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // hScrollBar1
            // 
            resources.ApplyResources(this.hScrollBar1, "hScrollBar1");
            this.hScrollBar1.Name = "hScrollBar1";
            // 
            // formPays
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.PUTAINEUREKA);
            this.Controls.Add(this.lbHeure);
            this.Controls.Add(this.lbErreur);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.pbDrapeau);
            this.Controls.Add(this.buOk);
            this.Controls.Add(this.txtCapitale);
            this.Controls.Add(this.cbPays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formPays";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrapeau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPays;
        private System.Windows.Forms.TextBox txtCapitale;
        private System.Windows.Forms.Button buOk;
        private System.Windows.Forms.PictureBox pbDrapeau;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Timer tiHorloge;
        private System.Windows.Forms.Label lbErreur;
        private System.Windows.Forms.Label lbHeure;
        private System.Windows.Forms.Button PUTAINEUREKA;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

