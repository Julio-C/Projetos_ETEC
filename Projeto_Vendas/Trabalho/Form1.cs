using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBprodutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch
                (CBprodutos.SelectedIndex)
            {

                case 0:
                    txtv.Text = "2.00";
                    pb.Image = Trabalho.Properties.Resources.Cd;

                    break;

                case 1:
                    txtv.Text = "4";
                    pb.Image = Trabalho.Properties.Resources.DVD;
                    break;

                case 2:
                    txtv.Text = "120";
                    pb.Image = Trabalho.Properties.Resources.Mem;
                    break;

                case 3:
                    txtv.Text = "150";
                    pb.Image = Trabalho.Properties.Resources.hd;
                    break;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4;

            n1 = double.Parse(txtq.Text);
            n2 = double.Parse(txtv.Text);
            n3 = double.Parse(txtf.Text);

            n4 = (n1 * n2) + n3;

            txtt1.Text = n4.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double n1, n2;




            if (RB1.Checked)
            {
                n1 = double.Parse(txtt1.Text);
                n2 = n1 - ((n1 / 100) * 5);
                txtt2.Text = n2.ToString();


            }

            else if (RB2.Checked)
            {
                n1 = double.Parse(txtt1.Text);
                n2 = n1 + ((n1 * 2) / 100);
                txtt2.Text = n2.ToString();
            }
        }

        private void txtv_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbf_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbf.SelectedItem.ToString())
            {
                case "Capital":
                    txtf.Text = "40";
                    break;

                case "Grande São Paulo":
                    txtf.Text = "50";
                    break;

                case "Interior":
                    txtf.Text = "80";
                    break;
            }
        }
    }
}


            
        
    

