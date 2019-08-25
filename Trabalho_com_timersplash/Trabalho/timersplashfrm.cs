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
    public partial class timersplashfrm : Form
    {
        public timersplashfrm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbsplash.Increment(1);
            if (pbsplash.Value == 100)
            {
                new frmmenu().Show();
                this.Hide();
                timer1.Stop();           
            }
        
        
        }
    }
}
