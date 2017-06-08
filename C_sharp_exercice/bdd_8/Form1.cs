using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdd_8 {
    public partial class Form1 : Form {

        DataGridView dataGrid = new DataGridView();

        public Form1 () {
            InitializeComponent();
        }

        private void Form1_Load ( object sender , EventArgs e ) {

            
            dataGrid.Dock = DockStyle.Top;
            dataGrid.Height = 350;

            dataGrid.Columns.Add( "c1" , "" );
            dataGrid.Columns.Add( "c2" , "Longueur 1" );
            dataGrid.Columns.Add( "c3" , "Longueur 2" );
            dataGrid.Columns.Add( "c4" , "Longueur 3" );

            dataGrid.Columns["c1"].Width = 180;
            dataGrid.Columns["c2"].Width = 180;
            dataGrid.Columns["c3"].Width = 180;
            dataGrid.Columns["c4"].Width = 180;

            dataGrid.Rows.Add( "Millimètres" , "10" , "20" , "30" );
            dataGrid.Rows.Add( "Mètres" , "10000" , "20000" , "30000" );
            dataGrid.Rows.Add( "Kilomètres" , "100000" , "200000" , "300000" );

            dataGrid.CellClick += new DataGridViewCellEventHandler( dataGridViewClickOnCell );

            this.Controls.Add( dataGrid );


        }

        private void dataGridViewClickOnCell ( object sender, DataGridViewCellEventArgs e ) {

            //MessageBox.Show( dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() );
            // Ou en plus simple
            MessageBox.Show( dataGrid.CurrentCell.Value.ToString() );

        }
    }
}
