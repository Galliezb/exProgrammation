using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_exercice {

    public partial class formPays : Form {

        //string[] tCapitale = { "Berlin" , "Brussel" , "Paris" };
        //string capitale, pays;
        //int cpt = 0;

        public formPays () {
            InitializeComponent();
            // no rezize dude !
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            int widthBox = cbPays.Width;

                
            txtCapitale.Width = widthBox;

            buOk.Text = "Test";
            buOk.Width = widthBox;


        }

        private void Form1_MouseOver( object sender, EventArgs e) {

            int newX, newY, sizeScreenMaxX, sizeScreenMaxY;

            sizeScreenMaxX = Screen.PrimaryScreen.Bounds.Width;
            sizeScreenMaxY = Screen.PrimaryScreen.Bounds.Height;

            if ( this.Location.X < sizeScreenMaxX/2 ) {
                newX = new Random().Next( sizeScreenMaxX/2, sizeScreenMaxX - 375 );
            } else {
                newX = new Random().Next( 0 , sizeScreenMaxX / 2 - 375 );
            }

            if ( this.Location.Y < sizeScreenMaxY / 2 ) {
                newY = new Random().Next( sizeScreenMaxY/2 , sizeScreenMaxY-375 );
            } else {
                newY = new Random().Next( 0 , sizeScreenMaxY / 2 - 375 );
            }

            this.Location = new Point(newX,newY);
            //lbDate.Text = this.Location.X.ToString() + " / " + this.Location.Y.ToString();
            //lbHeure.Text = newX.ToString() + " / " + newY.ToString();

        }

        private void Form1_Load ( object sender , EventArgs e ) {

            //buOk.BackColor = Color.Blue;
            //buOk.ForeColor = Color.Red;
            //label

            //int pos;
            //tCapitale = new string[10];
            //tCapitale[]
            //cbPays[]

        }

        private void label1_Click ( object sender , EventArgs e ) {

        }

        private void comboBox1_SelectedIndexChanged ( object sender , EventArgs e ) {
            /*
            pays = cbPays.SelectedItem.ToString();
            capitale = tCapitale[cbPays.SelectedIndex];
            pbDrapeau.Image = null;
            lbErreur.Text = "TXT qu'on souhaite";
            */
        }

        private void tiHorloge_Tick ( object sender , EventArgs e ) {
            /*
            DateTime dt;
            dt = DateTime.Now;
            string msg;
            msg = "Date : " + dt.ToString();
            lbDate.Text = msg;
            */
        }

        private void buOk_Click ( object sender , EventArgs e ) {
            /*
            string nom;
            nom = pays + ".bmp";
            nom = nom.ToLower();
            lbErreur.Text = "";
            if ( txtCapitale.Text != "" && txtCapitale.Text == capitale ) {
                pbDrapeau.Image = Image.FromFile( Application.StartupPath+"\\drapeaux\\"+ nom );
            } else {

                if ( cpt == 1 ) {
                    this.Close();
                } else {
                    lbErreur.ForeColor = Color.Red;
                    lbErreur.Text = "Vous avez le droit a une deuxième réponse";
                    txtCapitale.Focus();
                }

            }
            */
        }

        private void lbHeure_Click ( object sender , EventArgs e ) {
            /*
            DateTime dt;
            dt = DateTime.Now;
            string msg;
            msg = "Date : " + dt.ToString();
            lbDate.Text = msg;
            */
        }

        private void tbCapitale_TextChanged ( object sender , EventArgs e ) {
            /*
            capitale = txtCapitale.Text.ToString();
            */
        }
    }
}
