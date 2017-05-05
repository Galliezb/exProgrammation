using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace C_sharp_control {
    class Quartier {

        int idQuartier,idCommune;
        string libelle;

        acccesSqlServer connectionSql = new acccesSqlServer ();

        public Quartier () {
            idQuartier = -1;
            idCommune = -1;
            libelle = "";
        }

        public Quartier (int idQ, int idC, string lib) {
            idQuartier = idQ;
            idCommune = idC;
            libelle = lib;
        }

        public DataSet recupererQuartier () {

            DataSet toReturn = new DataSet();
            toReturn = (DataSet) connectionSql.recupereQuartier();

            return toReturn;

        }

        public int recupereIdQuartier(string name ) {

            int toReturn = connectionSql.recupereIdQuartier( name );
            return toReturn;

        }

    }
}
