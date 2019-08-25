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
    public partial class FrmSoma : Form
    {
        public FrmSoma()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double v1, v2, r;

            v1 = double.Parse(txt1n.Text);
            v2 = double.Parse(txt2n.Text);
            r = v1 + v2;
            txtr.Text = r.ToString();
            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txt1n.Clear();
            txt2n.Clear();
            txtr.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
