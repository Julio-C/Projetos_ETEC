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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (txtd.Text == ("D"))
            {
                txtd.BackColor = Color.Green;
                txte.Visible = Visible;
                txte.Focus();
            }
            else
            {
                txtd.BackColor = Color.Red;
                txtd.SelectAll();
            } 
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (txta.Text == ("A"))
            {
                txta.BackColor = Color.Green;
                txtb.Visible = Visible;
                txtb.Focus();
            }
            else
            {
                txta.BackColor = Color.Red;
                txta.SelectAll();
            } 
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            if (txtb.Text == ("B"))
            {
                txtb.BackColor = Color.Green;
                txtc.Visible = Visible;
                txtc.Focus();
            }
            else
            {
                txtb.BackColor = Color.Red;
                txtb.SelectAll();
            } 
        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {
            if (txtc.Text == ("C"))
            {
                txtc.BackColor = Color.Green;
                txtd.Visible = Visible;
                txtd.Focus();
            }
            else
            {
                txtc.BackColor = Color.Red;
                txtc.SelectAll();
            } 
        }

        private void txte_TextChanged(object sender, EventArgs e)
        {
            if (txte.Text == ("E"))
            {
                txte.BackColor = Color.Green;
                txtf.Visible = Visible;
                txtf.Focus();
            }
            else
            {
                txte.BackColor = Color.Red;
                txte.SelectAll();
            } 
        }

        private void txtf_TextChanged(object sender, EventArgs e)
        {
            if (txtf.Text == ("F"))
            {
                txtf.BackColor = Color.Green;
                txtg.Visible = Visible;
                txtg.Focus();
            }
            else
            {
                txtf.BackColor = Color.Red;
                txtf.SelectAll();
            } 
           
        }

        private void txtg_TextChanged(object sender, EventArgs e)
        {
            if (txtg.Text == ("G"))
            {
                txtg.BackColor = Color.Green;
                txth.Visible = Visible;
                txth.Focus();
            }
            else
            {
                txtg.BackColor = Color.Red;
                txtg.SelectAll();
            } 
        }

        private void txth_TextChanged(object sender, EventArgs e)
        {
            if (txth.Text == ("H"))
            {
                txth.BackColor = Color.Green;
                txti.Visible = Visible;
                txti.Focus();
            }
            else
            {
                txth.BackColor = Color.Red;
                txth.SelectAll();
            } 
             
        }

        private void txti_TextChanged(object sender, EventArgs e)
        {
            if (txti.Text == ("I"))
            {
                txti.BackColor = Color.Green;
                txtj.Visible = Visible;
                txtj.Focus();
            }
            else
            {
                txti.BackColor = Color.Red;
                txti.SelectAll();
            }
             
        }

        private void txtj_TextChanged(object sender, EventArgs e)
        {
            if (txtj.Text == ("J"))
            {
                txtj.BackColor = Color.Green;
                txtk.Visible = Visible;
                txtk.Focus();
            }
            else
            {
                txtj.BackColor = Color.Red;
                txtj.SelectAll();
            }
             
        }

        private void txtk_TextChanged(object sender, EventArgs e)
        {
            if (txtk.Text == ("K"))
            {
                txtk.BackColor = Color.Green;
                txtl.Visible = Visible;
                txtl.Focus();
            }
            else
            {
                txtk.BackColor = Color.Red;
                txtk.SelectAll();
            }
            
        }

        private void txtl_TextChanged(object sender, EventArgs e)
        {
            if (txtl.Text == ("L"))
            {
                txtl.BackColor = Color.Green;
                txtm.Visible = Visible;
                txtm.Focus();
            }
            else
            {
                txtm.BackColor = Color.Red;
                txtm.SelectAll();
            } 
              }

        private void txtm_TextChanged(object sender, EventArgs e)
        {
            if (txtm.Text == ("M"))
            {
                txtm.BackColor = Color.Green;
                txtn.Visible = Visible;
                txtn.Focus();
            }
            else
            {
                txtm.BackColor = Color.Red;
                txtm.SelectAll();
            } 
      
        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {
            if (txtn.Text == ("N"))
            {
                txtn.BackColor = Color.Green;
                txto.Visible = Visible;
                txto.Focus();
            }
            else
            {
                txtn.BackColor = Color.Red;
                txtn.SelectAll();
            } 
        }

        private void txto_TextChanged(object sender, EventArgs e)
        {

            if (txto.Text == ("O"))
            {
                txto.BackColor = Color.Green;
                txtp.Visible = Visible;
                txtp.Focus();
            }
            else
            {
                txto.BackColor = Color.Red;
                txto.SelectAll();
            } 
      
        }

        private void txtp_TextChanged(object sender, EventArgs e)
        {
            if (txtp.Text == ("P"))
            {
                txtp.BackColor = Color.Green;
                txtq.Visible = Visible;
                txtq.Focus();
            }
            else
            {
                txtp.BackColor = Color.Red;
                txtp.SelectAll();
            } 
      
        }

        private void txtq_TextChanged(object sender, EventArgs e)
        {
            if (txtq.Text == ("Q"))
            {
                txtq.BackColor = Color.Green;
                txtr.Visible = Visible;
                txtr.Focus();
            }
            else
            {
                txtq.BackColor = Color.Red;
                txtq.SelectAll();
            } 
      
        }

        private void txtr_TextChanged(object sender, EventArgs e)
        {
            if (txtr.Text == ("R"))
            {
                txtr.BackColor = Color.Green;
                txts.Visible = Visible;
                txts.Focus();
            }
            else
            {
                txtr.BackColor = Color.Red;
                txtr.SelectAll();
            }
            }

        private void txts_TextChanged(object sender, EventArgs e)
        {
            if (txts.Text == ("S"))
            {
                txts.BackColor = Color.Green;
                txtt.Visible = Visible;
                txtt.Focus();
            }
            else
            {
                txts.BackColor = Color.Red;
                txts.SelectAll();
            } 
        
        }

        private void txtt_TextChanged(object sender, EventArgs e)
        {
            if (txtt.Text == ("T"))
            {
                txtt.BackColor = Color.Green;
                txtu.Visible = Visible;
                txtu.Focus();
            }
            else
            {
                txtt.BackColor = Color.Red;
                txtt.SelectAll();
            }
             
        }

        private void txtu_TextChanged(object sender, EventArgs e)
        {
            if (txtu.Text == ("U"))
            {
                txtu.BackColor = Color.Green;
                txtv.Visible = Visible;
                txtv.Focus();
            }
            else
            {
                txtu.BackColor = Color.Red;
                txtu.SelectAll();
            }
             
        }

        private void txtw_TextChanged(object sender, EventArgs e)
        {
            if (txtw.Text == ("W"))
            {
                txtw.BackColor = Color.Green;
                txtx.Visible = Visible;
                txtx.Focus();
            }
            else
            {
                txtw.BackColor = Color.Red;
                txtw.SelectAll();
            } 
        }

        private void txtx_TextChanged(object sender, EventArgs e)
        {
            if (txtx.Text == ("X"))
            {
                txtx.BackColor = Color.Green;
                txty.Visible = Visible;
                txty.Focus();
            }
            else
            {
                txtx.BackColor = Color.Red;
                txtx.SelectAll();
            } 
        }

        private void txty_TextChanged(object sender, EventArgs e)
        {
            if (txty.Text == ("Y"))
            {
                txty.BackColor = Color.Green;
                txtz.Visible = Visible;
                txtz.Focus();
            }
            else
            {
                txty.BackColor = Color.Red;
                txty.SelectAll();
            } 
        }

        private void txtz_TextChanged(object sender, EventArgs e)
        {
            if (txtz.Text == ("Z"))
            {
                txtz.BackColor = Color.Green;
                this.Hide();
                MessageBox.Show("parabens");
                new Form3().Show();
                
            }
            else
            {
                txtz.BackColor = Color.Red;
                txtz.SelectAll();
            } 
        }

        private void txtv_TextChanged(object sender, EventArgs e)
        {
            if (txtv.Text == ("V"))
            {
                txtv.BackColor = Color.Green;
                txtw.Visible = Visible;
                txtw.Focus();
            }
            else
            {
                txtv.BackColor = Color.Red;
                txtv.SelectAll();
            }
        }
    }
}
