using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_window_control_01 {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }

        private void txtLitre_MaskInputRejected ( object sender , MaskInputRejectedEventArgs e ) {

        }

        private void ajouter_Click ( object sender , EventArgs e ) {


            if ( this.txtLitre.Text.ToString() != "" ) {

                int recup;
                int.TryParse( this.txtLitre.Text.ToString() , out recup );
                double metreCube = (double) recup / 1000;

                this.txtSave.AppendText( recup + " / " + metreCube.ToString() + "\n" );

            } else if ( this.txtMetreCube.Text.ToString() != "" ) {

                double recup;
                double.TryParse( this.txtMetreCube.Text.ToString() , out recup );
                double litre = (double) recup * 1000;

                this.txtSave.AppendText( recup + " / " + litre.ToString() + "\n" );

            }

            

        }

        private void conversion_Click ( object sender , EventArgs e ) {

            //  SI les litres sont non null, conversion en metre cubes
            if ( this.txtLitre.Text.ToString() != "" ) {

                // verification de la conversion en litre
                int recup;
                int.TryParse( this.txtLitre.Text.ToString() , out recup );
                if ( recup < 1000 ) {

                    MessageBox.Show( this ,
                                    "Erreur : Le nombre de litre doit être compris en 1.000 et 9.999.999" ,
                                    "Erreur"
                                    );

                } else {

                    double metreCube = (double)recup / 1000;
                    this.txtMetreCube.Text = metreCube.ToString();
                    this.txtLitre.Text = "";
                    this.txtMetreCube.Focus(    );

                }

                // sinon conversion metre cube en litre si possible
            } else if ( this.txtMetreCube.Text.ToString() != "" ) {

                double recup;
                double.TryParse( this.txtMetreCube.Text.ToString() , out recup );

                double retour = recup * 1000;
                this.txtLitre.Text = retour.ToString();

                this.txtMetreCube.Text = "";
                this.txtLitre.Focus();

            }

        }

        private void sauver_Click ( object sender , EventArgs e ) {

            string[] lines = txtSave.Lines;
            txtSave.SaveFile( "C:\\Bruno\\exProgrammation\\C_sharp_exercice\\ex_window_control_01.txt" );

            this.lbOuvrirFichier.Enabled = Enabled;
            this.lbOuvrirFichier.DataBindings

        }
    }
}
