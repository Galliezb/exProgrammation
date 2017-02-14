using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercice02 {
    public partial class Form1 : Form {

        /*
         1. Ajouter le 2e formulaire ( propriété -> ajouter -> formulaire window )
         2. Créer 1 instance du fomulaire dans le code ( Form2 f2 = new Form2(); ) 
         3. Rendre actif le nouveau formulaire
                f2.show(); // bloque l'accès sur le form ouvert
                f2.showDialog(); // laisse l'accès a tout le reste
         4. Fermeture
            this.Hide(); // cache en arrière plan
            this.close(); // ferme la fenetre complètement
         5. Echanger des informations entre formulaire
            -> creer une variable publique
            -> créer 1 variable a partager : public static
         */
        List<string> valeurEnregistre = new List<string>();

        public Form1 () {
            InitializeComponent();
        }

        private void Form1_Load ( object sender , EventArgs e ) {

        }

        private void button1_Click ( object sender , EventArgs e ) {
            valeurEnregistre.Add( this.txtBoxName.Text.ToString() );
            this.txtBoxName.Text = "";
            this.txtBoxName.Focus();
        }

        private void label1_Click ( object sender , EventArgs e ) {

        }

        private void textBox1_TextChanged ( object sender , EventArgs e ) {

        }

        private void button2_Click ( object sender , EventArgs e ) {

            if ( valeurEnregistre.Count() > 1 ) {
                Form2 f2 = new Form2( valeurEnregistre );
                // visible et lock sur la fenêtre
                f2.Show();
                // visible et ne lock pas sur la fenêtre
                //f2.ShowDialog();
            } else {
                lbError.Text = "Veuillez entrer plus de valeur.";
            }

        }
    }
}
