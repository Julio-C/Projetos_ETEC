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
    public partial class Frmigual_diferente_20 : Form
    {
        public Frmigual_diferente_20()
        {
            InitializeComponent();
        }

        private void btnr4_Click(object sender, EventArgs e)
        {
            int x; 
          x = int.Parse(txtn4.Text);
            if (x > 20)
            {
                MessageBox.Show ("Número maior que 20");
            }
            else if (x == 20)
            {
                MessageBox.Show ("Número igual a 20");
            }

            else
            {
                MessageBox.Show ("Número menor que 20");
            }

        }

        private void btnv4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
