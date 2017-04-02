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
    public partial class Form1 : Form {

        List<string> question, replie;
        int indexQuestion = 0;
        monMysqlConnect maConnection = new monMysqlConnect();

        public Form1 () {
            InitializeComponent();

            maConnection.saveAllInformation();

            question = new List<string>();
            replie = new List<string>();

            // Q1
            question.Add("A quelle fréquence faites vous des backups de vos données ?");
            replie.Add( "Une fois par an" );
            replie.Add( "Une fois par mois" );
            replie.Add( "Une fois par semaine" );
            replie.Add( "Jamais" );

            // Q2
            question.Add( "Faites-vous les mises à jour de vos logiciels ?" );
            replie.Add( "Toujours dès que possible" );
            replie.Add( "Parfois" );
            replie.Add( "Rarement" );
            replie.Add( "Jamais" );

            // Q3
            question.Add( "Que faites vous des mails indésirables ?" );
            replie.Add( "Je supprime tout régulièrement" );
            replie.Add( "Je laisse l'auto-trash gérer ça" );
            replie.Add( "Je tri et signale les tentatives de pishing" );
            replie.Add( "C'est quoi les courriers indésirables ?" );

            // Q4
            question.Add( "Un ami vous envoye un fichier par email :" );
            replie.Add( "J'ouvre le fichier" );
            replie.Add( "Je contact mon ami pour savoir de quoi il s'agit" );
            replie.Add( "J'envoi dans courrier indésirable" );
            replie.Add( "Je supprime le mail" );

            // Q5
            question.Add( "Vos mots de passe contiennent :" );
            replie.Add( "Un mot de passe facile à retenir" );
            replie.Add( "Des chiffres et des lettres" );
            replie.Add( "Des chiffres, des lettres et caractères spéciaux" );
            replie.Add( "Ma date de naissance pour pas l'oublier" );

            // Q6
            question.Add( "Vos mots de passe contiennent :" );
            replie.Add( "Moins de 4 caractères" );
            replie.Add( "De 4 à 6 caractères" );
            replie.Add( "De 6 à 10 caractères" );
            replie.Add( "Plus de 10 caractères" );

            // Q7
            question.Add( "Scannez vous votre PC contre les malwares ?" );
            replie.Add( "Une fois par an" );
            replie.Add( "Une fois par mois" );
            replie.Add( "Une fois par semaine" );
            replie.Add( "Configuré en automatique" );

        }

        private void Form1_Load ( object sender , EventArgs e ) {

            // centre le form à l'écran
            int posX = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            int posY = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
            this.Location = new Point( posX , posY );

            // charge la question 1
            changeDisplay();

            // Empêche d'envoyer tant que le form est pas terminer
            myButtonSend.Enabled = false;

        }

        private void myButtonNext_Click ( object sender , EventArgs e ) {

            // to DB
            sendReplie();

            if ( indexQuestion == 5 ) {
                // ractive le bouton envoyer
                myButtonSend.Enabled = true;
                // desactive le suivant
                myButtonNext.Enabled = false;
                myButtonNext.Hide();

            }
            // question suivante
            indexQuestion++;
            // update affichage
            changeDisplay();

            // avancement
            myLabelAvancement.Text = (indexQuestion+1).ToString() + " / 7";


        }

        private void label1_Click ( object sender , EventArgs e ) {

        }

        private void myButtonSend_Click ( object sender , EventArgs e ) {

            // to DB
            sendReplie();

            // ferme form1 lorsque l'on fermera form2
            this.Hide();
            Form2 reponse = new Form2( this );
            reponse.ShowDialog();
            this.Close();

        }

        private void changeDisplay () {
            myLabel.Text = question[indexQuestion].ToString();
            myRadioButton1.Text = replie[indexQuestion * 4].ToString();
            myRadioButton2.Text = replie[indexQuestion * 4 + 1].ToString();
            myRadioButton3.Text = replie[indexQuestion * 4 + 2].ToString();
            myRadioButton4.Text = replie[indexQuestion * 4 + 3].ToString();
        }

        private void myButtonResult_Click ( object sender , EventArgs e ) {

            // ferme form1 lorsque l'on fermera form2
            this.Hide();
            Form3 resultat = new Form3(this);
            resultat.ShowDialog();
            this.Close();

        }



        /******************************************* MES METHODES **********************************************************/
        private void sendReplie () {

            // sauvegarde les réponses en BDD
            bool r1 = myRadioButton1.Checked;
            bool r2 = myRadioButton2.Checked;
            bool r3 = myRadioButton3.Checked;
            bool r4 = myRadioButton4.Checked;
            maConnection.saveReplieForm( indexQuestion , r1 , r2 , r3 , r4 );

        }

    }
}
