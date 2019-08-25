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
    public partial class FrmDivisivel_5 : Form
    {
        public FrmDivisivel_5()
        {
            InitializeComponent();
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            int n1;
            n1 = int.Parse (txtn1.Text);

            if (n1 % 5 == 0)
            {
               MessageBox.Show (n1 + ", é um Número divisível por 5");
            }
            else
            {
               MessageBox.Show (n1 + ", não é divisível por 5");
            }
           


        }

        private void Messa(string p)
        {
            throw new NotImplementedException();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
