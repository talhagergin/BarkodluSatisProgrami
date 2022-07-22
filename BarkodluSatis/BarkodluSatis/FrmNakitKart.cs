using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class FrmNakitKart : Form
    {
        public FrmNakitKart()
        {
            InitializeComponent();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtNakit.Text!="")
            {
                if (e.KeyCode == Keys.Enter) 
                {
                    Hesapla();
                }
            }
        }
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = txtNakit.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    txtNakit.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (txtNakit.Text.Length > 0)
                {
                    txtNakit.Text = txtNakit.Text.Substring(0, txtNakit.Text.Length - 1);
                }
            }
            else
            {
                txtNakit.Text += b.Text;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtNakit.Text!="")
            {
                Hesapla();
            }
        }
        private void Hesapla()
        {
            FrmSatis f = (FrmSatis)Application.OpenForms["FrmSatis"];
            double nakit = Islemler.DoubleYap(txtNakit.Text);
            double geneltoplam = Islemler.DoubleYap(f.txtGenelToplam.Text);
            double kart = geneltoplam - nakit;
            f.lblNakit.Text = nakit.ToString("C2");
            f.lblKart.Text = kart.ToString("C2");
            f.SatisYap("Kart-Nakit");
            this.Hide();
        }

        private void txtNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)==false && e.KeyChar!=(char)08)
            {
                e.Handled=true;
            }
        }
    }
}
