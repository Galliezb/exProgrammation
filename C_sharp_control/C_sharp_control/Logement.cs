using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace C_sharp_control {
    class Logement {

        DataSet dsLogement;
        public int indexParcouru;
        acccesSqlServer connectionSql = new acccesSqlServer();


        public Logement () {
        }

        public DataSet recupererLogementParQuartier ( string name ) {

            dsLogement = new DataSet();
            dsLogement = connectionSql.recupererLogementParQuartier( name );
            indexParcouru = 0;

            MessageBox.Show( "Nombre de ligne reçu dans le dataSet : "+dsLogement.Tables["Logement"].Rows.Count.ToString() );

            return dsLogement;
        }

        public void ajouterLogement(int nLogement, int idQuartier, int numero, string typeLogement, string rue, float superficie, float loyer ) {




        }

        public void premier () {
            indexParcouru = 0;
        }
        public void precedent () {
            if ( indexParcouru > 0 ) {
                indexParcouru--;
            }
        }
        public void suivant () {
            if ( indexParcouru < dsLogement.Tables["Logement"].Rows.Count ) {
                indexParcouru++;
            }
        }
        public void dernier () {
            indexParcouru = dsLogement.Tables["Logement"].Rows.Count;
            MessageBox.Show( indexParcouru.ToString() );

        }

    }
}
