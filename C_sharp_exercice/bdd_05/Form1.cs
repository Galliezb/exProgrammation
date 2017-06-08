using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bdd_05 {
    public partial class Form1 : Form {

        // on va récupérer les info du fichier qu'on mets dans le dataset
        gestionTennisSQLDataSet ds = new gestionTennisSQLDataSet();
        //SqlDataAdapter sql_adapteur;
        SqlConnection sql_connection;
        SqlCommand sql_command;



        public Form1 () {
            InitializeComponent();

            sql_connection = new SqlConnection();
            sql_command = new SqlCommand();

        }

        private void lbAge_Click ( object sender , EventArgs e ) {

        }

        private void btCreation_Click ( object sender , EventArgs e ) {

            if ( !ds.Tables.Contains("directeur") ) {

                // créer la table directeur dans le dataset
                DataTable directeur = new DataTable( "Directeur" );

                // creation d'une colonne
                DataColumn col1 = new DataColumn( "id" , typeof( Int32 ) );
                // ajout dans la table
                directeur.Columns.Add( col1 );
                // met l'id en temps que clé primaire
                directeur.PrimaryKey = new DataColumn[] { directeur.Columns["id"] };

                // modification de la colonne et ajout dans la table à chaque fois
                DataColumn col2 = new DataColumn( "nom" , typeof( string ) );
                directeur.Columns.Add( col2 );

                DataColumn col3 = new DataColumn( "domaine" , typeof( string ) );
                directeur.Columns.Add( col3 );

                DataColumn col4 = new DataColumn( "age" , typeof( string ) );
                directeur.Columns.Add( col4 );

                // ajout de la table directeur dans le dataset
                ds.Tables.Add( directeur );

                // affiche les textebox et les labels
                lbIdentifiant.Visible = true;
                lbNom.Visible = true;
                lbDomaine.Visible = true;
                lbAge.Visible = true;

                tbIdentifiant.Visible = true;
                tbNom.Visible = true;
                tbDomaine.Visible = true;
                tbAge.Visible = true;

                // desactive le bouton creation
                btCreation.Enabled = false;
                btCreation.ForeColor = Color.LightGray;

            } else {
                lbError.Text = "Le Dataset contient déjà un table directeur.";
            }

        }

        private void btAjout_Click ( object sender , EventArgs e ) {

            int id;
            bool isNumeric = int.TryParse( tbIdentifiant.Text , out id );

            int age;
            bool isNumeric2 = int.TryParse( tbIdentifiant.Text , out age );

            if ( !isNumeric || ds.Tables["directeur"].Rows.Contains( id ) ) {
                lbError.Text = "L'identifiant doit être un chiffre unique dans la BDD";
            } else if ( !isNumeric ) {
                lbError.Text = "L'âge doit être numeric";
            } else if ( tbNom.Text.Length < 2 ) {
                lbError.Text = "Le nom doit avoir plus de 2 caractères";
            } else if ( tbDomaine.Text.Length < 2 ) {
                lbError.Text = "Le domaine doit avoir plus de 2 caractères";
            } else {

                try {

                    // recupère la structure de la table directeur
                    DataRow ligne = ds.Tables["directeur"].NewRow();
                    // insert les futurs valeurs inséré
                    ligne["id"] = tbIdentifiant.Text;
                    ligne["nom"] = tbNom.Text;
                    ligne["domaine"] = tbDomaine.Text;
                    ligne["age"] = tbAge.Text;
                    // ajoute la ligne de donnée dans le dataset de la table directeur
                    ds.Tables["directeur"].Rows.Add( ligne );

                    // connection SQL pour isertion
                    sql_connection.ConnectionString = Properties.Settings.Default.gestionTennisConnectionToSqlServer;
                    if ( sql_connection.State != ConnectionState.Open ) {
                        sql_connection.Open();
                    }
                    //sql_adapteur.Fill();
                    

                } catch ( Exception error ) {

                    lbError.Text = error.ToString();

                }


            }

        }
    }
}
