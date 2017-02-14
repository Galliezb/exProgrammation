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

namespace exercice03 {
    public partial class Form1 : Form {

        string titre, message;

        public Form1 () {
            InitializeComponent();
        }

        private void definirMessage_Click ( object sender , EventArgs e ) {
            message = Interaction.InputBox("Tapez le texte du message","Message","");
        }

        private void afficherMessage_Click ( object sender , EventArgs e ) {
            MessageBox.Show( this ,
                message ,
                titre ,
                MessageBoxButtons.OK ,
                MessageBoxIcon.None ,
                MessageBoxDefaultButton.Button1
                );
        }

        private void definirTitre_Click ( object sender , EventArgs e ) {
            titre = Interaction.InputBox( "Tapez le titre du message" , "Titre" , "" );
        }
    }
}
