using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Jogo
{
    public partial class Form4 : Form
    {
        double v1, v2, total;
        int op;
        string sinal;
        public int i = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            v1 = r.Next(10);
            v2 = r.Next(10);
           

           

            //lblv.Text = ("" + x.Next(10));
            
                        sinal = " * ";
                        total = v1 * v2 ;
                        

           
                LBLCONTA.Text = (" " + v1 + "  " + sinal + "  " + v2 + " " + "=");

        } 
                    

        private void btnv_Click(object sender, EventArgs e)
        {
            double t = double.Parse(txtv.Text);
            if (t == total)
            {
                txtv.BackColor = Color.Green;
                Form4_Load(null, null);
                i = i + 10;
                pontos.Text = i.ToString();



            }
            else
            {
                txtv.BackColor = Color.Red;
                i = i - 20;
                pontos.Text = i.ToString();
            }
            if (i == 100)
            {
                MessageBox.Show(" Muito Bom Mesmo Parabéns");
                this.Hide();
                new Form5().Show();
                
            }
            txtv.Focus();
            txtv.SelectAll();
        }
    }
}
