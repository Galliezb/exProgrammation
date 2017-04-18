using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_control {
    public partial class Form1 : Form {

        Quartier lesQuartiers = new Quartier();
        Logement lesLogement = new Logement();
        DataSet dsQuartier,dsLogement;

        public Form1 () {
            InitializeComponent();
        }

        private void label1_Click ( object sender , EventArgs e ) {

        }

        private void Form1_Load ( object sender , EventArgs e ) {


            dsQuartier = lesQuartiers.recupererQuartier();
            
            for ( int i = 0; i < dsQuartier.Tables["Quartier"].Columns.Count; i++ ) {

                //MessageBox.Show( dsQuartier.Tables["Quartier"].Rows[i]["Libellé"].ToString() );
                cbQuartier.Items.Add( dsQuartier.Tables["Quartier"].Rows[i]["Libellé"].ToString() );

            }


        }

        private void btNext_Click ( object sender , EventArgs e ) {
            lesLogement.suivant();
            monUpdate();
        }

        private void cbQuartier_SelectedIndexChanged ( object sender , EventArgs e ) {


            string name = cbQuartier.SelectedItem.ToString();
            dsLogement = lesLogement.recupererLogementParQuartier( name );

            monUpdate();


        }

        private void btBefore_Click ( object sender , EventArgs e ) {
            lesLogement.precedent();
            monUpdate();
        }

        private void btStart_Click ( object sender , EventArgs e ) {
            lesLogement.premier();
            monUpdate();
        }

        private void btEnd_Click ( object sender , EventArgs e ) {
            lesLogement.dernier();
            monUpdate();
        }

        private void btNouveau_Click ( object sender , EventArgs e ) {
            tbIentifiant.Text = "";
            tbType.Text = "";
            tbidQuartier.Text = "";
            tbNumero.Text = "";
            tbRue.Text = "";
            tbSuperficie.Text = "";
            tbLoyer.Text = "";
        }

        public void monUpdate () {

            tbIentifiant.Text = dsLogement.Tables["Logement"].Rows[lesLogement.indexParcouru]["NLogement"].ToString();
            tbType.Text = dsLogement.Tables["Logement"].Rows[lesLogement.indexParcouru]["TypeLogement"].ToString();
            tbidQuartier.Text = dsLogement.Tables["Logement"].Rows[lesLogement.indexParcouru]["idQuartier"].ToString();
            tbNumero.Text = dsLogement.Tables["Logement"].Rows[lesLogement.indexParcouru]["Numero"].ToString();
            tbRue.Text = dsLogement.Tables["Logement"].Rows[lesLogement.indexParcouru]["Rue"].ToString();
            tbSuperficie.Text = dsLogement.Tables["Logement"].Rows[lesLogement.indexParcouru]["Superficie"].ToString();
            tbLoyer.Text = dsLogement.Tables["Logement"].Rows[lesLogement.indexParcouru]["Loyer"].ToString();


        }
    }
}
