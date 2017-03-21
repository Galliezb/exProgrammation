namespace bdd_04 {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btParametre = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.btNbEnregistrements = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btLecture = new System.Windows.Forms.Button();
            this.lbAccess = new System.Windows.Forms.Label();
            this.btOuvrir = new System.Windows.Forms.Button();
            this.btParametreSql = new System.Windows.Forms.Button();
            this.btModifierSql = new System.Windows.Forms.Button();
            this.btNbEnrSql = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btLectureSql = new System.Windows.Forms.Button();
            this.btOuvrirSql = new System.Windows.Forms.Button();
            this.lbSqlServer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btParametre);
            this.splitContainer1.Panel1.Controls.Add(this.btModifier);
            this.splitContainer1.Panel1.Controls.Add(this.btNbEnregistrements);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btLecture);
            this.splitContainer1.Panel1.Controls.Add(this.lbAccess);
            this.splitContainer1.Panel1.Controls.Add(this.btOuvrir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btParametreSql);
            this.splitContainer1.Panel2.Controls.Add(this.btModifierSql);
            this.splitContainer1.Panel2.Controls.Add(this.btNbEnrSql);
            this.splitContainer1.Panel2.Controls.Add(this.listBox2);
            this.splitContainer1.Panel2.Controls.Add(this.btLectureSql);
            this.splitContainer1.Panel2.Controls.Add(this.btOuvrirSql);
            this.splitContainer1.Panel2.Controls.Add(this.lbSqlServer);
            this.splitContainer1.Size = new System.Drawing.Size(621, 576);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // btParametre
            // 
            this.btParametre.Location = new System.Drawing.Point(39, 197);
            this.btParametre.Margin = new System.Windows.Forms.Padding(4);
            this.btParametre.Name = "btParametre";
            this.btParametre.Size = new System.Drawing.Size(100, 28);
            this.btParametre.TabIndex = 6;
            this.btParametre.Text = "Parametres";
            this.btParametre.UseVisualStyleBackColor = true;
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(36, 156);
            this.btModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(100, 28);
            this.btModifier.TabIndex = 5;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            // 
            // btNbEnregistrements
            // 
            this.btNbEnregistrements.Location = new System.Drawing.Point(16, 100);
            this.btNbEnregistrements.Margin = new System.Windows.Forms.Padding(4);
            this.btNbEnregistrements.Name = "btNbEnregistrements";
            this.btNbEnregistrements.Size = new System.Drawing.Size(152, 52);
            this.btNbEnregistrements.TabIndex = 4;
            this.btNbEnregistrements.Text = "Nombre enregistrements";
            this.btNbEnregistrements.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 235);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 228);
            this.listBox1.TabIndex = 3;
            // 
            // btLecture
            // 
            this.btLecture.Location = new System.Drawing.Point(33, 64);
            this.btLecture.Margin = new System.Windows.Forms.Padding(4);
            this.btLecture.Name = "btLecture";
            this.btLecture.Size = new System.Drawing.Size(100, 28);
            this.btLecture.TabIndex = 2;
            this.btLecture.Text = "Lecture";
            this.btLecture.UseVisualStyleBackColor = true;
            // 
            // lbAccess
            // 
            this.lbAccess.AutoSize = true;
            this.lbAccess.Location = new System.Drawing.Point(23, 9);
            this.lbAccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccess.Name = "lbAccess";
            this.lbAccess.Size = new System.Drawing.Size(53, 17);
            this.lbAccess.TabIndex = 1;
            this.lbAccess.Text = "Access";
            // 
            // btOuvrir
            // 
            this.btOuvrir.Location = new System.Drawing.Point(33, 28);
            this.btOuvrir.Margin = new System.Windows.Forms.Padding(4);
            this.btOuvrir.Name = "btOuvrir";
            this.btOuvrir.Size = new System.Drawing.Size(100, 28);
            this.btOuvrir.TabIndex = 0;
            this.btOuvrir.Text = "Ouvrir";
            this.btOuvrir.UseVisualStyleBackColor = true;
            // 
            // btParametreSql
            // 
            this.btParametreSql.Location = new System.Drawing.Point(51, 196);
            this.btParametreSql.Margin = new System.Windows.Forms.Padding(4);
            this.btParametreSql.Name = "btParametreSql";
            this.btParametreSql.Size = new System.Drawing.Size(100, 28);
            this.btParametreSql.TabIndex = 6;
            this.btParametreSql.Text = "Parametres";
            this.btParametreSql.UseVisualStyleBackColor = true;
            // 
            // btModifierSql
            // 
            this.btModifierSql.Location = new System.Drawing.Point(48, 156);
            this.btModifierSql.Margin = new System.Windows.Forms.Padding(4);
            this.btModifierSql.Name = "btModifierSql";
            this.btModifierSql.Size = new System.Drawing.Size(100, 28);
            this.btModifierSql.TabIndex = 5;
            this.btModifierSql.Text = "Modifier";
            this.btModifierSql.UseVisualStyleBackColor = true;
            // 
            // btNbEnrSql
            // 
            this.btNbEnrSql.Location = new System.Drawing.Point(21, 100);
            this.btNbEnrSql.Margin = new System.Windows.Forms.Padding(4);
            this.btNbEnrSql.Name = "btNbEnrSql";
            this.btNbEnrSql.Size = new System.Drawing.Size(153, 52);
            this.btNbEnrSql.TabIndex = 4;
            this.btNbEnrSql.Text = "Nombre enregistrements";
            this.btNbEnrSql.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(15, 235);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(159, 228);
            this.listBox2.TabIndex = 3;
            // 
            // btLectureSql
            // 
            this.btLectureSql.Location = new System.Drawing.Point(47, 64);
            this.btLectureSql.Margin = new System.Windows.Forms.Padding(4);
            this.btLectureSql.Name = "btLectureSql";
            this.btLectureSql.Size = new System.Drawing.Size(100, 28);
            this.btLectureSql.TabIndex = 2;
            this.btLectureSql.Text = "Lecture";
            this.btLectureSql.UseVisualStyleBackColor = true;
            // 
            // btOuvrirSql
            // 
            this.btOuvrirSql.Location = new System.Drawing.Point(47, 28);
            this.btOuvrirSql.Margin = new System.Windows.Forms.Padding(4);
            this.btOuvrirSql.Name = "btOuvrirSql";
            this.btOuvrirSql.Size = new System.Drawing.Size(100, 28);
            this.btOuvrirSql.TabIndex = 1;
            this.btOuvrirSql.Text = "Ouvrir";
            this.btOuvrirSql.UseVisualStyleBackColor = true;
            // 
            // lbSqlServer
            // 
            this.lbSqlServer.AutoSize = true;
            this.lbSqlServer.Location = new System.Drawing.Point(17, 7);
            this.lbSqlServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSqlServer.Name = "lbSqlServer";
            this.lbSqlServer.Size = new System.Drawing.Size(74, 17);
            this.lbSqlServer.TabIndex = 0;
            this.lbSqlServer.Text = "Sql Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 576);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btParametre;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btNbEnregistrements;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btLecture;
        private System.Windows.Forms.Label lbAccess;
        private System.Windows.Forms.Button btOuvrir;
        private System.Windows.Forms.Button btParametreSql;
        private System.Windows.Forms.Button btModifierSql;
        private System.Windows.Forms.Button btNbEnrSql;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btLectureSql;
        private System.Windows.Forms.Button btOuvrirSql;
        private System.Windows.Forms.Label lbSqlServer;
    }
}

