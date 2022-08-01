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
    public partial class FrmBaslangic : Form
    {
        public FrmBaslangic()
        {
            InitializeComponent();
        }

        private void btnSatisIslemi_Click(object sender, EventArgs e)
        {
            Cursor.Current=Cursors.WaitCursor;
            FrmSatis f = new FrmSatis();
            f.lblKullanici.Text = lblKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
           
        }

        private void btnGenelRapor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmRapor f = new FrmRapor();
            f.lblKullanici.Text = lblKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btnStokTakibi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmStok f = new FrmStok();
            f.lblKullanici.Text = lblKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmUrunGiris f = new FrmUrunGiris();
            f.lblKullanici.Text = lblKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFiyatGüncelle_Click(object sender, EventArgs e)
        {
            FrmFiyatGuncelle d = new FrmFiyatGuncelle();
            d.lblkullanici.Text = lblKullanici.Text;
            d.ShowDialog();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FrmAyarlar f = new FrmAyarlar();
            f.lblKullanici.Text = lblKullanici.Text;
            f.ShowDialog();
        }

        private void btnYedekleme_Click(object sender, EventArgs e)
        {
            Islemler.BackUp();
        }

        private void btnKullaniciDegistir_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriBilgi musteri = new FrmMusteriBilgi();
            musteri.ShowDialog();        
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            FrmFirma f = new FrmFirma();
            f.ShowDialog();
        }
    }
}
