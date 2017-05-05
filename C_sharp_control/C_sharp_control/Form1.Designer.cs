namespace C_sharp_control {
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
            this.label1 = new System.Windows.Forms.Label();
            this.grLogement = new System.Windows.Forms.GroupBox();
            this.tbLoyer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSuperficie = new System.Windows.Forms.TextBox();
            this.lbSuperficie = new System.Windows.Forms.Label();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbidQuartier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIentifiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btNouveau = new System.Windows.Forms.Button();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btBefore = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.cbQuartier = new System.Windows.Forms.ComboBox();
            this.grLogement.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quartier :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grLogement
            // 
            this.grLogement.Controls.Add(this.tbLoyer);
            this.grLogement.Controls.Add(this.label8);
            this.grLogement.Controls.Add(this.tbSuperficie);
            this.grLogement.Controls.Add(this.lbSuperficie);
            this.grLogement.Controls.Add(this.tbRue);
            this.grLogement.Controls.Add(this.label6);
            this.grLogement.Controls.Add(this.tbNumero);
            this.grLogement.Controls.Add(this.lbNumero);
            this.grLogement.Controls.Add(this.tbidQuartier);
            this.grLogement.Controls.Add(this.label4);
            this.grLogement.Controls.Add(this.tbType);
            this.grLogement.Controls.Add(this.label3);
            this.grLogement.Controls.Add(this.tbIentifiant);
            this.grLogement.Controls.Add(this.label2);
            this.grLogement.Location = new System.Drawing.Point(41, 125);
            this.grLogement.Name = "grLogement";
            this.grLogement.Size = new System.Drawing.Size(514, 434);
            this.grLogement.TabIndex = 2;
            this.grLogement.TabStop = false;
            this.grLogement.Text = "Logement : ";
            // 
            // tbLoyer
            // 
            this.tbLoyer.Location = new System.Drawing.Point(245, 336);
            this.tbLoyer.Name = "tbLoyer";
            this.tbLoyer.Size = new System.Drawing.Size(227, 29);
            this.tbLoyer.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Loyer : ";
            // 
            // tbSuperficie
            // 
            this.tbSuperficie.Location = new System.Drawing.Point(245, 292);
            this.tbSuperficie.Name = "tbSuperficie";
            this.tbSuperficie.Size = new System.Drawing.Size(227, 29);
            this.tbSuperficie.TabIndex = 11;
            // 
            // lbSuperficie
            // 
            this.lbSuperficie.AutoSize = true;
            this.lbSuperficie.Location = new System.Drawing.Point(28, 292);
            this.lbSuperficie.Name = "lbSuperficie";
            this.lbSuperficie.Size = new System.Drawing.Size(129, 23);
            this.lbSuperficie.TabIndex = 10;
            this.lbSuperficie.Text = "Superficie : ";
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(245, 247);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(227, 29);
            this.tbRue.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rue : ";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(245, 198);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(227, 29);
            this.tbNumero.TabIndex = 7;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(28, 198);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(108, 23);
            this.lbNumero.TabIndex = 6;
            this.lbNumero.Text = "Numéro : ";
            // 
            // tbidQuartier
            // 
            this.tbidQuartier.Location = new System.Drawing.Point(245, 152);
            this.tbidQuartier.Name = "tbidQuartier";
            this.tbidQuartier.Size = new System.Drawing.Size(227, 29);
            this.tbidQuartier.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "id Qurtier :";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(245, 104);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(227, 29);
            this.tbType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type :  ";
            // 
            // tbIentifiant
            // 
            this.tbIentifiant.Location = new System.Drawing.Point(245, 59);
            this.tbIentifiant.Name = "tbIentifiant";
            this.tbIentifiant.Size = new System.Drawing.Size(227, 29);
            this.tbIentifiant.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identifiant : ";
            // 
            // btNouveau
            // 
            this.btNouveau.Location = new System.Drawing.Point(136, 645);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(124, 47);
            this.btNouveau.TabIndex = 3;
            this.btNouveau.Text = "Nouveau";
            this.btNouveau.UseVisualStyleBackColor = true;
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Location = new System.Drawing.Point(311, 645);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(124, 47);
            this.btEnregistrer.TabIndex = 4;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(108, 565);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(59, 42);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "|<";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btBefore
            // 
            this.btBefore.Location = new System.Drawing.Point(201, 565);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(59, 42);
            this.btBefore.TabIndex = 6;
            this.btBefore.Text = "<";
            this.btBefore.UseVisualStyleBackColor = true;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(311, 565);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(59, 42);
            this.btNext.TabIndex = 7;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(420, 565);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(59, 42);
            this.btEnd.TabIndex = 8;
            this.btEnd.Text = ">|";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // cbQuartier
            // 
            this.cbQuartier.FormattingEnabled = true;
            this.cbQuartier.Location = new System.Drawing.Point(286, 70);
            this.cbQuartier.Name = "cbQuartier";
            this.cbQuartier.Size = new System.Drawing.Size(227, 30);
            this.cbQuartier.TabIndex = 14;
            this.cbQuartier.SelectedIndexChanged += new System.EventHandler(this.cbQuartier_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 709);
            this.Controls.Add(this.cbQuartier);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBefore);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.btNouveau);
            this.Controls.Add(this.grLogement);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grLogement.ResumeLayout(false);
            this.grLogement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grLogement;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.TextBox tbLoyer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSuperficie;
        private System.Windows.Forms.Label lbSuperficie;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbidQuartier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIentifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbQuartier;
    }
}

