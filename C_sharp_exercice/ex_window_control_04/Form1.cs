using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace ex_window_control_04 {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();

            this.monpanel.AutoScroll = true;

        }

        private void label1_Click ( object sender , EventArgs e ) {

        }

        private void rotate__ ( object sender , EventArgs e ) {

            // cast le sender pour récupérer le controle de la pictureBox
            PictureBox pictureBox1 = (PictureBox) sender;

            // ROTATION
            Image flipImage =  pictureBox1.Image;
            flipImage.RotateFlip( RotateFlipType.Rotate180FlipX );
            pictureBox1.Image = flipImage;
        }

        private void lbGenerer_Click ( object sender , EventArgs e ) {

            int lignes, colonnes;
            lignes = Convert.ToInt32(nbligne.Text);
            colonnes = Convert.ToInt32( nbcolonne.Text );

            if (  lignes < 1 || lignes  > 10 || colonnes > 10 || colonnes < 1 ) {

                MessageBox.Show( "Veuillez entrer un chiffre entre 1 et 10 svp" );

            } else {

                int cpt = 0,cpt2=0;
                for( int i = 0; i < lignes; i++ ) {
                    for ( int j = 0; j < colonnes; j++ ) {

                        

                        PictureBox tmp = new PictureBox();
                        
                        // permet de dessiner dans un panel, c'est cool mais useless pour cet exo
                        //Graphics tmpG = monpanel.CreateGraphics();
                        //ctrlImage.Draw( tmpG  , new Point( i * 85 , j * 45 ) , cpt );
                        //tmpG.DrawImage( ctrlImage.Images[cpt] , new Point( i * 85 , j * 45 ) );
                        
                        tmp.Image = ctrlImage.Images[cpt];
                        tmp.Location = new Point( i * 85 , j * 45 );
                        tmp.Width = 75;
                        tmp.Height = 35;
                        tmp.Visible = true;
                        tmp.Size = new Size( 75 , 35 );
                        tmp.BackColor = Color.Red;
                        tmp.Name = "pb" + cpt2;

                        monpanel.Controls.Add( tmp );

                        cpt++;
                        cpt2++;
                        if ( cpt > 3 ) { cpt = 0; }
                        tmp.MouseClick += new MouseEventHandler( rotate__ );
                    }
                }

            }


        }

        private void textBox1_TextChanged ( object sender , EventArgs e ) {

        }

        private void Form1_Load ( object sender , EventArgs e ) {

        }

    }
}
