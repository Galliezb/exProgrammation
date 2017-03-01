namespace ex_window_control_05 {
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.D_tbhorizontal = new System.Windows.Forms.TrackBar();
            this.D_tbVertical = new System.Windows.Forms.TrackBar();
            this.D_lb1 = new System.Windows.Forms.Label();
            this.D_lb2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.D_tbhorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_tbVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(2, 481);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(676, 17);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Value = 15;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(661, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 418);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Value = 15;
            // 
            // D_tbhorizontal
            // 
            this.D_tbhorizontal.LargeChange = 10;
            this.D_tbhorizontal.Location = new System.Drawing.Point(2, 433);
            this.D_tbhorizontal.Maximum = 25;
            this.D_tbhorizontal.Minimum = 15;
            this.D_tbhorizontal.Name = "D_tbhorizontal";
            this.D_tbhorizontal.Size = new System.Drawing.Size(676, 45);
            this.D_tbhorizontal.TabIndex = 2;
            this.D_tbhorizontal.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.D_tbhorizontal.Value = 15;
            // 
            // D_tbVertical
            // 
            this.D_tbVertical.LargeChange = 10;
            this.D_tbVertical.Location = new System.Drawing.Point(601, 12);
            this.D_tbVertical.Maximum = 25;
            this.D_tbVertical.Minimum = 15;
            this.D_tbVertical.Name = "D_tbVertical";
            this.D_tbVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.D_tbVertical.Size = new System.Drawing.Size(45, 415);
            this.D_tbVertical.TabIndex = 3;
            this.D_tbVertical.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.D_tbVertical.Value = 15;
            this.D_tbVertical.Scroll += new System.EventHandler(this.D_tbVertical_Scroll);
            // 
            // D_lb1
            // 
            this.D_lb1.AutoSize = true;
            this.D_lb1.Location = new System.Drawing.Point(100, 51);
            this.D_lb1.Name = "D_lb1";
            this.D_lb1.Size = new System.Drawing.Size(35, 13);
            this.D_lb1.TabIndex = 4;
            this.D_lb1.Text = "label1";
            // 
            // D_lb2
            // 
            this.D_lb2.AutoSize = true;
            this.D_lb2.Location = new System.Drawing.Point(103, 84);
            this.D_lb2.Name = "D_lb2";
            this.D_lb2.Size = new System.Drawing.Size(35, 13);
            this.D_lb2.TabIndex = 5;
            this.D_lb2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 510);
            this.Controls.Add(this.D_lb2);
            this.Controls.Add(this.D_lb1);
            this.Controls.Add(this.D_tbVertical);
            this.Controls.Add(this.D_tbhorizontal);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.D_tbhorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_tbVertical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TrackBar D_tbhorizontal;
        private System.Windows.Forms.TrackBar D_tbVertical;
        private System.Windows.Forms.Label D_lb1;
        private System.Windows.Forms.Label D_lb2;
    }
}

