using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
            txtKullaniciAd.Clear();
            txtSifre.Clear();
            chbSatis.Checked = false;
            chbRapor.Checked = false;
            chbStok.Checked = false;
            chbUrunGiris.Checked = false;
            chbAyarlar.Checked = false;
            chbFiyatGuncelle.Checked = false;
            chbYedekleme.Checked = false;
            txtSifre2.Clear();
            txtisyeriAdsoyad.Clear();
            txtisyeriunvan.Clear();
            txtisyeriAdres.Clear();
            txtisyeriEposta.Clear();
            txtisyeriTelefon.Clear();


        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (btnKaydet.Text == "Kaydet")
            {
                if (txtAdSoyad.Text != "" && txtTelefon.Text != "" && txtKullaniciAd.Text != "" && txtSifre.Text != "" && txtSifre2.Text != "")
                {
                    if (txtSifre.Text == txtSifre2.Text)
                    {
                        try
                        {
                            using (var db = new BarkodDbEntities())
                            {
                                if (!db.Kullanici.Any(x => x.KullaniciAd == txtKullaniciAd.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad = txtAdSoyad.Text;
                                    k.Telefon = txtTelefon.Text;
                                    k.EPosta = txtEposta.Text;
                                    k.KullaniciAd = txtKullaniciAd.Text.Trim();
                                    k.Sifre = txtSifre.Text;
                                    k.Satis = chbSatis.Checked;
                                    k.Rapor = chbRapor.Checked;
                                    k.Stok = chbStok.Checked;
                                    k.UrunGiris = chbUrunGiris.Checked;
                                    k.Ayarlar = chbAyarlar.Checked;
                                    k.FiyatGuncelle = chbFiyatGuncelle.Checked;
                                    k.Yedekleme = chbYedekleme.Checked;
                                    k.Musteri = chbMusteri.Checked;
                                    k.Firma = chbFirma.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    Doldur();
                                    Temizle();


                                }
                                else
                                {
                                    MessageBox.Show("Bu kullanıcı zaten kayıtlı");
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("HATA OLUŞTU " + ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen zorunlu bilgileri giriniz!" + "\nAd Soyad\nTelefon\nKullanıcı Adı\nŞifre\nŞifre Tekrar");

                }
            }
            else if (btnKaydet.Text == "Düzenle/Kaydet")
            {
                if (txtAdSoyad.Text != "" && txtTelefon.Text != "" && txtKullaniciAd.Text != "" && txtSifre.Text != "" && txtSifre2.Text != "")
                {
                    if (txtSifre.Text == txtSifre2.Text)
                    {
                        int id = Convert.ToInt32(lblKullaniciId.Text);
                        using (var db = new BarkodDbEntities())
                        {
                            var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.AdSoyad = txtAdSoyad.Text;
                            guncelle.Telefon = txtTelefon.Text;
                            guncelle.EPosta = txtEposta.Text;
                            guncelle.KullaniciAd = txtKullaniciAd.Text.Trim();
                            guncelle.Sifre = txtSifre.Text;
                            guncelle.Satis = chbSatis.Checked;
                            guncelle.Rapor = chbRapor.Checked;
                            guncelle.Stok = chbStok.Checked;
                            guncelle.UrunGiris = chbUrunGiris.Checked;
                            guncelle.Ayarlar = chbAyarlar.Checked;
                            guncelle.FiyatGuncelle = chbFiyatGuncelle.Checked;
                            guncelle.Yedekleme = chbYedekleme.Checked;
                            db.SaveChanges();
                            MessageBox.Show("Güncelleme yapılmıştır");
                            btnKaydet.Text = "Kaydet";
                            Temizle();
                            Doldur();
                        }
                    }
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwListeKullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dgwListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lblKullaniciId.Text = id.ToString();
                using (var db = new BarkodDbEntities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    txtAdSoyad.Text = getir.AdSoyad;
                    txtTelefon.Text = getir.Telefon;
                    txtEposta.Text = getir.EPosta;
                    txtKullaniciAd.Text = getir.KullaniciAd;
                    txtSifre.Text = getir.Sifre;
                    txtSifre2.Text = getir.Sifre;
                    chbSatis.Checked = (bool)getir.Satis;
                    chbRapor.Checked = (bool)getir.Rapor;
                    chbUrunGiris.Checked = (bool)getir.UrunGiris;
                    chbAyarlar.Checked = (bool)getir.Ayarlar;
                    chbFiyatGuncelle.Checked = (bool)getir.FiyatGuncelle;
                    chbYedekleme.Checked = (bool)getir.Yedekleme;
                    btnKaydet.Text = "Düzenle/Kaydet";
                    Doldur();
                }
            }
            else
            {
                MessageBox.Show("Kullanici seçiniz!");
            }
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Doldur();
            Cursor.Current = Cursors.Default;
        }
        private void Doldur()
        {
            using (var db = new BarkodDbEntities())
            {
                if (db.Kullanici.Any())
                {
                    dgwListeKullanici.DataSource = db.Kullanici.Select(x => new { x.Id, x.AdSoyad, x.KullaniciAd, x.Telefon }).ToList();
                }
                Islemler.SabitVarsayılan();
                var yazici = db.Sabit.FirstOrDefault();
                chbYazmaDurumu.Checked = Convert.ToBoolean(yazici.Yazici);

                var sabitler = db.Sabit.FirstOrDefault();
                txtKartKomisyon.Text = sabitler.KartKomisyon.ToString();

                var terazionek = db.Terazi.ToList();
                cmbOnEk.DisplayMember = "TeraziOnEk";
                cmbOnEk.ValueMember = "Id";
                cmbOnEk.DataSource = terazionek;

                txtisyeriAdsoyad.Text = sabitler.AdSoyad;
                txtisyeriunvan.Text = sabitler.Unvan;
                txtisyeriAdres.Text = sabitler.Adres;
                txtisyeriTelefon.Text = sabitler.Telefon;
                txtisyeriEposta.Text = sabitler.Eposta;

            }
        }

        private void chbYazmaDurumu_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new BarkodDbEntities())
            {
                if (chbYazmaDurumu.Checked)
                {
                    chbYazmaDurumu.BackColor = Color.DarkKhaki;
                    Islemler.SabitVarsayılan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = true;
                    db.SaveChanges();
                    chbYazmaDurumu.Text = "Yazma Durumu AKTİF";
                }
                else
                {
                    chbYazmaDurumu.BackColor = Color.Red;
                    Islemler.SabitVarsayılan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = false;
                    db.SaveChanges();
                    chbYazmaDurumu.Text = "Yazma Durumu PASİF";
                }
            }
        }

        private void btnKartKomisyonAyarla_Click(object sender, EventArgs e)
        {
            if (txtKartKomisyon.Text != "")
            {
                using (var db = new BarkodDbEntities())
                {
                    var sabit = db.Sabit.FirstOrDefault();
                    sabit.KartKomisyon = Convert.ToInt16(txtKartKomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart komisyon ayarlandı");
                }

            }
            else
            {
                MessageBox.Show("Kart komisyon bilgisini giriniz");
            }

        }

        private void btnOnEkKaydet_Click(object sender, EventArgs e)
        {
            if (txtOnEk.Text != "")
            {
                int onek = Convert.ToInt16(txtOnEk.Text);
                using (var db = new BarkodDbEntities())
                {
                    if (db.Terazi.Any(x => x.TeraziOnEk == onek))
                    {
                        MessageBox.Show(onek.ToString() + " ön ek zaten kayıtlı");
                    }
                    else
                    {
                        Terazi t = new Terazi();
                        t.TeraziOnEk = onek;
                        db.Terazi.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler kaydedilmiştir");
                        cmbOnEk.DisplayMember = "TeraziOnEk";
                        cmbOnEk.ValueMember = "Id";
                        cmbOnEk.DataSource = db.Terazi.ToList();
                        txtOnEk.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi ön ek bilgisini giriniz");
            }
        }

        private void btnOnEkSil_Click(object sender, EventArgs e)
        {
            if (cmbOnEk.Text != "")
            {
                int onekid = Convert.ToInt16(cmbOnEk.SelectedValue);
                DialogResult onay = MessageBox.Show(cmbOnEk.Text + " ön eki silmek istiyor musunuz?", "Terazi Önek Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    using (var db = new BarkodDbEntities())
                    {
                        var onek = db.Terazi.Find(onekid);
                        db.Terazi.Remove(onek);
                        db.SaveChanges();
                        cmbOnEk.DisplayMember = "TeraziOnEk";
                        cmbOnEk.ValueMember = "Id";
                        cmbOnEk.DataSource = db.Terazi.ToList();
                        MessageBox.Show("Ön-ek silinmiştir");

                    }
                }
                else
                {
                    MessageBox.Show("Ön-ek seçinizi!");
                }
            }
        }

        private void btnIsyeriKaydet_Click(object sender, EventArgs e)
        {
            if (txtisyeriAdsoyad.Text != "" && txtisyeriunvan.Text != "" && txtisyeriAdres.Text != "" && txtisyeriTelefon.Text != "")
            {
                using (var db = new BarkodDbEntities())
                {
                    var isyeri = db.Sabit.FirstOrDefault();
                    isyeri.AdSoyad = txtisyeriAdsoyad.Text;
                    isyeri.Unvan = txtisyeriunvan.Text;
                    isyeri.Adres = txtisyeriAdres.Text;
                    isyeri.Telefon = txtisyeriTelefon.Text;
                    isyeri.Eposta = txtisyeriEposta.Text;
                    db.SaveChanges();
                    MessageBox.Show("Bilgiler başarıyla kaydedilmiştir");
                    var yeni = db.Sabit.FirstOrDefault();
                    txtisyeriAdsoyad.Text = isyeri.AdSoyad;
                    txtisyeriunvan.Text = isyeri.Unvan;
                    txtisyeriAdres.Text = isyeri.Adres;
                    txtisyeriTelefon.Text = isyeri.Telefon;
                    txtisyeriEposta.Text = isyeri.Eposta;

                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz!");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e) // duruma göre bunu silebilirim
        {
            Temizle();
        }

        private void btnYedekten_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\ProgramRestore.exe");
            Application.Exit();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int kullaniciid = Convert.ToInt32(dgwListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
            string kullaniciad = dgwListeKullanici.CurrentRow.Cells["AdSoyad"].Value.ToString();
            DialogResult onay = MessageBox.Show(kullaniciad + " kullanıcıyı silmek istiyor musunuz ?", "Kullanıcı Silme İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                using (var db = new BarkodDbEntities())
                {
                    var urun = db.Kullanici.Find(kullaniciid);
                    db.Kullanici.Remove(urun);
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı silinmiştir");
                    dgwListeKullanici.DataSource = db.Kullanici.OrderByDescending(a => a.Id).Take(20).ToList();
                    Islemler.GridDuzenle(dgwListeKullanici);
                    Temizle();
                }
            }
        }
    }
}
