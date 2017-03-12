namespace labo_01 {
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Addition");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Soustraction");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Multiplication");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Division");
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageCalcul = new System.Windows.Forms.TabPage();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.btResultat = new System.Windows.Forms.Button();
            this.udOperation = new System.Windows.Forms.DomainUpDown();
            this.udNombre2 = new System.Windows.Forms.NumericUpDown();
            this.udNombre1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pageAffichage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tw1 = new System.Windows.Forms.TreeView();
            this.listView = new System.Windows.Forms.ListView();
            this.tabControl.SuspendLayout();
            this.pageCalcul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNombre2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNombre1)).BeginInit();
            this.pageAffichage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageCalcul);
            this.tabControl.Controls.Add(this.pageAffichage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(100, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(933, 634);
            this.tabControl.TabIndex = 0;
            this.tabControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDoubleClick);
            // 
            // pageCalcul
            // 
            this.pageCalcul.AccessibleName = "";
            this.pageCalcul.Controls.Add(this.txtResultat);
            this.pageCalcul.Controls.Add(this.btResultat);
            this.pageCalcul.Controls.Add(this.udOperation);
            this.pageCalcul.Controls.Add(this.udNombre2);
            this.pageCalcul.Controls.Add(this.udNombre1);
            this.pageCalcul.Controls.Add(this.label3);
            this.pageCalcul.Controls.Add(this.label2);
            this.pageCalcul.Controls.Add(this.label1);
            this.pageCalcul.Location = new System.Drawing.Point(4, 29);
            this.pageCalcul.Name = "pageCalcul";
            this.pageCalcul.Padding = new System.Windows.Forms.Padding(3);
            this.pageCalcul.Size = new System.Drawing.Size(925, 601);
            this.pageCalcul.TabIndex = 0;
            this.pageCalcul.Text = "Calcul";
            this.pageCalcul.UseVisualStyleBackColor = true;
            this.pageCalcul.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(197, 414);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(120, 27);
            this.txtResultat.TabIndex = 15;
            // 
            // btResultat
            // 
            this.btResultat.Location = new System.Drawing.Point(60, 414);
            this.btResultat.Name = "btResultat";
            this.btResultat.Size = new System.Drawing.Size(88, 29);
            this.btResultat.TabIndex = 14;
            this.btResultat.Text = "Résultat";
            this.btResultat.UseVisualStyleBackColor = true;
            this.btResultat.Click += new System.EventHandler(this.btResultat_Click);
            // 
            // udOperation
            // 
            this.udOperation.Location = new System.Drawing.Point(197, 291);
            this.udOperation.Name = "udOperation";
            this.udOperation.Size = new System.Drawing.Size(120, 27);
            this.udOperation.TabIndex = 13;
            this.udOperation.Text = "domainUpDown1";
            this.udOperation.SelectedItemChanged += new System.EventHandler(this.udOperation_SelectedItemChanged);
            // 
            // udNombre2
            // 
            this.udNombre2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udNombre2.Location = new System.Drawing.Point(197, 175);
            this.udNombre2.Name = "udNombre2";
            this.udNombre2.Size = new System.Drawing.Size(120, 27);
            this.udNombre2.TabIndex = 12;
            // 
            // udNombre1
            // 
            this.udNombre1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udNombre1.Location = new System.Drawing.Point(197, 73);
            this.udNombre1.Name = "udNombre1";
            this.udNombre1.Size = new System.Drawing.Size(120, 27);
            this.udNombre1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Opération : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre 2 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre 1 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pageAffichage
            // 
            this.pageAffichage.BackColor = System.Drawing.Color.Transparent;
            this.pageAffichage.Controls.Add(this.splitContainer1);
            this.pageAffichage.ForeColor = System.Drawing.Color.Black;
            this.pageAffichage.Location = new System.Drawing.Point(4, 29);
            this.pageAffichage.Name = "pageAffichage";
            this.pageAffichage.Padding = new System.Windows.Forms.Padding(3);
            this.pageAffichage.Size = new System.Drawing.Size(925, 601);
            this.pageAffichage.TabIndex = 1;
            this.pageAffichage.Text = "Affichage";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tw1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView);
            this.splitContainer1.Size = new System.Drawing.Size(919, 595);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
            // 
            // tw1
            // 
            this.tw1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tw1.Location = new System.Drawing.Point(0, 0);
            this.tw1.Name = "tw1";
            treeNode1.Name = "nodeAddition";
            treeNode1.Text = "Addition";
            treeNode2.Name = "nodeSoustraction";
            treeNode2.Text = "Soustraction";
            treeNode3.Name = "nodeMultiplication";
            treeNode3.Text = "Multiplication";
            treeNode4.Name = "nodeDivision";
            treeNode4.Text = "Division";
            this.tw1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.tw1.Size = new System.Drawing.Size(306, 595);
            this.tw1.TabIndex = 0;
            this.tw1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tw1_AfterSelect);
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(609, 595);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 634);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.pageCalcul.ResumeLayout(false);
            this.pageCalcul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNombre2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNombre1)).EndInit();
            this.pageAffichage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageCalcul;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button btResultat;
        private System.Windows.Forms.DomainUpDown udOperation;
        private System.Windows.Forms.NumericUpDown udNombre2;
        private System.Windows.Forms.NumericUpDown udNombre1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage pageAffichage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tw1;
        private System.Windows.Forms.ListView listView;
    }
}

