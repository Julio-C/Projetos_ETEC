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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TXTA_TextChanged(object sender, EventArgs e)
        {
            if (TXTA.Text == ("A"))
            {
                TXTA.BackColor = Color.Green;
                TXTE.Visible = Visible;
                TXTE.Focus();
            }
            else
            {
                TXTA.BackColor = Color.Red;
                TXTA.SelectAll();
            }
        }

        private void TXTE_TextChanged(object sender, EventArgs e)
        {
            if (TXTE.Text == ("E"))
            {
                TXTE.BackColor = Color.Green;
                TXTI.Visible = Visible;
                TXTI.Focus();
            }
            else
            {
                TXTE.BackColor = Color.Red;
                TXTE.SelectAll();
            }
        }

        private void TXTI_TextChanged(object sender, EventArgs e)
        {
            if (TXTI.Text == ("I"))
            {
                TXTI.BackColor = Color.Green;
                TXTO.Visible = Visible;
                TXTO.Focus();
            }
            else
            {
                TXTI.BackColor = Color.Red;
                TXTI.SelectAll();
            }
        }

        private void TXTO_TextChanged(object sender, EventArgs e)
        {
            if (TXTO.Text == ("O"))
            {
                TXTO.BackColor = Color.Green;
                TXTU.Visible = Visible;
                TXTU.Focus();
            }
            else
            {
                TXTO.BackColor = Color.Red;
                TXTO.SelectAll();
            }
        }

        private void TXTU_TextChanged(object sender, EventArgs e)
        {
            if (TXTU.Text == ("U"))
            {
                TXTU.BackColor = Color.Green;
                this.Hide();
                MessageBox.Show("parabens");
                new Form2().Show();
            }
            else
            {
                TXTU.BackColor = Color.Red;
                TXTU.SelectAll();
            }
        }
    }
}
