using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace labo_01 {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();

            // Un domainupdown avec les items Addition, Soustraction, Multiplication et Division (à créer par code)
            udOperation.Items.Add( "Division" );
            udOperation.Items.Add( "Multiplication" );
            udOperation.Items.Add( "Soustraction" );
            udOperation.Items.Add( "Addition" );
            udOperation.SelectedIndex = 3;

            // Les images doivent être stockées dans les ressources du projet. Et ensuite par programmation, chargées dans un contrôle ImageList.
            //ImageList imgList = new ImageList();
            imgList.Images.Add(Properties.Resources.plus );
            imgList.Images.Add(Properties.Resources.moins );
            imgList.Images.Add(Properties.Resources.fois );
            imgList.Images.Add(Properties.Resources.diviser );

            // Ajout des colonnes dans le listview
            listView.View = View.Details;
            //listView.Columns.Add( "I" , 50 , HorizontalAlignment.Left );
            listView.Columns.Add( "Opération" , 150 , HorizontalAlignment.Left );
            listView.Columns.Add( "Opérateur" , 150 , HorizontalAlignment.Left );

            // Les éléments de la listview doivent être créés par programmation.

            // Display grid lines.
            listView.GridLines = true;

            // creation des datas
            //ListViewItem list1 = new ListViewItem( "Addition" );
            //list1.SubItems.Add( "+" );
            ListViewItem lvi1 = new ListViewItem();
            lvi1.Text = "Addition";
            lvi1.ImageIndex = 0;
            lvi1.SubItems.Add( "+" );
            listView.Items.Add( lvi1 );

            ListViewItem list2 = new ListViewItem();
            list2.Text = "Soustration";
            list2.ImageIndex = 1;
            list2.SubItems.Add( "-" );
            listView.Items.Add( list2 );

            ListViewItem list3 = new ListViewItem();
            list3.Text = "Multiplication";
            list3.ImageIndex = 2;
            list3.SubItems.Add( "*" );
            listView.Items.Add( list3 );

            ListViewItem list4 = new ListViewItem();
            list4.Text = "Division";
            list4.ImageIndex = 3;
            list4.SubItems.Add( "/" );
            listView.Items.Add( list4 );


            // ajoute les icons
            listView.SmallImageList = imgList;
            // pourquoi elle s'affichent pas ?
            // https://msdn.microsoft.com/en-us/library/system.windows.forms.listview.smallimagelist.aspx#Examples



            //Add the items to the ListView.
            //listView.Items.AddRange( new ListViewItem[] { list1 , list2 , list3 , list4 } );

            // ajoute l'evenement click au treeView
            tw1.MouseClick += new MouseEventHandler( treeView1_NodeMouseClick );

        }

        private void tabPage1_Click ( object sender , EventArgs e ) {

        }

        private void domainUpDown1_SelectedItemChanged ( object sender , EventArgs e ) {

        }

        private void udOperation_SelectedItemChanged ( object sender , EventArgs e ) {

        }

        private void tabControl_MouseDoubleClick ( object sender , MouseEventArgs e ) {

            //pageAffichage.ti

        }

        private void btResultat_Click ( object sender , EventArgs e ) {

            // récupère les data
            int nbr1 = (int)udNombre1.Value;
            int nbr2 = (int)udNombre2.Value;
            float result = 0f;
            string nodeToAdd;

            switch ( udOperation.SelectedIndex ) {

                case 3:
                    result = nbr1 + nbr2;
                    nodeToAdd = nbr1 + "+" + nbr2 + "=" + result;
                    // ajoute le noeud a treeview
                    TreeNode tmp3 = tw1.Nodes[0].Nodes.Add( nodeToAdd );                   
                    break;
                case 2:
                    result = nbr1 - nbr2;
                    nodeToAdd = nbr1 + "-" + nbr2 + "=" + result;
                    // ajoute le noeud a treeview
                    tw1.Nodes[1].Nodes.Add( nodeToAdd );
                    break;
                case 1:
                    result = nbr1 * nbr2;
                    nodeToAdd = nbr1 + "*" + nbr2 + "=" + result;
                    // ajoute le noeud a treeview
                    tw1.Nodes[2].Nodes.Add( nodeToAdd );
                    break;
                case 0:
                    result = nbr1 / nbr2;
                    nodeToAdd = nbr1 + "/" + nbr2 + "=" + result;
                    // ajoute le noeud a treeview
                    TreeNode tmp0 = tw1.Nodes[3].Nodes.Add( nodeToAdd );
                    break;

            }

            txtResultat.Text = result.ToString();

        }

        private void treeView1_NodeMouseClick ( object sender , EventArgs e ) {

        }

        private void label1_Click ( object sender , EventArgs e ) {

        }

        private void tw1_AfterSelect ( object sender , TreeViewEventArgs e ) {
            MessageBox.Show( "text" + tw1.SelectedNode.Text );
        }

        private void listView_SelectedIndexChanged ( object sender , EventArgs e ) {

        }
    }
}
