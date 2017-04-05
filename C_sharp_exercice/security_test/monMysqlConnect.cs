using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace security_test {
    class monMysqlConnect {

        // Mysql connection info. Ajouter la référence via parcourir et trouver mysql.data.dll après avoir installer le connector mysql ( program file / mysql / )
        // https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-connection.html

        // chaine de connection
        string myConnectionString;
        // connector Mysql
        MySqlConnection maConnexionMysql;

        public monMysqlConnect () {
            // tentative de connexion
            try {

                string server = "5.135.176.126";
                string database = "securityTest";
                string login = "securityTest";
                string password = "yAZkMWhOYFItjVWo";
                myConnectionString = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "UID=" + login + ";" + "PASSWORD=" + password + ";";
                maConnexionMysql = new MySqlConnection( myConnectionString );


            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message.ToString() );
            }


        }

        public void saveAllInformation () {

            // On stock le nom de la machine pour afficher ultérieurement toutes les personnes ayant lancé l'exe
            string machineName = Environment.MachineName.ToString();
            // Le nom de la session si le nom machine n'as pas été défini par l'utilisateur
            string userSessionName = Environment.UserName.ToString();

            // en passant par les paramètres, on se protège des nécessités des caractères d'échapement, trop cool :D
            //machineName = "test ' test";

            maConnexionMysql.Open();


            string sqlRequest = "INSERT INTO infoClient(machineName,userSessionName) VALUES(@machineName, @userSessionName);";

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sqlRequest;
            cmd.Connection = maConnexionMysql;

            try {
                cmd.Parameters.AddWithValue( "@machineName" , machineName );
                cmd.Parameters.AddWithValue( "@userSessionName" , userSessionName );
                cmd.ExecuteNonQuery();
            // en cas d'erreur 
            } catch {
                cmd.Parameters.AddWithValue( "@machineName" , "Error" );
                cmd.Parameters.AddWithValue( "@userSessionName" , "Error" );
                cmd.ExecuteNonQuery();
            }

            maConnexionMysql.Close();

        }


        public void saveReplieForm(int numberQuestion, bool replie1=false , bool replie2 = false , bool replie3 = false , bool replie4 = false ) {

            // On stock le nom de la machine pour afficher ultérieurement toutes les personnes ayant lancé l'exe
            string machineName = Environment.MachineName.ToString();
            // Le nom de la session si le nom machine n'as pas été défini par l'utilisateur
            string userSessionName = Environment.UserName.ToString();

            // en passant par les paramètres, on se protège des nécessités des caractères d'échapement, trop cool :D
            //machineName = "test ' test";

            maConnexionMysql.Open();


            string sqlRequest = "INSERT INTO reponses(idQuestion,replie1,replie2,replie3,replie4) VALUES(@id,@r1,@r2,@r3,@r4);";

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sqlRequest;
            cmd.Connection = maConnexionMysql;

            cmd.Parameters.AddWithValue( "@id" , numberQuestion );
            cmd.Parameters.AddWithValue( "@r1" , replie1 );
            cmd.Parameters.AddWithValue( "@r2" , replie2 );
            cmd.Parameters.AddWithValue( "@r3" , replie3 );
            cmd.Parameters.AddWithValue( "@r4" , replie4 );

            cmd.ExecuteNonQuery();

            maConnexionMysql.Close();


        }

        public int[] getReplieStatFromQuestion ( int questionNumber) {

            maConnexionMysql.Open();


            string sqlRequest = "SELECT COUNT(*) as total, SUM(replie1) as r1, SUM(replie2) as r2, SUM(replie3) as r3, SUM(replie4) as r4 "; 
            sqlRequest += "FROM reponses WHERE idQuestion=@idQuestion GROUP BY idQuestion";

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sqlRequest;
            cmd.Connection = maConnexionMysql;

            cmd.Parameters.AddWithValue( "@idQuestion" , questionNumber );

            MySqlDataReader monReaderMysql = cmd.ExecuteReader();


            monReaderMysql.Read();
            int[] toReturn =  { Convert.ToInt32(monReaderMysql.GetString( "total" )) ,
                               Convert.ToInt32(monReaderMysql.GetString( "r1" )) ,
                               Convert.ToInt32(monReaderMysql.GetString( "r2" )) ,
                               Convert.ToInt32(monReaderMysql.GetString( "r3" )) ,
                               Convert.ToInt32(monReaderMysql.GetString( "r4" ))
                                };

            maConnexionMysql.Close();

            return toReturn;




        }

        public List<string> getAllComputerHacked () {

            maConnexionMysql.Open();

            string sqlRequest = "SELECT * FROM infoClient";

            MySqlCommand cmd = new MySqlCommand( sqlRequest , maConnexionMysql );
            MySqlDataReader monReaderMysql = cmd.ExecuteReader();

            List<string> toReturn = new List<string>();

            if ( monReaderMysql.HasRows ) {

                while ( monReaderMysql.Read() ) {
                    toReturn.Add( monReaderMysql.GetString( 0 ) );
                    toReturn.Add( monReaderMysql.GetString( 1 ) );
                    toReturn.Add( monReaderMysql.GetString( 2 ) );
                }

            }

            maConnexionMysql.Close();

            return toReturn;

        }

    }
}