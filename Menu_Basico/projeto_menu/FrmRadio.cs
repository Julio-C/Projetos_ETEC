using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_menu
{
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void btnver1_Click(object sender, EventArgs e)
        {
            switch(cbuf.SelectedItem.ToString())
            {
                case "SP" :

                    MessageBox.Show("Você é de São Paulo");
                    break;

                case "RJ" :

                    MessageBox.Show("Você é de Rio de Janeiro");
                    break;

                case "MG" :

                    MessageBox.Show("Você é de Minas Gerais");
                    break;

                default :
                    MessageBox.Show("Escolha um Estado");
                    break;

            }
                
          }

        private void btnver2_Click(object sender, EventArgs e)
        {
            if (rbm.Checked)
            {
                MessageBox.Show("Masculino");
            }
            else if (rbf.Checked)
            {
                MessageBox.Show("feminino");
            }
        }
        }
    }

