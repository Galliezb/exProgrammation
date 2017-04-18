namespace security_test {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.myButtonNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myButtonNext
            // 
            this.myButtonNext.Location = new System.Drawing.Point(195, 335);
            this.myButtonNext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.myButtonNext.Name = "myButtonNext";
            this.myButtonNext.Size = new System.Drawing.Size(220, 64);
            this.myButtonNext.TabIndex = 6;
            this.myButtonNext.Text = "Résultats";
            this.myButtonNext.UseVisualStyleBackColor = true;
            this.myButtonNext.Click += new System.EventHandler(this.myButtonNext_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 322);
            this.label1.TabIndex = 7;
            this.label1.Text = "Merci pour votre participation à ce sondage ;)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myButtonNext);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myButtonNext;
        private System.Windows.Forms.Label label1;
    }
}