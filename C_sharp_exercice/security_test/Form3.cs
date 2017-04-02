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
    public partial class Form3 : Form {

        Form1 leForm1;

        public Form3 ( Form1 f1 ) {
            InitializeComponent();
            leForm1 = f1;
        }

        private void Form3_Load ( object sender , EventArgs e ) {

            // meme taille que form1
            this.Size = new Size( leForm1.Width , leForm1.Height );

            // centre le form à l'écran
            int posX = Screen.PrimaryScreen.Bounds.Width / 2 - leForm1.Width / 2;
            int posY = Screen.PrimaryScreen.Bounds.Height / 2 - leForm1.Height / 2;
            this.Location = new Point( posX , posY );
        }

    }
}
