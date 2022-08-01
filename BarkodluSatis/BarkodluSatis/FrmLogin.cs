using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lisans;
namespace BarkodluSatis
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }
        private void GirisYap()
        {
            if (txtKullaniciAd.Text != "" && txtSifre.Text != "")
            {
                try
                {
                    using (var db = new BarkodDbEntities())
                    {
                        if (db.Kullanici.Any())
                        {
                            var bak = db.Kullanici.Where(x => x.KullaniciAd == txtKullaniciAd.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
                            if (bak != null)
                            {
                                Cursor.Current = Cursors.WaitCursor;

                                GuvenlikKontrol kontrol = new GuvenlikKontrol();
                                if(kontrol.KontrolYap())
                                {
                                FrmBaslangic f = new FrmBaslangic();
                                f.btnSatisIslemi.Enabled = (bool)bak.Satis;
                                f.btnGenelRapor.Enabled = (bool)bak.Rapor;
                                f.btnStokTakibi.Enabled = (bool)bak.Stok;
                                f.btnUrunGiris.Enabled = (bool)bak.UrunGiris;
                                f.btnAyarlar.Enabled = (bool)bak.Ayarlar;
                                f.btnFiyatGüncelle.Enabled = (bool)bak.FiyatGuncelle;
                                f.btnYedekleme.Enabled = (bool)bak.Yedekleme;
                                f.lblKullanici.Text = bak.AdSoyad;
                                f.Show();
                                this.Hide();
                                }

                              


                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı giriş");
                            }
                        }
                        else
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            Kullanici k = new Kullanici();
                            k.AdSoyad = "admin";
                            k.Ayarlar = true;
                            k.EPosta = "eposta";
                            k.FiyatGuncelle = true;
                            k.KullaniciAd = "admin";
                            k.Rapor = true;
                            k.Satis = true;
                            k.Sifre = "admin";
                            k.Stok = true;
                            k.Telefon = "telefon";
                            k.UrunGiris = true;
                            k.Yedekleme = true;
                            db.Kullanici.Add(k);
                            db.SaveChanges();

                            var bak = db.Kullanici.Where(x => x.KullaniciAd == txtKullaniciAd.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
                            FrmBaslangic f = new FrmBaslangic();
                            f.btnSatisIslemi.Enabled = (bool)bak.Satis;
                            f.btnGenelRapor.Enabled = (bool)bak.Rapor;
                            f.btnStokTakibi.Enabled = (bool)bak.Stok;
                            f.btnUrunGiris.Enabled = (bool)bak.UrunGiris;
                            f.btnAyarlar.Enabled = (bool)bak.Ayarlar;
                            f.btnFiyatGüncelle.Enabled = (bool)bak.FiyatGuncelle;
                            f.btnYedekleme.Enabled = (bool)bak.Yedekleme;
                            f.lblKullanici.Text = bak.AdSoyad;
                            var isyeri = db.Sabit.FirstOrDefault();
                            f.lblIsYeri.Text = isyeri.Unvan;
                            f.Show();
                            this.Hide();
                            Cursor.Current = Cursors.Default;

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                GirisYap();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lic lic = new Lic();
            label1.Text = lic.CpuNo() + "\n" + lic.CpuKarakterToplam().ToString();

        }
    }
}
