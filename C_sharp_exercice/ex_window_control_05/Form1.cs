using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_window_control_05 {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }

        private void Form1_Load ( object sender , EventArgs e ) {

        }

        private void D_tbVertical_Scroll ( object sender , EventArgs e ) {

            int val = D_tbVertical.Value;
            
            this.BackColor = Color.FromArgb( (val-15) * 25 , 0, 255 - ( ( val - 15 ) * 25 ) );
            D_lb1.Text = "Rouge = " + ( ( val - 15 ) * 25);
            D_lb2.Text = "Bleu = " + ( 255- ((val-15) * 25) );

        }
    }
}
