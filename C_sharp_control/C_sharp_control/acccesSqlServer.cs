using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace C_sharp_control {
    class acccesSqlServer {

        //pour sqlclient
        SqlConnection connectionSqlServer;
        SqlCommand commmandeSqlServer;
        SqlDataReader ReaderSqlServer;
        SqlDataAdapter monSqlAdapter;

        public acccesSqlServer () {

            connectionSqlServer = new SqlConnection();
            commmandeSqlServer = new SqlCommand();
            connectionSqlServer.ConnectionString = Properties.Settings.Default.AdministrationCommunaleConnectionString;

        }

        public DataSet recupereQuartier () {

            connectionSqlServer.Open();

            monSqlAdapter = new SqlDataAdapter( "SELECT * FROM Quartier" , connectionSqlServer );
            DataSet sqlDs = new DataSet();
            monSqlAdapter.Fill( sqlDs , "Quartier");


            connectionSqlServer.Close();

            return sqlDs;

        }

        public int recupereIdQuartier (string name) {

            connectionSqlServer.Open();
            
            commmandeSqlServer.CommandType = CommandType.Text;
            commmandeSqlServer.CommandText = "SELECT idQuartier FROM Quartier WHERE nom='"+ name + "'";
            commmandeSqlServer.Connection = connectionSqlServer;
            ReaderSqlServer = commmandeSqlServer.ExecuteReader();


            connectionSqlServer.Close();

            return (int) ReaderSqlServer[0];
        }

        public DataSet recupererLogementParQuartier ( string name ) {

            connectionSqlServer.Open();

            monSqlAdapter = new SqlDataAdapter( "SELECT * FROM Logement WHERE idQuartier=(SELECT idQuartier FROM Quartier WHERE libellé='"+name+"')" , connectionSqlServer );
            //monSqlAdapter = new SqlDataAdapter( "SELECT * FROM Logement WHERE idQuartier=1" , connectionSqlServer );
            DataSet sqlDs = new DataSet();
            monSqlAdapter.Fill( sqlDs , "Logement" );


            connectionSqlServer.Close();

            return sqlDs;
        }


        public void ajouterLogement ( int nLogement , int idQuartier , int numero , string typeLogement , string rue , float superficie , float loyer ) {




        }

    }
}
