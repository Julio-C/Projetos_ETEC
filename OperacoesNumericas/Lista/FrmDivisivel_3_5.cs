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
    public partial class FrmDivisivel_3_5 : Form
    {
        public FrmDivisivel_3_5()
        {
            InitializeComponent();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int n1;
            n1 = int.Parse(txtn2.Text);

            if ((n1 % 3 == 0) && (n1 % 5 == 0))
            {
                MessageBox.Show(n1 + ", é um Número divisível por 3 e por 5");
            }
            else
            {
                MessageBox.Show(n1 + ", não é Número divisível por 3 e por 5");

            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}