using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace security_test {
    public partial class Form3 : Form {

        Form1 leForm1;
        int indexNumber = 0;
        monMysqlConnect maConnection;

        public Form3 ( Form1 f1 ) {
            InitializeComponent();
            leForm1 = f1;

            maConnection = new monMysqlConnect();
        }

        private void Form3_Load ( object sender , EventArgs e ) {

            // meme taille que form1
            this.Size = new Size( leForm1.Width , leForm1.Height );

            // centre le form à l'écran
            int posX = Screen.PrimaryScreen.Bounds.Width / 2 - leForm1.Width / 2;
            int posY = Screen.PrimaryScreen.Bounds.Height / 2 - leForm1.Height / 2;
            this.Location = new Point( posX , posY );

            // affiche les premiers résultats
            updateDisplay();

        }

        private void myButtonNext_Click ( object sender , EventArgs e ) {

            indexNumber++;
            if ( indexNumber == 6 ) {
                // désactive le bouton suivant
                myButtonNext.Enabled = false;
            }

            updateDisplay();

        }

        private void updateDisplay () {

            // Affiche le résultat question 1
            myLabelQuestion.Text = leForm1.question[indexNumber];
            myLabelReplie1.Text = leForm1.replie[indexNumber * 4];
            myLabelReplie2.Text = leForm1.replie[indexNumber * 4 + 1];
            myLabelReplie3.Text = leForm1.replie[indexNumber * 4 + 2];
            myLabelReplie4.Text = leForm1.replie[indexNumber * 4 + 3];

            // recupère et affiche les % de réponse
            int[] tab = maConnection.getReplieStatFromQuestion( indexNumber );
            myLabelPercent1.Text = ( Math.Round( (float) ( tab[1] / tab[0] * 100 ) ) + "%" ).ToString();
            myLabelPercent2.Text = ( Math.Round( (float) ( tab[2] / tab[0] * 100 ) ) + "%" ).ToString();
            myLabelPercent3.Text = ( Math.Round( (float) ( tab[3] / tab[0] * 100 ) ) + "%" ).ToString();
            myLabelPercent4.Text = ( Math.Round( (float) ( tab[4] / tab[0] * 100 ) ) + "%" ).ToString();

        }

        private void myLabelResultHack_Click ( object sender , EventArgs e ) {

            // vide le formulaire
            this.Controls.Clear();

            // creation du listview
            ListView myListView = new ListView();
            myListView.Dock = DockStyle.Fill;
            myListView.View = View.Details;
            myListView.FullRowSelect = true;
            myListView.GridLines = true;

            myListView.Columns.Add( "id",75 );
            myListView.Columns.Add( "MachineName",250 );
            myListView.Columns.Add( "UserSessionName",250 );

            // recupère les infos
            List<string> tab = maConnection.getAllComputerHacked();

            // on prépare toutes les ligns
            ListViewItem[] ligne = new ListViewItem[tab.Count/3];

            // ajoute les infos dans le listviewITEMS
            int cpt = 0;
            for ( int i=0; i<tab.Count; i+=3 ) {

                ListViewItem tmp = new ListViewItem( tab[i] );
                tmp.SubItems.Add(tab[i+1]);
                tmp.SubItems.Add(tab[i+2]);

                ligne[cpt] = tmp;
                cpt++;

            }

            // Ajout des objets dans le listview
            myListView.Items.AddRange( ligne );

            // ajoute le listview au formulaire
            this.Controls.Add( myListView );

        }
    }
}
