namespace security_test {
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
            this.myRadioButton1 = new System.Windows.Forms.RadioButton();
            this.myRadioButton2 = new System.Windows.Forms.RadioButton();
            this.myRadioButton3 = new System.Windows.Forms.RadioButton();
            this.myRadioButton4 = new System.Windows.Forms.RadioButton();
            this.myButtonNext = new System.Windows.Forms.Button();
            this.myButtonSend = new System.Windows.Forms.Button();
            this.myLabel = new System.Windows.Forms.Label();
            this.myLabelAvancement = new System.Windows.Forms.Label();
            this.myButtonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myRadioButton1
            // 
            this.myRadioButton1.AutoSize = true;
            this.myRadioButton1.Location = new System.Drawing.Point(42, 115);
            this.myRadioButton1.Name = "myRadioButton1";
            this.myRadioButton1.Size = new System.Drawing.Size(132, 22);
            this.myRadioButton1.TabIndex = 0;
            this.myRadioButton1.TabStop = true;
            this.myRadioButton1.Text = "radioButton1";
            this.myRadioButton1.UseVisualStyleBackColor = true;
            // 
            // myRadioButton2
            // 
            this.myRadioButton2.AutoSize = true;
            this.myRadioButton2.Location = new System.Drawing.Point(42, 165);
            this.myRadioButton2.Name = "myRadioButton2";
            this.myRadioButton2.Size = new System.Drawing.Size(132, 22);
            this.myRadioButton2.TabIndex = 1;
            this.myRadioButton2.TabStop = true;
            this.myRadioButton2.Text = "radioButton2";
            this.myRadioButton2.UseVisualStyleBackColor = true;
            // 
            // myRadioButton3
            // 
            this.myRadioButton3.AutoSize = true;
            this.myRadioButton3.Location = new System.Drawing.Point(42, 215);
            this.myRadioButton3.Name = "myRadioButton3";
            this.myRadioButton3.Size = new System.Drawing.Size(132, 22);
            this.myRadioButton3.TabIndex = 2;
            this.myRadioButton3.TabStop = true;
            this.myRadioButton3.Text = "radioButton3";
            this.myRadioButton3.UseVisualStyleBackColor = true;
            // 
            // myRadioButton4
            // 
            this.myRadioButton4.AutoSize = true;
            this.myRadioButton4.Location = new System.Drawing.Point(42, 265);
            this.myRadioButton4.Name = "myRadioButton4";
            this.myRadioButton4.Size = new System.Drawing.Size(132, 22);
            this.myRadioButton4.TabIndex = 3;
            this.myRadioButton4.TabStop = true;
            this.myRadioButton4.Text = "radioButton4";
            this.myRadioButton4.UseVisualStyleBackColor = true;
            // 
            // myButtonNext
            // 
            this.myButtonNext.Location = new System.Drawing.Point(489, 354);
            this.myButtonNext.Name = "myButtonNext";
            this.myButtonNext.Size = new System.Drawing.Size(132, 46);
            this.myButtonNext.TabIndex = 5;
            this.myButtonNext.Text = "Suivant";
            this.myButtonNext.UseVisualStyleBackColor = true;
            this.myButtonNext.Click += new System.EventHandler(this.myButtonNext_Click);
            // 
            // myButtonSend
            // 
            this.myButtonSend.Location = new System.Drawing.Point(489, 354);
            this.myButtonSend.Name = "myButtonSend";
            this.myButtonSend.Size = new System.Drawing.Size(132, 46);
            this.myButtonSend.TabIndex = 7;
            this.myButtonSend.Text = "Envoyer";
            this.myButtonSend.UseVisualStyleBackColor = true;
            this.myButtonSend.Click += new System.EventHandler(this.myButtonSend_Click);
            // 
            // myLabel
            // 
            this.myLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.myLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabel.Location = new System.Drawing.Point(0, 0);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(633, 95);
            this.myLabel.TabIndex = 8;
            this.myLabel.Text = "label1";
            this.myLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myLabelAvancement
            // 
            this.myLabelAvancement.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLabelAvancement.Location = new System.Drawing.Point(150, 354);
            this.myLabelAvancement.Name = "myLabelAvancement";
            this.myLabelAvancement.Size = new System.Drawing.Size(333, 49);
            this.myLabelAvancement.TabIndex = 9;
            this.myLabelAvancement.Text = "1 / 7";
            this.myLabelAvancement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myLabelAvancement.Click += new System.EventHandler(this.label1_Click);
            // 
            // myButtonResult
            // 
            this.myButtonResult.Location = new System.Drawing.Point(12, 357);
            this.myButtonResult.Name = "myButtonResult";
            this.myButtonResult.Size = new System.Drawing.Size(132, 46);
            this.myButtonResult.TabIndex = 10;
            this.myButtonResult.Text = "Résultats";
            this.myButtonResult.UseVisualStyleBackColor = true;
            this.myButtonResult.Click += new System.EventHandler(this.myButtonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 412);
            this.Controls.Add(this.myButtonResult);
            this.Controls.Add(this.myLabelAvancement);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myButtonNext);
            this.Controls.Add(this.myRadioButton4);
            this.Controls.Add(this.myRadioButton3);
            this.Controls.Add(this.myRadioButton2);
            this.Controls.Add(this.myRadioButton1);
            this.Controls.Add(this.myButtonSend);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Enquête sur la sécurité";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton myRadioButton1;
        private System.Windows.Forms.RadioButton myRadioButton2;
        private System.Windows.Forms.RadioButton myRadioButton3;
        private System.Windows.Forms.RadioButton myRadioButton4;
        private System.Windows.Forms.Button myButtonNext;
        private System.Windows.Forms.Button myButtonSend;
        private System.Windows.Forms.Label myLabel;
        private System.Windows.Forms.Label myLabelAvancement;
        private System.Windows.Forms.Button myButtonResult;
    }
}

