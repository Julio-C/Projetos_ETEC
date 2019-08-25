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
    public partial class vendas : Form
    {
        public vendas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double  n4, n1,n3;
            int n2;

            n1 = double.Parse(txtqtd.Text);
            n2 = int.Parse(txtvalor.Text);
            n3 = double.Parse(txtfrete.Text);
            
            n4 = ((n1*n2)+n3);

            txttotal1.Text = n4.ToString();
            
          


    }

        private void cbprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbprod.SelectedItem.ToString())
            {

                case "CD":
                    txtvalor.Text = "2";
                    pb1.Image = Trabalho.Properties.Resources.cd;

                    break;

                case "DVD":
                    txtvalor.Text = "4";
                    pb1.Image = Trabalho.Properties.Resources.DVD;
                    break;

                case "Memoria":
                    txtvalor.Text = "120";
                    pb1.Image = Trabalho.Properties.Resources.Mem;
                    break;

                case "HD":
                    txtvalor.Text = "150";
                    pb1.Image = Trabalho.Properties.Resources.hd;
                    break;
            }
        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbfrete_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbfrete.SelectedItem.ToString())
            {

                case "Capital":
                    txtfrete.Text = "40";
                    break;

                case "Grande São Paulo":
                    txtfrete.Text = "50";
                    break;

                case "Interior":
                    txtfrete.Text = "80";
                    break;


            }
        }

        private void txtqtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbdin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncalc2_Click(object sender, EventArgs e)
        {
            double n1, n2;

            


            if (rbd.Checked)
            {
                n1 = double.Parse(txttotal1.Text);
                n2 = n1 - ((n1 /100) * 5);
                txttotal2.Text = n2.ToString();

                
            }

            else if (rbc.Checked)
            {
                n1 = double.Parse(txttotal1.Text);
                n2 = n1 +  ((n1 * 2) / 100);
                txttotal2.Text = n2.ToString();
                

            
        }

    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n,i;
            double t, q ,s;

            
            n = cbprod.Text;
            q = double.Parse (txtqtd.Text);
            s = double.Parse (txttotal2.Text);
            t = double.Parse(total.Text);

            i = (n + ' ' + ' ' + q + ' ' + ' ' + s);
            listBox1.Items.Add(i);

           
                
                t = t + s ;

                total.Text = t.ToString();

                txtvalor.Text = "";
                txtqtd.Text = "";
                txtfrete.Text = "";
                txttotal2.Text = "";
                txttotal1.Text = "";

            


          
        }
    }
}