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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmSoma().Show();
            this.Hide();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmPar_Impar().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmDivisivel_5().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FrmDivisivel_10_5_2().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Frmcompreendido_20_90().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Frmigual_diferente_20().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FrmDivisivel_3_5().Show();
            this.Hide();
        }
    }
}
