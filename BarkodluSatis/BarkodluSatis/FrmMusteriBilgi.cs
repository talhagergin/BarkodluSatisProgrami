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
    public partial class FrmMusteriBilgi : Form
    {
        public FrmMusteriBilgi()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        public double _genelTutar { get; set; }
        public bool satismi { get; set; }
        public FrmMusteriBilgi(string genelTutar): this()
        {
            _genelTutar = Islemler.DoubleYap(genelTutar);
        }
        private void FrmMusteriBilgi_Load(object sender, EventArgs e)
        {
            txtMusteriSayisi.Text = db.MusteriBorcTakip.Count().ToString();
            MusteriGetir();
        }
       private void MusteriGetir()
            {
                using (var db = new BarkodDbEntities())
                {
                    MusteriBorcTakip musteri = new MusteriBorcTakip();
                    int? musteriNo = musteri.MusteriNo;
                    dgwMusteriler.DataSource = db.MusteriBorcTakip.ToList();
                    Islemler.GridDuzenle(dgwMusteriler);
                }
            }
  

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwMusteriler.Rows.Count > 0)
            {
                int musterino = Convert.ToInt32(dgwMusteriler.CurrentRow.Cells["MusteriNo"].Value.ToString());
                string ad = dgwMusteriler.CurrentRow.Cells["Ad"].Value.ToString();
                if (musterino != 0)
                {
                    FrmMusteriDetayGoster f = new FrmMusteriDetayGoster();
                    f.musterino = musterino;
                    f.ad = ad;
                    f.ShowDialog();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTelefon.Text != "" && txtMahalle.Text != "")
            {
                try
                {
                    //Eğer müşteri varsa güncelleyecek
                    //int? musteriNo = db.MusteriNumara.First().MusteriNo;
                    int musteriNo = Convert.ToInt32(txtMusteriNo.Text);
                        if (db.MusteriBorcTakip.Any(x => x.MusteriNo == musteriNo))
                        {
                            var guncelle = db.MusteriBorcTakip.Where(x => x.MusteriNo == musteriNo).SingleOrDefault();
                            guncelle.Ad = txtAd.Text;
                            guncelle.Soyad = txtSoyad.Text;
                            guncelle.Telefon = txtTelefon.Text;
                            guncelle.Mahalle = txtMahalle.Text;
                            db.SaveChanges();
                            dgwMusteriler.DataSource = db.MusteriBorcTakip.OrderByDescending(x => x.MusteriNo).Take(20).ToList();
                            Islemler.GridDuzenle(dgwMusteriler);
                        }
                        else //Eğer müşteri yoksa ekleyecek
                        {
                            MusteriBorcTakip musteri = new MusteriBorcTakip();
                            musteri.Ad = txtAd.Text;
                            musteri.Soyad = txtSoyad.Text;
                            musteri.Telefon = txtTelefon.Text;
                            musteri.Mahalle = txtMahalle.Text;
                            musteri.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                        var dateTime = DateTime.Now.GetRidOfSeconds();
                        musteri.OdemeTarihi = dateTime;
                            musteri.Odenen = 0;
                            musteri.GenelBorc = 0;
                            musteri.Kalan = 0;
                            db.MusteriBorcTakip.Add(musteri);
                            db.SaveChanges();
                            var ozelNumara = db.MusteriNumara.First();
                            ozelNumara.MusteriNo++;
                            db.SaveChanges();
                        }
                        Temizle();
                        MusteriGetir();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz");
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwMusteriler.Rows.Count > 0)
            {
                txtMusteriNo.Text = dgwMusteriler.CurrentRow.Cells["MusteriNo"].Value.ToString();
                txtAd.Text = dgwMusteriler.CurrentRow.Cells["Ad"].Value.ToString();
                txtSoyad.Text = dgwMusteriler.CurrentRow.Cells["Soyad"].Value.ToString();
                txtTelefon.Text = dgwMusteriler.CurrentRow.Cells["Telefon"].Value.ToString();
                txtMahalle.Text = dgwMusteriler.CurrentRow.Cells["Mahalle"].Value.ToString();
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            txtMusteriNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtMahalle.Clear();
        }
        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            var musteriNo = db.MusteriNumara.First().MusteriNo;
            txtMusteriNo.Text = musteriNo.ToString();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int musterino = Convert.ToInt32(dgwMusteriler.CurrentRow.Cells["MusteriNo"].Value.ToString());
            string musteriad = dgwMusteriler.CurrentRow.Cells["Ad"].Value.ToString();
            DialogResult onay = MessageBox.Show(musteriad + " adlı kullanıcıyı silmek istediğinizden emin misiniz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                var musteri = db.MusteriBorcTakip.Where(x => x.MusteriNo == musterino).SingleOrDefault();
                db.MusteriBorcTakip.Remove(musteri);
                db.SaveChanges();
                //var borc = db.Borc.Where(x => x.MusteriNo == musterino).SingleOrDefault();
                //db.Borc.Remove(borc);
                //db.SaveChanges();
                MessageBox.Show("Müşteri silinmiştir.");
            }
            MusteriGetir();
        }

        private void txtMusteriAra_TextChanged(object sender, EventArgs e)
        {
            if (txtMusteriAra.Text.Length >= 3)
            {
                string musteriad = txtMusteriAra.Text;
                string mahalle = txtMusteriAra.Text;
                using (var db = new BarkodDbEntities())
                {
                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        db.MusteriBorcTakip.Where(x => x.Mahalle.Contains(mahalle)).ToList();
                        dgwMusteriler.DataSource = db.MusteriBorcTakip.Local.ToList();
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        db.MusteriBorcTakip.Where(x => x.Ad.Contains(musteriad)).ToList();
                        dgwMusteriler.DataSource = db.MusteriBorcTakip.Local.ToList();
                    }
                    else { MessageBox.Show("Lütfen arama kategorinizi seçiniz..."); }
                }
                Islemler.GridDuzenle(dgwMusteriler);
            }
            else { dgwMusteriler.DataSource = db.MusteriBorcTakip.ToList(); }
        }

        private void dgwMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (satismi)//eğer satış ekranından geldiyse 
            {

                int musterino = Convert.ToInt32(dgwMusteriler.CurrentRow.Cells["MusteriNo"].Value.ToString());
                string ad = dgwMusteriler.CurrentRow.Cells["Ad"].Value.ToString();
                string soyad = dgwMusteriler.CurrentRow.Cells["Soyad"].Value.ToString();
                string telefon = dgwMusteriler.CurrentRow.Cells["Telefon"].Value.ToString();
                string mahalle = dgwMusteriler.CurrentRow.Cells["Mahalle"].Value.ToString();
                double genelborc = Convert.ToDouble(dgwMusteriler.CurrentRow.Cells["GenelBorc"].Value.ToString());
                double odenen = Convert.ToDouble(dgwMusteriler.CurrentRow.Cells["Odenen"].Value.ToString());
                double kalan = Convert.ToDouble(dgwMusteriler.CurrentRow.Cells["kalan"].Value.ToString());
                double eklenecekTutar = _genelTutar;
                DialogResult onay = MessageBox.Show(ad + " adlı kullanıcıyı seçmek istediğinizden emin misiniz?", "Ürün Veresiye Satış İşlemi", MessageBoxButtons.YesNo);
                if (_genelTutar != 0)
                {
                    if (onay == DialogResult.Yes)//seçilen müşteri onaylandığında satış gerçekleşecek
                    {
                        FrmSatis f = (FrmSatis)Application.OpenForms["FrmSatis"];
                        f._musteriNo = musterino;
                        f.SatisYap("Veresiye");
                        using (var db = new BarkodDbEntities())
                        {
                            var guncelle = db.MusteriBorcTakip.Where(x => x.MusteriNo == musterino).FirstOrDefault();
                            guncelle.GenelBorc += eklenecekTutar;
                            guncelle.Kalan += eklenecekTutar;
                            db.SaveChanges();

                            BorcOzet borcOzet = new BorcOzet();
                            borcOzet.MusteriNo = musterino;
                            borcOzet.Ad = ad;
                            borcOzet.Soyad = soyad;
                            var dateTime = DateTime.Now.GetRidOfSeconds();
                            borcOzet.Tarih = dateTime;
                            borcOzet.Eklenen = eklenecekTutar;
                            borcOzet.Kalan += eklenecekTutar;
                            db.BorcOzet.Add(borcOzet);
                            db.SaveChanges();
                        }
                        this.Hide();
                    }
                }
                else { MessageBox.Show("Lütfen satmak istediğiniz ürünleri seçiniz..."); }
            }
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int musterino = Convert.ToInt32(dgwMusteriler.CurrentRow.Cells["MusteriNo"].Value.ToString());
            string musteriAd = dgwMusteriler.CurrentRow.Cells["Ad"].Value.ToString();
            string musteriSoyad = dgwMusteriler.CurrentRow.Cells["Soyad"].Value.ToString();
            double genelBorc = Islemler.DoubleYap(dgwMusteriler.CurrentRow.Cells["GenelBorc"].Value.ToString());
            double kalanBorc = Islemler.DoubleYap(dgwMusteriler.CurrentRow.Cells["Kalan"].Value.ToString());
            FrmMusteriOdemeAlma f = new FrmMusteriOdemeAlma();
            f._musteriNo = musterino;
            f._musteriAd = musteriAd;
            f._musteriSoyad = musteriSoyad;
            f._genelBorc = genelBorc;
            f._kalanBorc = kalanBorc;
            f.ShowDialog();
            this.Hide();
        }
    }
}   
