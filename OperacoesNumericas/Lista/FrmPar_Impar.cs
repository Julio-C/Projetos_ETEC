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
    public partial class FrmPar_Impar : Form
    {
        public FrmPar_Impar()
        {
            InitializeComponent();
        }

        private void btnresposta_Click(object sender, EventArgs e)
        {
            int n1;
            n1 = int.Parse (txtN.Text);

            if (n1 % 2 == 0)
            {
               MessageBox.Show (n1 + "é um Número Par");
            }
            else
            {
              MessageBox.Show (n1 + " é um Número ímpar");
            }
         
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
