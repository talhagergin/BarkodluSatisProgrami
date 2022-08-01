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
    public partial class FrmFirma : Form
    {
        public FrmFirma()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        private void FrmFirma_Load(object sender, EventArgs e)
        {
            txtFirmaSayisi.Text = db.FirmaBilgi.Count().ToString();
            FirmaGetir();
        }
        private void FirmaGetir()
        {
            using (var db = new BarkodDbEntities())
            {
                FirmaBilgi firma = new FirmaBilgi();
                int? firmaNo = firma.FirmaId;
                dgwFirma.DataSource = db.FirmaBilgi.ToList();
                Islemler.GridDuzenle(dgwFirma);
            }           
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            double _genelborc = Islemler.DoubleYap(txtGenelBorc.Text);
            double _odenen = Islemler.DoubleYap(txtOdenen.Text);
            double _kalan = _genelborc - _odenen;
            if (btnKaydet.Text == "Kaydet")
            {
                if (txtFirmaAd.Text != "" && txtTelefon.Text != "" && txtIl.Text != "" && txtIlce.Text != "" && txtGenelBorc.Text != "" && txtOdenen.Text != "" && txtKalan.Text != "")
                {
                    try
                    {
                        using (var db = new BarkodDbEntities())
                        {
                            if (!db.FirmaBilgi.Any(x => x.FirmaAd == txtFirmaAd.Text))
                            {
                                FirmaBilgi firma = new FirmaBilgi();
                                firma.FirmaAd = txtFirmaAd.Text;
                                firma.Telefon = txtTelefon.Text;
                                firma.Ilce = txtIlce.Text;
                                firma.Il = txtIl.Text;
                                firma.Aciklama = txtAciklama.Text;
                                firma.GenelBorc = _genelborc;
                                firma.Odenen = _odenen;
                                firma.Kalan = _kalan;
                                db.FirmaBilgi.Add(firma);
                                db.SaveChanges();
                                FirmaGetir();
                                Temizle();
                            }
                            else
                            {
                                MessageBox.Show("Bu firma zaten kayıtlı");
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
                    MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz");
                }
            }
            else if (btnKaydet.Text == "Düzenle/Kaydet")
            {
                if (txtFirmaAd.Text != "" && txtTelefon.Text != "" && txtIl.Text != "" && txtIlce.Text != "" && txtGenelBorc.Text != "" && txtOdenen.Text != "" && txtKalan.Text != "")
                {
                    int id = Convert.ToInt32(lblKullaniciId.Text);
                    using (var db = new BarkodDbEntities())
                    {
                        var guncelle = db.FirmaBilgi.Where(x => x.FirmaId == id).FirstOrDefault();
                        guncelle.FirmaAd = txtFirmaAd.Text;
                        guncelle.Telefon = txtTelefon.Text;
                        guncelle.Il = txtIl.Text;
                        guncelle.Ilce = txtIlce.Text;
                        guncelle.Aciklama = txtAciklama.Text;
                        guncelle.GenelBorc = Islemler.DoubleYap(txtGenelBorc.Text);
                        guncelle.Kalan = Islemler.DoubleYap(txtKalan.Text);
                        guncelle.Odenen = Islemler.DoubleYap(txtOdenen.Text);
                        db.SaveChanges();
                        MessageBox.Show("Güncelleme yapılmıştır");
                        btnKaydet.Text = "Kaydet";
                        Temizle();
                        FirmaGetir();
                    }
                }
            }
        }
        private void Temizle()
        {
            txtFirmaAd.Clear();
            txtTelefon.Clear();
            txtIl.Clear();
            txtIlce.Clear();
            txtGenelBorc.Clear();
            txtKalan.Clear();
            txtOdenen.Clear();
            txtAciklama.Clear();
            txtFirmaAd.Focus();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwFirma.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dgwFirma.CurrentRow.Cells["FirmaId"].Value.ToString());
                lblKullaniciId.Text = id.ToString();
                using (var db = new BarkodDbEntities())
                {
                    var getir = db.FirmaBilgi.Where(x => x.FirmaId == id).FirstOrDefault();
                    txtFirmaAd.Text = getir.FirmaAd;
                    txtTelefon.Text = getir.Telefon;
                    txtIl.Text = getir.Il;
                    txtIlce.Text = getir.Ilce;
                    txtGenelBorc.Text = getir.GenelBorc.ToString();
                    txtOdenen.Text = getir.Odenen.ToString();
                    txtKalan.Text = getir.Kalan.ToString();
                    btnKaydet.Text = "Düzenle/Kaydet";
                    FirmaGetir();
                }
            }
            else
            {
                MessageBox.Show("Kullanici seçiniz!");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int firmaid = Convert.ToInt32(dgwFirma.CurrentRow.Cells["FirmaId"].Value.ToString());
            string firmaad = dgwFirma.CurrentRow.Cells["FirmaAd"].Value.ToString();
            DialogResult onay = MessageBox.Show(firmaad + " firmasını silmek istiyor musunuz ?", "Firma Silme İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                var firma = db.FirmaBilgi.Find(firmaid);
                db.FirmaBilgi.Remove(firma);
                db.SaveChanges();
                MessageBox.Show("Firma silinmiştir");
                dgwFirma.DataSource = db.FirmaBilgi.OrderByDescending(a => a.FirmaId).Take(20).ToList();
                Islemler.GridDuzenle(dgwFirma);
                Temizle();
            }
        }

        private void btnBorcEkle_Click(object sender, EventArgs e)
        {
            double _genelborc = Islemler.DoubleYap(txtGenelBorc.Text);
            double odeme;
            string aciklama;
            FrmGelirGider f = new FrmGelirGider();
            f.gelirgider = "GİDER";
            //f.kullanici = lblKullanici.Text;
            f.ShowDialog();
            odeme = f.tutar+f.tutar2;
            aciklama = f.aciklama;
            if(odeme!=0)
            {
                txtKalan.Text = (Islemler.DoubleYap(txtKalan.Text) + odeme).ToString();
                txtGenelBorc.Text = (_genelborc + odeme).ToString();

                int id = Convert.ToInt32(lblKullaniciId.Text);
                using (var db = new BarkodDbEntities())
                {
                    var guncelle = db.FirmaBilgi.Where(x => x.FirmaId == id).FirstOrDefault();
                    guncelle.FirmaAd = txtFirmaAd.Text;
                    guncelle.Telefon = txtTelefon.Text;
                    guncelle.Il = txtIl.Text;
                    guncelle.Ilce = txtIlce.Text;
                    guncelle.Aciklama = txtAciklama.Text;
                    guncelle.GenelBorc = Islemler.DoubleYap(txtGenelBorc.Text);
                    guncelle.Kalan = Islemler.DoubleYap(txtGenelBorc.Text) - Islemler.DoubleYap(txtOdenen.Text);
                    guncelle.Odenen = Islemler.DoubleYap(txtOdenen.Text);
                    db.SaveChanges();
                    MessageBox.Show("Güncelleme yapılmıştır");
                    int? borcnNo = db.FirmaBorcNo.First().BorcnNo;
                    FirmaBorc firma = new FirmaBorc();
                    firma.BorcNo = borcnNo;
                    firma.FirmaId = guncelle.FirmaId;
                    firma.FirmaAd = txtFirmaAd.Text;
                    firma.Tarih = DateTime.Now;
                    firma.Aciklama = aciklama;
                    firma.ToplamTutar = odeme;

                    db.FirmaBorc.Add(firma);
                    db.SaveChanges();
                    var borcNoArttir = db.FirmaBorcNo.First();
                    borcNoArttir.BorcnNo += 1;
                    db.SaveChanges();

                    btnKaydet.Text = "Kaydet";
                    Temizle();
                    FirmaGetir();
                }
            }
            else { MessageBox.Show("Bir miktar girilmedi"); }
            
            
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            Temizle();
            btnKaydet.Text = "Kaydet";
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            double _genelborc = Islemler.DoubleYap(txtGenelBorc.Text);
            double odeme;
            string aciklama;
            FrmGelirGider f = new FrmGelirGider();
            f.gelirgider = "GİDER";
            //f.kullanici = lblKullanici.Text;
            f.ShowDialog();
            odeme = f.tutar + f.tutar2;
            aciklama = f.aciklama;
            if (odeme != 0)
            {
                txtKalan.Text = (Islemler.DoubleYap(txtKalan.Text) - odeme).ToString();
              //  txtGenelBorc.Text = (_genelborc - odeme).ToString();
                txtOdenen.Text = (Islemler.DoubleYap(txtOdenen.Text) + odeme).ToString();

                int id = Convert.ToInt32(lblKullaniciId.Text);
                using (var db = new BarkodDbEntities())
                {
                    var guncelle = db.FirmaBilgi.Where(x => x.FirmaId == id).FirstOrDefault();
                    guncelle.FirmaAd = txtFirmaAd.Text;
                    guncelle.Telefon = txtTelefon.Text;
                    guncelle.Il = txtIl.Text;
                    guncelle.Ilce = txtIlce.Text;
                    guncelle.Aciklama = txtAciklama.Text;
                    guncelle.GenelBorc = Islemler.DoubleYap(txtGenelBorc.Text);
                    guncelle.Kalan = Islemler.DoubleYap(txtGenelBorc.Text) - Islemler.DoubleYap(txtOdenen.Text);
                    guncelle.Odenen = Islemler.DoubleYap(txtOdenen.Text);
                    db.SaveChanges();
                    MessageBox.Show("Güncelleme yapılmıştır");
                    int? borcnNo = db.FirmaBorcNo.First().BorcnNo;
                    FirmaBorc firma = new FirmaBorc();
                    firma.BorcNo = borcnNo;
                    firma.FirmaId = guncelle.FirmaId;
                    firma.FirmaAd = txtFirmaAd.Text;
                    firma.Tarih = DateTime.Now;
                    firma.Aciklama = aciklama;
                    firma.ToplamTutar = odeme;

                    db.FirmaBorc.Add(firma);
                    db.SaveChanges();
                    var borcNoArttir = db.FirmaBorcNo.First();
                    borcNoArttir.BorcnNo += 1;
                    db.SaveChanges();

                    btnKaydet.Text = "Kaydet";
                    Temizle();
                    FirmaGetir();
                }
            }
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwFirma.Rows.Count > 0)
            {
                if (txtFirmaAd.Text != "")
                {
                    int firmaid = Convert.ToInt32(lblKullaniciId.Text);
                    var islemno = db.FirmaBorc.Where(x => x.FirmaId == firmaid).FirstOrDefault();
                    int? borcnno = islemno.BorcNo;
                    if (borcnno != 0)
                    {
                        FrmFirmaBorcDetay f = new FrmFirmaBorcDetay();
                        f.borcnno = (int)borcnno;
                        f.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Firma seçiniz");
                }
            }
        }

        private void txtFirmaAra_TextChanged(object sender, EventArgs e)
        {
            if (txtFirmaAra.Text.Length >= 2)
            {
                string firmaad = txtFirmaAra.Text;
                var firmalar = db.FirmaBilgi.Where(a => a.FirmaAd.Contains(firmaad)).ToList();
                dgwFirma.DataSource = firmalar;
                Islemler.GridDuzenle(dgwFirma);
            }
            Islemler.GridDuzenle(dgwFirma);
            }
        }
    }
