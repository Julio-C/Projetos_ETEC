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
    public partial class FrmDivisivel_10_5_2 : Form
    {
        public FrmDivisivel_10_5_2()
        {
            InitializeComponent();
        }

        private void btnresp_Click(object sender, EventArgs e)
        {
            int n1;
            n1 = int.Parse(txtn3.Text);

            if ((n1 % 10 == 0) || (n1 % 5 == 0) || (n1 % 2 == 0))
            {
                MessageBox.Show(n1 + ",o Número é divisível por 10, ou por 5, ou por 2.");
            }
            else
            {
                MessageBox.Show(n1 + ",o Número não é divisível por 10, ou por 5, ou por 2.");

            }
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {

            new Form1().Show();
            this.Hide();
        }
    }
}
