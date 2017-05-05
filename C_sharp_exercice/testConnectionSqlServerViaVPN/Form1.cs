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

namespace testConnectionSqlServerViaVPN {
    public partial class Form1 : Form {

        SqlConnection connectionSql;
        SqlCommand commandeSql;
        SqlDataReader dataReaderSql;

        public Form1 () {
            InitializeComponent();

            // instance dans les variables
            connectionSql = new SqlConnection();
            commandeSql = new SqlCommand();

            // envoyer les paramètres des propriété pour la connection
            connectionSql.ConnectionString = Properties.Settings.Default.maConnexionSqlServer;


        }

        private void Form1_Load ( object sender , EventArgs e ) {

            // ouverture connexion
            connectionSql.Open();

            string request = "select * from test";
            commandeSql.CommandType = CommandType.Text;
            commandeSql.CommandText = request;
            commandeSql.Connection = connectionSql;

            //datareader
            dataReaderSql = commandeSql.ExecuteReader();
            while ( dataReaderSql.Read() ) {
                MessageBox.Show( "Id : " + dataReaderSql["id_"].ToString() + " et text :  " + dataReaderSql["text_"].ToString() );
            }

            // fermeture connexion
            connectionSql.Close();


        }
    }
}
