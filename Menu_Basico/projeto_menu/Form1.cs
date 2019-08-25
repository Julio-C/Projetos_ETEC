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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exemplosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //nao modal
            new FrmCombo().Show();
        }

        private void exemplos2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //modal
            new FrmCombo().ShowDialog();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"mspaint.exe");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
         System.Diagnostics.Process.Start(@"calc.exe");
        }

        private void exemplo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRadio().ShowDialog(); // chama outro formulario
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
