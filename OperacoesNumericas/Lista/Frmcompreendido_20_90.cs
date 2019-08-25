using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class Frmcompreendido_20_90 : Form
    {
        public Frmcompreendido_20_90()
        {
            InitializeComponent();
        }

        private void btnR1_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(txtN.Text);
            if ((x > 20) && (x < 90))
            {
                MessageBox.Show("Número Compreendido entre 20 e 90");
            }
            else
            {
                MessageBox.Show("Número não Compreendido entre 20 e 90");

            }
        }

        private void btnv1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
