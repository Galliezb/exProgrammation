using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_window_control_03 {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
            dudProduit.Items.Add( "Citron" );
            dudProduit.Items.Add( "Pomme" );
            dudProduit.Items.Add( "Poire" );
            dudProduit.Items.Add( "Orange" );
            dudProduit.Sorted = true;
            dudProduit.SelectedItem = dudProduit.Items[0];

            for ( int i = 10; i>0; i-- ) {

                dudQuantite.Items.Add( i.ToString() );

            }
            dudQuantite.Sorted = false;
            dudQuantite.SelectedIndex = 9;

        }

        private void Form1_Load ( object sender , EventArgs e ) {

        }

        private void dudProduit_SelectedItemChanged ( object sender , EventArgs e ) {

        }

        private void checkBox1_CheckedChanged ( object sender , EventArgs e ) {

            if ( cbMultiLigne.Checked ) {

                lbGauche.SelectionMode = SelectionMode.MultiExtended;
                lbDroite.SelectionMode = SelectionMode.MultiExtended;

            } else {

                lbGauche.SelectionMode = SelectionMode.One;
                lbDroite.SelectionMode = SelectionMode.One;

            }

        }

        private void buAjouter_Click ( object sender , EventArgs e ) {

            lbGauche.Items.Add( dudProduit.SelectedItem.ToString() + " ( " + dudQuantite.SelectedItem.ToString() + " ) " );

        }

        private void buVider_Click ( object sender , EventArgs e ) {

            DialogResult textBoxResult = MessageBox.Show( this ,
                            "Voulez-vous vraiment vider la liste de gauche ?" ,
                            "Confirmation de suppression" ,
                            MessageBoxButtons.YesNo);

            if ( textBoxResult == DialogResult.Yes ) {

                lbGauche.Items.Clear();

            }




        }

        private void buSupprimer_Click ( object sender , EventArgs e ) {

            if ( lbGauche.SelectedIndex > 0 ) {

                lbGauche.ClearSelected();

            } else {

                MessageBox.Show( "Veuillez sélectionner minimum un objet dans la liste de gauche pour le supprimer." );

            }

        }

        private void buDroite_Click ( object sender , EventArgs e ) {

            if ( lbGauche.SelectedIndex > -1 ) {

                for ( int i =0; i <= lbGauche.SelectedItems.Count; i++ ) {

                    if ( lbGauche.SelectedItem != null ) {

                        MessageBox.Show( lbGauche.SelectedItem.ToString()
                                         + " / " +
                                         lbGauche.Items.IndexOf( lbGauche.SelectedItem.ToString() )
                                         + " / " +
                                         lbGauche.SelectedItems.Count.ToString()
                                         );
                        // recupère la valeur
                        string str = lbGauche.SelectedItem.ToString();
                        // recupère l'indice
                        int indice = lbGauche.Items.IndexOf( lbGauche.SelectedItem.ToString() );
                        // ajoute l'objet dans la listbox de droite
                        lbDroite.Items.Add( str );
                        // supprime la valeur de la listbox de gauche
                        lbGauche.Items.RemoveAt( indice );

                        // que deviens le selected ?

                    } else {

                        MessageBox.Show( "lbGauche.SelectedItem == null" );

                    }

                }
                
            }

        }

        private void buToutDroite_Click ( object sender , EventArgs e ) {
            if ( lbGauche.SelectedIndex > -1 ) {
                lbDroite.Items.Add( lbGauche.Items.ToString() );
                lbGauche.Items.Clear();
            }

        }

        private void buGauche_Click ( object sender , EventArgs e ) {
            if ( lbDroite.SelectedIndex > -1 ) {
                lbGauche.Items.Add( lbDroite.SelectedItems.ToString() );
                lbDroite.SelectedItems.Clear();
            }
        }

        private void buToutGauche_Click ( object sender , EventArgs e ) {
            if ( lbDroite.SelectedIndex > -1 ) {
                lbGauche.Items.Add( lbDroite.Items.ToString() );
                lbDroite.Items.Clear();
            }

        }
    }
}
