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
    public partial class Form3 : Form
    {
        double v1, v2, total;
        int op;
        string sinal;
        public int i = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            double t = double.Parse(txtv.Text);
            if (t == total)
            {
                txtv.BackColor = Color.Green;
                Form3_Load(null, null);
                i = i + 10;
                pontos.Text = i.ToString();



            }
            else
            {
                txtv.BackColor = Color.Red;
                i = i - 15;
                pontos.Text = i.ToString();
            }
            if (i == 100)
            {
                MessageBox.Show("Esta indo muito bem vamos para ultima etapa");
                this.Hide();
                new Form4 ().Show();
            }

            txtv.Focus();
            txtv.SelectAll();
        
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            v1 = r.Next(10);
            v2 = r.Next(10);
            op = r.Next(2);

            //lblv.Text = ("" + x.Next(10));
            
            switch (op)
            {
                case 0:
                    sinal = " + ";
                    total = v1 + v2;
                    break;


                case 1:
                    sinal = " - ";
                    total = v1 - v2;
                    break;
            
            }
            LBLCONTA.Text = (" " + v1 + "  " + sinal + "  " + v2 + " " + "=");
        }
    }
}
