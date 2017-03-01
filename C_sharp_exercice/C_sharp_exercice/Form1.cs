using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace WindowsFormsApplication1 {
    public partial class frInfoPays : Form {
        string pays, capitale;
        string[] tcapitale;
        int cpt;
        int sec;

        public frInfoPays () {
            InitializeComponent();
            /*
            // no rezize dude !
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            // center
            this.StartPosition = FormStartPosition.CenterScreen;
            */
        }

        private void frInfoPays_Load ( object sender , EventArgs e ) {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            int pos;
            tcapitale = new string[10];
            pos = cbPays.Items.Add( "Allemagne" );
            tcapitale[pos] = "Berlin";
            pos = cbPays.Items.Add( "Belgique" );
            tcapitale[pos] = "Bruxelles";
            pos = cbPays.Items.Add( "Chine" );
            tcapitale[pos] = "Pékin";
            pos = cbPays.Items.Add( "Egypte" );
            tcapitale[pos] = "Le Caire";
            pos = cbPays.Items.Add( "France" );
            tcapitale[pos] = "Paris";
            pos = cbPays.Items.Add( "Italie" );
            tcapitale[pos] = "Rome";
            pos = cbPays.Items.Add( "Maroc" );
            tcapitale[pos] = "Rabat";
            pos = cbPays.Items.Add( "Roumanie" );
            tcapitale[pos] = "Bugarest";
            pos = cbPays.Items.Add( "Rwanda" );
            tcapitale[pos] = "Kigali";
            //exercice 1 c
            lbDateJour.ForeColor = Color.Green;
            FontStyle style = FontStyle.Bold | FontStyle.Italic;
            Font f = new Font( "Microsoft Sans Serif" , 14 , style );
            lbDateJour.Font = f;
            //afficher date et heure du jour
            DateTime dt;
            dt = DateTime.Now;
            string msg;
            msg = "Date " + dt.ToString( "d" );
            lbDateJour.Text = msg;
            msg = dt.ToString( "t" );
            lbHeureCourante.Text = msg;

            //exercice 1 b
            btOK.ForeColor = Color.White;
            btOK.BackColor = Color.Blue;

            //exercice 1 e
            sec = 0;
            lbTempsEcoule.Text = sec.ToString();

            //exercice 1 f)
            cbPays.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void tiHorloge_Tick ( object sender , EventArgs e ) {
            string msg;
            DateTime dt;
            dt = DateTime.Now;
            msg = dt.ToString( "ty" );
            lbHeureCourante.Text = msg;
            /*
            CultureInfo arSY = new CultureInfo( "fr-FR" );
            arSY.DateTimeFormat.Calendar = new GregorianCalendar();
            */
            //Exercice 1 e)
            sec += 1;
            lbTempsEcoule.Text = sec.ToString();
        }

        private void cbPays_SelectedIndexChanged ( object sender , EventArgs e ) {
            pays = cbPays.SelectedItem.ToString();
            capitale = tcapitale[cbPays.SelectedIndex];
            pbDrapeau.Image = null;
            lbErreur.Text = "";
            cpt = 0;
        }

        private void btOK_Click ( object sender , EventArgs e ) {
            string nom;
            nom = pays + ".bmp";
            nom = nom.ToLower();
            lbErreur.Text = "";
            if ( ( txtCapitale.Text != "" ) && ( txtCapitale.Text == capitale ) ) {
                nom = Application.StartupPath + "\\drapeaux\\" + nom;
                if ( File.Exists( nom ) == true ) {
                    pbDrapeau.Image = Image.FromFile( nom );
                } else {
                    MessageBox.Show( "Fichier n'existe pas!!" );
                }
            } else {
                if ( cpt == 1 ) this.Close();
                else {
                    lbErreur.ForeColor = Color.Red;
                    lbErreur.Text = "Vous avez droit à une deuxième réponse";
                    txtCapitale.Focus();
                }
                cpt += 1;
            }
        }

        private void button1_Click ( object sender , EventArgs e ) {
            txtCapitale.Text = "";
            lbErreur.Text = "";
            pbDrapeau.Image = null;
            cbPays.Text = cbPays.Items[0].ToString();
        }

        private void pbDrapeau_Click ( object sender , EventArgs e ) {

        }

        private void btChoisir_Click ( object sender , EventArgs e ) {
            int ind;
            Random rnd = new Random();
            ind = rnd.Next( 0 , 9 );
            txtCapitale.Text = tcapitale[ind];
        }
    }
}
