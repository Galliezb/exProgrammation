using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WALaboratoire1
{
    public partial class frLabo1 : Form
    {
        int nb1, nb2,res,cpt;
        string oper;
        string[] tabcal;
        string[] taboper;
        
        public frLabo1()
        {
            InitializeComponent();
        }

        private void nupNombre2_ValueChanged(object sender, EventArgs e)
        {
            nb2 = (int)nupNombre2.Value;
        }

        private void frLabo1_Load(object sender, EventArgs e)
        {
            taboper = new string[100];
            tabcal = new string[100];
            TreeNode no;
            no = new TreeNode("Addition");
            tvAffichage.Nodes.Add(no);
            no = new TreeNode("Soustraction");
            tvAffichage.Nodes.Add(no);
            no = new TreeNode("Multiplication");
            tvAffichage.Nodes.Add(no);
            no = new TreeNode("Division");
            tvAffichage.Nodes.Add(no);
            //Mise des images ressources dans imagelist
            imageList1.Images.Add(Properties.Resources.plus);
            imageList1.Images.Add(Properties.Resources.moins);
            imageList1.Images.Add(Properties.Resources.plus);
            imageList1.Images.Add(Properties.Resources.divise);
            //chargement d'item dans la listview
            ListViewItem lvi1 = new ListViewItem();
            lvi1.Text = "Addition";
            lvi1.ImageIndex = 0;
            lvi1.SubItems.Add("+");
            lstAffichage.Items.Add(lvi1);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "Soustraction";
            lvi.ImageIndex = 1;
            lvi.SubItems.Add("-");
            lstAffichage.Items.Add(lvi);
            ListViewItem lvi2 = new ListViewItem();
            lvi2.Text = "Multiplication";
            lvi2.ImageIndex = 2;
            lvi2.SubItems.Add("*");
            lstAffichage.Items.Add(lvi2);
            ListViewItem lvi3 = new ListViewItem();
            lvi3.Text = "Division";
            lvi3.ImageIndex = 3;
            lvi3.SubItems.Add("/");
            lstAffichage.Items.Add(lvi3);
            //chargement de colonnes pour la partie détail de la listview
            lstAffichage.Columns.Add("Opération");
            lstAffichage.Columns.Add("Opérateur");
            this.lstAffichage.SmallImageList = this.imageList1;
            lstAffichage.View = View.Details;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabPages[tabControl1.SelectedIndex].Text == "Affichage") {
                TreeNode node;
                int i;
                i = 0;
                foreach (string s in tabcal) {
                    Console.WriteLine(s);
                    switch (taboper[i]) {
                        case "+":
                            node = tvAffichage.Nodes[0];
                            node.Nodes.Add(s);
                            break;
                        case "-":
                            node = tvAffichage.Nodes[1];
                            node.Nodes.Add(s);
                            break;
                        case "*":
                            node = tvAffichage.Nodes[2];
                            node.Nodes.Add(s);
                            break;
                        case "/":
                            node = tvAffichage.Nodes[3];
                            node.Nodes.Add(s);
                            break;
                    }
                    i += 1;
             }
            }
        }

        private void tvAffichage_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text, "Noeud sélectionné", MessageBoxButtons.OK);
            lstAffichage.Items.Clear();
            lstAffichage.View = View.List;
            ListViewItem item;
            item = new ListViewItem(e.Node.Text);
            lstAffichage.Items.Add(item);
        }

        private void btResulltat_Click(object sender, EventArgs e)
        {
            string cal;
            cal = nb1.ToString() + oper + nb2.ToString() + "=" + res.ToString();
            taboper[cpt] = oper;
            tabcal[cpt] = cal;
            cpt += 1;
            txtResultat.Text = res.ToString();
        }

        private void dupOperation_SelectedItemChanged(object sender, EventArgs e)
        {
            oper = dupOperation.SelectedItem.ToString();
            switch (oper)
            {
                case "+":
                    res = nb1 + nb2;
                    break;
                case "-":
                    res = nb1 - nb2;
                    break;
                case "*":
                    res = nb1 * nb2;
                    break;
                case "/":
                    if (nb2 != 0) {
                        res = nb1 / nb2;
                    }
                    break;
            }
        }

        private void nupNombre1_ValueChanged(object sender, EventArgs e)
        {
            nb1 = (int)nupNombre1.Value;
        }
    }
}
