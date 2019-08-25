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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Double V1, V2, total;

            V1 = double.Parse(txtV1.Text);
            V2 = double.Parse(txtV2.Text);
            //vamos procurar no switch o indice selecionado
            switch(cbOp.SelectedIndex)
            {
                case 0 :
                    total = V1 + V2;
                    MessageBox.Show(total.ToString());
                    break;
                
                case 1 :
                    total = V1 - V2;
                    MessageBox.Show(total.ToString());
                    break;
                
                case 2 :
                    total = V1 * V2;
                    MessageBox.Show(total.ToString());
                    break;

                case 3 :
                    total = V1 / V2;
                    MessageBox.Show(total.ToString());
                    break;
                
                default :
                    MessageBox.Show("selecione uma opção");
                    break;

                
            }
        }
    }
}
