using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }

        private void label1_Click ( object sender , EventArgs e ) {

        }

        private void timer1_Tick ( object sender , EventArgs e ) {

            if ( this.Size.Width < 1000 ) {

               int newWidth = this.Size.Width + 2;
               this.Size = new Size( newWidth , this.Size.Height );
               monLabel.Width = newWidth;
               monLabel.Location = new Point( 0 , 10 );

                // log fenetre
                lbWidthLabel.Text = monLabel.Width.ToString();
                lbPosXLabel.Text = monLabel.Location.X.ToString();
                lbWidthWindow.Text = this.Width.ToString();


            }

        }

        private void label1_Click_1 ( object sender , EventArgs e ) {

        }

        private void Form1_Load ( object sender , EventArgs e ) {

        }
    }
}
