namespace WALaboratoire1
{
    partial class frLabo1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCalcul = new System.Windows.Forms.TabPage();
            this.tpAffichage = new System.Windows.Forms.TabPage();
            this.lbNombre1 = new System.Windows.Forms.Label();
            this.lbNombre2 = new System.Windows.Forms.Label();
            this.lbOperation = new System.Windows.Forms.Label();
            this.nupNombre1 = new System.Windows.Forms.NumericUpDown();
            this.nupNombre2 = new System.Windows.Forms.NumericUpDown();
            this.dupOperation = new System.Windows.Forms.DomainUpDown();
            this.btResulltat = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvAffichage = new System.Windows.Forms.TreeView();
            this.lstAffichage = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tpCalcul.SuspendLayout();
            this.tpAffichage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNombre1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNombre2)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCalcul);
            this.tabControl1.Controls.Add(this.tpAffichage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 261);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpCalcul
            // 
            this.tpCalcul.Controls.Add(this.txtResultat);
            this.tpCalcul.Controls.Add(this.btResulltat);
            this.tpCalcul.Controls.Add(this.dupOperation);
            this.tpCalcul.Controls.Add(this.nupNombre2);
            this.tpCalcul.Controls.Add(this.nupNombre1);
            this.tpCalcul.Controls.Add(this.lbOperation);
            this.tpCalcul.Controls.Add(this.lbNombre2);
            this.tpCalcul.Controls.Add(this.lbNombre1);
            this.tpCalcul.Location = new System.Drawing.Point(4, 22);
            this.tpCalcul.Name = "tpCalcul";
            this.tpCalcul.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalcul.Size = new System.Drawing.Size(276, 235);
            this.tpCalcul.TabIndex = 0;
            this.tpCalcul.Text = "Calcul";
            this.tpCalcul.UseVisualStyleBackColor = true;
            // 
            // tpAffichage
            // 
            this.tpAffichage.Controls.Add(this.splitContainer1);
            this.tpAffichage.Location = new System.Drawing.Point(4, 22);
            this.tpAffichage.Name = "tpAffichage";
            this.tpAffichage.Padding = new System.Windows.Forms.Padding(3);
            this.tpAffichage.Size = new System.Drawing.Size(276, 235);
            this.tpAffichage.TabIndex = 1;
            this.tpAffichage.Text = "Affichage";
            this.tpAffichage.UseVisualStyleBackColor = true;
            // 
            // lbNombre1
            // 
            this.lbNombre1.AutoSize = true;
            this.lbNombre1.Location = new System.Drawing.Point(20, 15);
            this.lbNombre1.Name = "lbNombre1";
            this.lbNombre1.Size = new System.Drawing.Size(56, 13);
            this.lbNombre1.TabIndex = 0;
            this.lbNombre1.Text = "Nombre 1:";
            // 
            // lbNombre2
            // 
            this.lbNombre2.AutoSize = true;
            this.lbNombre2.Location = new System.Drawing.Point(21, 43);
            this.lbNombre2.Name = "lbNombre2";
            this.lbNombre2.Size = new System.Drawing.Size(56, 13);
            this.lbNombre2.TabIndex = 1;
            this.lbNombre2.Text = "Nombre 2:";
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Location = new System.Drawing.Point(19, 73);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(53, 13);
            this.lbOperation.TabIndex = 2;
            this.lbOperation.Text = "Operation";
            // 
            // nupNombre1
            // 
            this.nupNombre1.Location = new System.Drawing.Point(133, 12);
            this.nupNombre1.Name = "nupNombre1";
            this.nupNombre1.Size = new System.Drawing.Size(120, 20);
            this.nupNombre1.TabIndex = 4;
            this.nupNombre1.ValueChanged += new System.EventHandler(this.nupNombre1_ValueChanged);
            // 
            // nupNombre2
            // 
            this.nupNombre2.Location = new System.Drawing.Point(135, 40);
            this.nupNombre2.Name = "nupNombre2";
            this.nupNombre2.Size = new System.Drawing.Size(120, 20);
            this.nupNombre2.TabIndex = 5;
            this.nupNombre2.ValueChanged += new System.EventHandler(this.nupNombre2_ValueChanged);
            // 
            // dupOperation
            // 
            this.dupOperation.Items.Add("+");
            this.dupOperation.Items.Add("-");
            this.dupOperation.Items.Add("*");
            this.dupOperation.Items.Add("/");
            this.dupOperation.Location = new System.Drawing.Point(134, 71);
            this.dupOperation.Name = "dupOperation";
            this.dupOperation.Size = new System.Drawing.Size(120, 20);
            this.dupOperation.TabIndex = 6;
            this.dupOperation.Text = "+";
            this.dupOperation.SelectedItemChanged += new System.EventHandler(this.dupOperation_SelectedItemChanged);
            // 
            // btResulltat
            // 
            this.btResulltat.Location = new System.Drawing.Point(21, 113);
            this.btResulltat.Name = "btResulltat";
            this.btResulltat.Size = new System.Drawing.Size(75, 23);
            this.btResulltat.TabIndex = 7;
            this.btResulltat.Text = "Résultat";
            this.btResulltat.UseVisualStyleBackColor = true;
            this.btResulltat.Click += new System.EventHandler(this.btResulltat_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(133, 111);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(100, 20);
            this.txtResultat.TabIndex = 8;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvAffichage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstAffichage);
            this.splitContainer1.Size = new System.Drawing.Size(270, 229);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvAffichage
            // 
            this.tvAffichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvAffichage.Location = new System.Drawing.Point(0, 0);
            this.tvAffichage.Name = "tvAffichage";
            this.tvAffichage.Size = new System.Drawing.Size(90, 229);
            this.tvAffichage.TabIndex = 0;
            this.tvAffichage.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAffichage_AfterSelect);
            // 
            // lstAffichage
            // 
            this.lstAffichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAffichage.Location = new System.Drawing.Point(0, 0);
            this.lstAffichage.Name = "lstAffichage";
            this.lstAffichage.Size = new System.Drawing.Size(176, 229);
            this.lstAffichage.TabIndex = 0;
            this.lstAffichage.UseCompatibleStateImageBehavior = false;
            // 
            // frLabo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "frLabo1";
            this.Text = "Laboratoire1";
            this.Load += new System.EventHandler(this.frLabo1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpCalcul.ResumeLayout(false);
            this.tpCalcul.PerformLayout();
            this.tpAffichage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupNombre1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNombre2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCalcul;
        private System.Windows.Forms.TabPage tpAffichage;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button btResulltat;
        private System.Windows.Forms.DomainUpDown dupOperation;
        private System.Windows.Forms.NumericUpDown nupNombre2;
        private System.Windows.Forms.NumericUpDown nupNombre1;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.Label lbNombre2;
        private System.Windows.Forms.Label lbNombre1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvAffichage;
        private System.Windows.Forms.ListView lstAffichage;
    }
}

