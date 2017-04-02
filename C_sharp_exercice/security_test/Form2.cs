using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace security_test {
    public partial class Form2 : Form {

        Form1 leForm1;

        public Form2 (Form1 f1) {
            InitializeComponent();

            leForm1 = f1;

        }

        private void myButtonNext_Click ( object sender , EventArgs e ) {

            // ferme form1 lorsque l'on fermera form2
            this.Hide();
            Form3 resultat = new Form3(leForm1);
            resultat.ShowDialog();
            this.Close();

        }

        private void Form2_Load ( object sender , EventArgs e ) {

            // meme taille que form1
            this.Size = new Size( leForm1.Width , leForm1.Height );

            // centre le form à l'écran
            int posX = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            int posY = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
            this.Location = new Point( posX , posY );

        }
    }
}
