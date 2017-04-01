namespace test {
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
            this.monLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbWidthLabel = new System.Windows.Forms.Label();
            this.lbPosXLabel = new System.Windows.Forms.Label();
            this.lbWidthWindow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monLabel
            // 
            this.monLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monLabel.Location = new System.Drawing.Point(0, 52);
            this.monLabel.Name = "monLabel";
            this.monLabel.Size = new System.Drawing.Size(489, 23);
            this.monLabel.TabIndex = 0;
            this.monLabel.Text = " Mon texte ultra long un truc de fou";
            this.monLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(55, 176);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(90, 17);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Width label : ";
            this.lb1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(58, 234);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(96, 17);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Pos X Label : ";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(58, 294);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(105, 17);
            this.lb3.TabIndex = 3;
            this.lb3.Text = "Width fenêtre : ";
            // 
            // lbWidthLabel
            // 
            this.lbWidthLabel.AutoSize = true;
            this.lbWidthLabel.Location = new System.Drawing.Point(218, 175);
            this.lbWidthLabel.Name = "lbWidthLabel";
            this.lbWidthLabel.Size = new System.Drawing.Size(46, 17);
            this.lbWidthLabel.TabIndex = 4;
            this.lbWidthLabel.Text = "label1";
            // 
            // lbPosXLabel
            // 
            this.lbPosXLabel.AutoSize = true;
            this.lbPosXLabel.Location = new System.Drawing.Point(218, 234);
            this.lbPosXLabel.Name = "lbPosXLabel";
            this.lbPosXLabel.Size = new System.Drawing.Size(46, 17);
            this.lbPosXLabel.TabIndex = 5;
            this.lbPosXLabel.Text = "label2";
            // 
            // lbWidthWindow
            // 
            this.lbWidthWindow.AutoSize = true;
            this.lbWidthWindow.Location = new System.Drawing.Point(218, 294);
            this.lbWidthWindow.Name = "lbWidthWindow";
            this.lbWidthWindow.Size = new System.Drawing.Size(46, 17);
            this.lbWidthWindow.TabIndex = 6;
            this.lbWidthWindow.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 589);
            this.Controls.Add(this.lbWidthWindow);
            this.Controls.Add(this.lbPosXLabel);
            this.Controls.Add(this.lbWidthLabel);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.monLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbWidthLabel;
        private System.Windows.Forms.Label lbPosXLabel;
        private System.Windows.Forms.Label lbWidthWindow;
    }
}

