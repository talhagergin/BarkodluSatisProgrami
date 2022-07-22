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
    public partial class FrmUrunGiris : Form
    {
        public FrmUrunGiris()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        private void txtBakod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                string barkod = txtBakod.Text.Trim();
                if(db.Urun.Any(a=>a.Barkod==barkod))
                {
                    var urun = db.Urun.Where(a => a.Barkod == barkod).SingleOrDefault();
                    txtUrunAd.Text = urun.UrunAd;
                    txtAciklama.Text = urun.Aciklama;
                    cmbUrunGrup.Text = urun.UrunGrup;
                    txtAlisFiyat.Text = urun.AlisFiyat.ToString();
                    txtSatisFiyat.Text = urun.SatisFiyat.ToString();
                    txtMiktar.Text=urun.Miktar.ToString();
                    txtKdvOrani.Text = urun.KdvOrani.ToString();
                    if(urun.Birim=="Kg")
                    {
                        cbUrunTipi.Checked = true;
                    }
                    else
                    {
                        cbUrunTipi.Checked = false;
                    }
                
                }
                else
                {
                    MessageBox.Show("Ürün Kayıtlı Değil Kaydedebilirsiniz...");
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtBakod.Text!="" && txtUrunAd.Text!="" && cmbUrunGrup.Text!=""&& txtSatisFiyat.Text!=""&& txtAlisFiyat.Text!="" && txtMiktar.Text!=""&&txtKdvOrani.Text!="")
            {
                if (db.Urun.Any(a => a.Barkod == txtBakod.Text))
                {
                    var guncelle = db.Urun.Where(a => a.Barkod == txtBakod.Text).SingleOrDefault();
                    guncelle.UrunAd = txtUrunAd.Text;
                    guncelle.Aciklama = txtAciklama.Text;
                    guncelle.UrunGrup = cmbUrunGrup.Text;
                    guncelle.AlisFiyat = Convert.ToDouble(txtAlisFiyat.Text);
                    guncelle.SatisFiyat = Convert.ToDouble(txtSatisFiyat.Text);
                    guncelle.KdvTutari = Math.Round(Islemler.DoubleYap(txtSatisFiyat.Text) * Convert.ToInt32(txtKdvOrani.Text) / 100, 2);
                    guncelle.Miktar += Convert.ToDouble(txtMiktar.Text);
                    guncelle.Onay = true;
                    if(cbUrunTipi.Checked)
                    {
                        guncelle.Birim = "Kg";
                    }
                    else
                    {
                        guncelle.Birim = "Adet";
                    }                    
                    guncelle.Tarih = DateTime.Now;
                    guncelle.Kullanici = lblKullanici.Text;
                    db.SaveChanges();
                    dgwUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                    Islemler.GridDuzenle(dgwUrunler);
                }
                else
                {
                    Urun urun = new Urun();
                    urun.Barkod = txtBakod.Text;
                    urun.UrunAd = txtUrunAd.Text;
                    urun.Aciklama = txtAciklama.Text;
                    urun.UrunGrup = cmbUrunGrup.Text;
                    urun.AlisFiyat = Convert.ToDouble(txtAlisFiyat.Text);
                    urun.SatisFiyat = Convert.ToDouble(txtSatisFiyat.Text);
                    urun.KdvOrani= Convert.ToDouble(txtKdvOrani.Text);
                    urun.KdvTutari = Math.Round(Islemler.DoubleYap(txtSatisFiyat.Text) * Convert.ToInt32(txtKdvOrani.Text) / 100, 2);
                    urun.Miktar = Convert.ToDouble(txtMiktar.Text);
                    urun.Onay = true;
                    if(cbUrunTipi.Checked)
                    {
                        urun.Birim = "Kg";
                    }
                    else
                    {
                        urun.Birim = "Adet";
                    }                    
                    urun.Tarih = DateTime.Now;
                    urun.Kullanici = lblKullanici.Text;
                    db.Urun.Add(urun);
                    db.SaveChanges();
                    if(txtBakod.Text.Length==8)
                    {
                        var ozelbarkod = db.Barkod.First();
                        ozelbarkod.BarkodNo += 1;
                        db.SaveChanges();
                    }

                    

                    dgwUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
                    Islemler.GridDuzenle(dgwUrunler);
                }
                Islemler.StokHareket(txtBakod.Text, txtUrunAd.Text, "Adet", Convert.ToDouble(txtMiktar.Text), cmbUrunGrup.Text, lblKullanici.Text);
                Temizle();
            }
            else
            {
                MessageBox.Show("Bilgileri kontrol ediniz!");
                txtBakod.Focus();
            }
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if(txtUrunAra.Text.Length>=2)
            {
                string urunad = txtUrunAra.Text;
                var urunler = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
                dgwUrunler.DataSource = urunler;
                Islemler.GridDuzenle(dgwUrunler);
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            txtBakod.Clear();
            txtUrunAd.Clear();
            txtAciklama.Clear();
            txtAlisFiyat.Text = "0";
            txtSatisFiyat.Text = "0";
            txtMiktar.Text = "0";
            txtKdvOrani.Text = "8";
            txtBakod.Focus();
            cbUrunTipi.Checked = false;
        }

        private void FrmUrunGiris_Load(object sender, EventArgs e)
        {
            txtUrunSayisi.Text = db.Urun.Count().ToString();
            dgwUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
            Islemler.GridDuzenle(dgwUrunler);
            GrupDoldur();
            txtBakod.Focus();
        }
        public void GrupDoldur()
        {
            cmbUrunGrup.DisplayMember = "UrunGrupAd";
            cmbUrunGrup.ValueMember = "Id";
            cmbUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }
        private void txtBakod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void btnuUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrunGrubuEkle f = new FrmUrunGrubuEkle();
            f.ShowDialog();
        }

        private void btnBarkod_Click(object sender, EventArgs e)
        {
            var barkodNo = db.Barkod.First();
            int karakter = barkodNo.BarkodNo.ToString().Length;
            string sifirlar = string.Empty;
            for(int i=0;i<8-karakter;i++)
            {
                sifirlar = sifirlar + "0";
            }
            string olusanBarkod = sifirlar + barkodNo.BarkodNo.ToString();
            txtBakod.Text = olusanBarkod;
            txtUrunAd.Focus();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int urunid = Convert.ToInt32(dgwUrunler.CurrentRow.Cells["UrunId"].Value.ToString());
            string urunad = dgwUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
            string barkod = dgwUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
            DialogResult onay = MessageBox.Show(urunad + " ürünü silmek istiyor musunuz ?", "Ürünü Silme İşlemi", MessageBoxButtons.YesNo);
            if(onay==DialogResult.Yes)
            {
                var urun = db.Urun.Find(urunid);
                db.Urun.Remove(urun);
                db.SaveChanges();
                var hizliurun = db.HizliUrun.Where(x => x.Barkod == barkod).SingleOrDefault();
                if(hizliurun!=null)
                {
                    hizliurun.Barkod = "-";
                    hizliurun.UrunAd = "-";
                    hizliurun.Fiyat = 0;
                }               
                db.SaveChanges();
                MessageBox.Show("Ürün silinmiştir");
                dgwUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
                Islemler.GridDuzenle(dgwUrunler);
                txtBakod.Focus();
            }
        }

        private void cbUrunTipi_CheckedChanged(object sender, EventArgs e)
        {
            if(cbUrunTipi.Checked)
            {
                cbUrunTipi.Text="Gramajlı Ürün İşlemi";
                btnBarkod.Enabled = false;

            }
            else
            {
                cbUrunTipi.Text = "Barkodlu Ürün İşlemi";
                btnBarkod.Enabled = true;
            }
        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgwUrunler.Rows.Count > 0)
            {
                txtBakod.Text = dgwUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                txtUrunAd.Text= dgwUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                txtAciklama.Text = dgwUrunler.CurrentRow.Cells["Aciklama"].Value.ToString();
                cmbUrunGrup.Text= dgwUrunler.CurrentRow.Cells["UrunGrup"].Value.ToString();
                txtAlisFiyat.Text= dgwUrunler.CurrentRow.Cells["AlisFiyat"].Value.ToString();
                txtSatisFiyat.Text= dgwUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString();
                txtKdvOrani.Text= dgwUrunler.CurrentRow.Cells["KdvOrani"].Value.ToString();
                txtMiktar.Text = dgwUrunler.CurrentRow.Cells["Miktar"].Value.ToString();
                string birim= dgwUrunler.CurrentRow.Cells["Birim"].Value.ToString();
                if(birim=="Kg")
                {
                    cbUrunTipi.Checked = true;
                }
                else
                {
                    cbUrunTipi.Checked = false;
                }

            }
        }

        private void btnKullanilmayanSil_Click_1(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("!! Lütfen Dikkat : \n Ürün fiyat düzenlemelerinin TAMAMINI yaptığınızdan eminseniz bu işlemi onaylayınız!", "DİKKAT! Kullanılmayan Ürün Silme İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                db.Urun.RemoveRange(db.Urun.Where(x => x.Onay == false));
                db.SaveChanges();
                dgwUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                MessageBox.Show("Kullanılmayan ürünler silindi");
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {

        }
    }
}
