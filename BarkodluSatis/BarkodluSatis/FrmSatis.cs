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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        public int _musteriNo { get; set; }
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = txtBarkod.Text.Trim();
                if (barkod.Length <= 2)
                {
                    txtMiktar.Text = barkod;
                    txtBarkod.Clear();
                    txtBarkod.Focus();
                }
                else
                {
                    if (db.Urun.Any(a => a.Barkod == barkod))
                    {
                        var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault();
                        UrunGetirListeye(urun, barkod, Convert.ToDouble(txtMiktar.Text));
                    }
                    else
                    {
                        int onek = Convert.ToInt32(barkod.Substring(0, 2));
                        if (db.Terazi.Any(a => a.TeraziOnEk == onek))
                        {
                            string teraziUrunNo = barkod.Substring(2, 5);
                            if (db.Urun.Any(a => a.Barkod == teraziUrunNo))
                            {
                                var urunterazi = db.Urun.Where(a => a.Barkod == teraziUrunNo).FirstOrDefault();
                                double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                UrunGetirListeye(urunterazi, teraziUrunNo, miktarkg);
                            }
                            else
                            {
                                Console.Beep(900, 2000);
                                MessageBox.Show("Kg Ürün Ekleme Sayfası");
                            }

                        }
                        else
                        {
                            Console.Beep(900, 2000);
                            FrmUrunGiris f = new FrmUrunGiris();
                            f.txtBakod.Text = barkod;
                            f.ShowDialog();
                        }
                    }
                    dgwSatisListesi.ClearSelection();
                    GenelToplam();

                }
            }
        }
        private void UrunGetirListeye(Urun urun, string barkod, double miktar)
        {
            int satirSayisi = dgwSatisListesi.Rows.Count;
            // double miktar = Convert.ToDouble(txtMiktar.Text);
            bool eklendiMi = false;

            if (satirSayisi > 0)
            {
                for (int i = 0; i < satirSayisi; i++)
                {
                    if (dgwSatisListesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        dgwSatisListesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(dgwSatisListesi.Rows[i].Cells["Miktar"].Value);
                        dgwSatisListesi.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(dgwSatisListesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(dgwSatisListesi.Rows[i].Cells["Fiyat"].Value), 2);
                        double dblKdvTutari = (double)urun.KdvTutari;
                        dgwSatisListesi.Rows[i].Cells["KdvTutari"].Value = Convert.ToDouble(dgwSatisListesi.Rows[i].Cells["Miktar"].Value) * dblKdvTutari;
                        eklendiMi = true;
                    }

                }
            }
            if (!eklendiMi)
            {
                dgwSatisListesi.Rows.Add();
                dgwSatisListesi.Rows[satirSayisi].Cells["Barkod"].Value = barkod;
                dgwSatisListesi.Rows[satirSayisi].Cells["UrunAdi"].Value = urun.UrunAd;
                dgwSatisListesi.Rows[satirSayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                dgwSatisListesi.Rows[satirSayisi].Cells["Birim"].Value = urun.Birim;
                dgwSatisListesi.Rows[satirSayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                dgwSatisListesi.Rows[satirSayisi].Cells["Miktar"].Value = miktar;
                dgwSatisListesi.Rows[satirSayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                dgwSatisListesi.Rows[satirSayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                dgwSatisListesi.Rows[satirSayisi].Cells["KdvTutari"].Value = urun.KdvTutari;

            }
        }
        private void GenelToplam()
        {
            double toplam = 0;
            for (int i = 0; i < dgwSatisListesi.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(dgwSatisListesi.Rows[i].Cells["Toplam"].Value);
            }
            txtGenelToplam.Text = toplam.ToString("C2");
            txtMiktar.Text = "1";
            txtBarkod.Clear();
            txtBarkod.Focus();
        }

        private void dgwSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                dgwSatisListesi.Rows.Remove(dgwSatisListesi.CurrentRow);
                dgwSatisListesi.ClearSelection();
                GenelToplam();
                txtBarkod.Focus();
            }
        }
        private void bh_MouseDown(object sender,MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                Button b = (Button)sender;
                if(!b.Text.StartsWith("-"))
                {
                    int buttonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil=new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton No:" + buttonid.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add(sil);
                    this.ContextMenuStrip = s;
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.HizliUrun.Find(butonid);
            guncelle.Barkod = "-";
            guncelle.UrunAd = "-";
            guncelle.Fiyat = 0;
            db.SaveChanges();
            double fiyat = 0;
            Button b = this.Controls.Find("bh" + butonid, true).FirstOrDefault() as Button;
            b.Text = "-" + "\n" + fiyat.ToString("C2");
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            HizliButonDoldur();
            b5.Text = 5.ToString("C2");
            b10.Text = 10.ToString("C2");
            b20.Text = 20.ToString("C2");
            b50.Text = 50.ToString("C2");
            b100.Text = 100.ToString("C2");
            b200.Text = 200.ToString("C2");
            using (var db=new BarkodDbEntities())
            {
                Islemler.SabitVarsayılan();
                var sabit = db.Sabit.FirstOrDefault();
                chbYazdirmaDurumu.Checked = Convert.ToBoolean(sabit.Yazici);
            }
        }
        private void HizliButonDoldur()
        {
            var hizliUrun = db.HizliUrun.ToList();
            foreach(var item in hizliUrun)
            {
                Button bh = this.Controls.Find("bh"+ item.Id, true).FirstOrDefault() as Button;
                if(bh!=null)
                {
                    double fiyat = Islemler.DoubleYap(item.Fiyat.ToString());
                    bh.Text = item.UrunAd + "\n" + fiyat.ToString("C2");
                }
            }
        }
        private void HizliButonClick(object sender,EventArgs e)
        {
            Button b = (Button)sender;
            int buttonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
            if (b.Text.ToString().StartsWith("-"))
            {
                FrmHizliButonUrunEkle f = new FrmHizliButonUrunEkle();
                f.lblButonId.Text = buttonid.ToString();
                f.ShowDialog();
            }
            else
            {
                
                var urunBarkod = db.HizliUrun.Where(a => a.Id == buttonid).Select(a => a.Barkod).FirstOrDefault();
                var urun = db.Urun.Where(a => a.Barkod == urunBarkod).FirstOrDefault();
                UrunGetirListeye(urun, urunBarkod, Convert.ToDouble(txtMiktar.Text));
                GenelToplam();
            }
        }
        private void bNx_Click(object sender,EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Text==",")
            {
                int virgul = txtNumarator.Text.Count(x => x == ',');
                if(virgul<1)
                {
                    txtNumarator.Text += b.Text;
                }
            }
            else if(b.Text=="<")
            {
                if(txtNumarator.Text.Length>0)
                {
                    txtNumarator.Text = txtNumarator.Text.Substring(0, txtNumarator.Text.Length - 1);
                }
            }
            else
            {
                txtNumarator.Text += b.Text;
            }
        }

        private void btnAdet_Click(object sender, EventArgs e)
        {
           if(txtNumarator.Text!="")
            {
                txtMiktar.Text = txtNumarator.Text;
                txtNumarator.Clear();
                txtBarkod.Clear();
                txtBarkod.Focus();
            }
        }

        private void btnOdenen_Click(object sender, EventArgs e)
        {
            if (txtNumarator.Text != "")
            {
                double sonuc = Islemler.DoubleYap(txtNumarator.Text) - Islemler.DoubleYap(txtGenelToplam.Text);
                txtParaUstu.Text = sonuc.ToString("C2");
                txtOdenen.Text = Islemler.DoubleYap(txtNumarator.Text).ToString("C2");
                txtNumarator.Clear();
                txtBarkod.Focus();
            }
        }

        private void btnBarkod_Click(object sender, EventArgs e)
        {
            if(txtNumarator.Text!="")
            {
                if(db.Urun.Any(a=>a.Barkod==txtNumarator.Text))
                {
                    var urun = db.Urun.Where(a => a.Barkod == txtNumarator.Text).FirstOrDefault();
                    UrunGetirListeye(urun, txtNumarator.Text, Convert.ToDouble(txtMiktar.Text));
                    txtNumarator.Clear();
                    txtBarkod.Focus();
                }
                else
                {
                    MessageBox.Show("Ürün ekleme sayfasını aç");
                }
            }
        }

        private void ParaUstuHesapla_Click(object sender,EventArgs e)
        {
            Button b = (Button)sender;
            double sonuc = Islemler.DoubleYap(b.Text) - Islemler.DoubleYap(txtGenelToplam.Text);
            txtOdenen.Text = Islemler.DoubleYap(b.Text).ToString("C2");
            txtParaUstu.Text = sonuc.ToString("C2");
        }

        private void btnDigerUrun_Click(object sender, EventArgs e)
        {
            if(txtNumarator.Text!="")
            {
                int satirsayisi = dgwSatisListesi.Rows.Count;
                dgwSatisListesi.Rows.Add();
                dgwSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = "1111111111116";
                dgwSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = "Barkodsuz ürün";
                dgwSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                dgwSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = "Adet";
                dgwSatisListesi.Rows[satirsayisi].Cells["Miktar"].Value = 1;
                dgwSatisListesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = 0;
                dgwSatisListesi.Rows[satirsayisi].Cells["Fiyat"].Value = Convert.ToDouble(txtNumarator.Text);
                dgwSatisListesi.Rows[satirsayisi].Cells["KdvTutari"].Value = 0;
                dgwSatisListesi.Rows[satirsayisi].Cells["Toplam"].Value = Convert.ToDouble(txtNumarator.Text);
                txtNumarator.Text = "";
                GenelToplam();
                txtBarkod.Focus();             
            }
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if(chSatisIadeIslem.Checked)
            {
                chSatisIadeIslem.Checked = false;
                chSatisIadeIslem.Text = "Satış Yapılıyor";
            }
            else
            {
                chSatisIadeIslem.Checked = true;
                chSatisIadeIslem.Text = "İade Yapılıyor";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            txtMiktar.Text = "1";
            txtBarkod.Clear();
            txtParaUstu.Clear();
            txtGenelToplam.Text = 0.ToString("C2");
            txtOdenen.Clear();
            chSatisIadeIslem.Checked = false;
            txtNumarator.Clear();
            dgwSatisListesi.Rows.Clear();
            txtBarkod.Focus();
        }
        public void SatisYap(string odemeSekli)
        {
            int satirSayisi = dgwSatisListesi.Rows.Count;
            bool satisIade = chSatisIadeIslem.Checked;
            double alisFiyatToplam = 0;
            if(satirSayisi>0)
            {
                int? islemNo = db.Islem.First().IslemNo;
                Satis satis = new Satis();
                for(int i=0;i<satirSayisi;i++)
                {
                    satis.IslemNo = islemNo;
                    satis.UrunAd = dgwSatisListesi.Rows[i].Cells["UrunAdi"].Value.ToString();
                    satis.UrunGrup = dgwSatisListesi.Rows[i].Cells["UrunGrup"].Value.ToString();
                    satis.Barkod = dgwSatisListesi.Rows[i].Cells["Barkod"].Value.ToString();
                    satis.Birim = dgwSatisListesi.Rows[i].Cells["Birim"].Value.ToString();
                    satis.AlisFiyat = Islemler.DoubleYap(dgwSatisListesi.Rows[i].Cells["AlisFiyat"].Value.ToString());
                    satis.SatisFiyat = Islemler.DoubleYap(dgwSatisListesi.Rows[i].Cells["Fiyat"].Value.ToString());
                    satis.Miktar = Islemler.DoubleYap(dgwSatisListesi.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.Toplam =Islemler.DoubleYap(dgwSatisListesi.Rows[i].Cells["Toplam"].Value.ToString());
                    satis.KdvTutari = Islemler.DoubleYap(dgwSatisListesi.Rows[i].Cells["KdvTutari"].Value.ToString())*Islemler.DoubleYap(satis.Miktar.ToString());
                    satis.OdemeSekli = odemeSekli;
                    satis.Iade = satisIade;
                    satis.Tarih = DateTime.Now;
                    satis.Kullanici = lblKullanici.Text;
                    db.Satis.Add(satis);
                    db.SaveChanges();
                    
                    if (!satisIade)
                    {
                        Islemler.StokAzalt(dgwSatisListesi.Rows[i].Cells["Barkod"].Value.ToString(), Islemler.DoubleYap(dgwSatisListesi.Rows[i].Cells["Miktar"].Value.ToString()));
                    }
                    else
                    {
                        Islemler.StokArttir(dgwSatisListesi.Rows[i].Cells["Barkod"].Value.ToString(), Islemler.DoubleYap(dgwSatisListesi.Rows[i].Cells["Miktar"].Value.ToString()));
                    }
                    alisFiyatToplam += Islemler.DoubleYap(dgwSatisListesi.Rows[i].Cells["AlisFiyat"].Value.ToString())* Islemler.DoubleYap(dgwSatisListesi.Rows[i].Cells["Miktar"].Value.ToString());
                }
                IslemOzet io = new IslemOzet();
                io.IslemNo = islemNo;
                io.Iade = satisIade;
                io.AlisFiyatToplam = alisFiyatToplam;
                io.Gelir = false;
                io.Gider = false;
                if(!satisIade)
                {
                    io.Aciklama = odemeSekli + "Satış";
                    
                }
                else
                {
                    io.Aciklama = "İade İşlemi (" + odemeSekli + ")";
                }
                io.OdemeSekli = odemeSekli;
                io.Kullanici = lblKullanici.Text;
                io.Tarih = DateTime.Now;
                switch(odemeSekli)
                {
                    case "Nakit":
                        io.Nakit = Islemler.DoubleYap(txtGenelToplam.Text);
                        io.Kart = 0;
                        break;
                    case "Kart":
                        io.Nakit = 0;
                        io.Kart = Islemler.DoubleYap(txtGenelToplam.Text);
                        break;
                    case "Kart-Nakit":
                        io.Nakit = Islemler.DoubleYap(lblNakit.Text);
                        io.Kart = Islemler.DoubleYap(lblKart.Text);
                        break;
                    case "Veresiye":
                        io.Veresiye= Islemler.DoubleYap(txtGenelToplam.Text);
                        io.Nakit = 0;
                        io.Kart = 0;
                        break;

                }
                db.IslemOzet.Add(io);
                db.SaveChanges();
                MusteriVeIslemNo islemvemusterino = new MusteriVeIslemNo();
                islemvemusterino.IslemNo = islemNo;
                islemvemusterino.MusteriNo = _musteriNo;
                db.MusteriVeIslemNo.Add(islemvemusterino);
                db.SaveChanges();
                var islemNoArtir = db.Islem.First();
                islemNoArtir.IslemNo += 1;
                db.SaveChanges();
                if(chbYazdirmaDurumu.Checked)
                {
                    //yazdir
                    Yazdir yazdir = new Yazdir(islemNo);
                    yazdir.YazdirmayaBasla();
                }
                Temizle();
            }
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            SatisYap("Nakit");
        }

        private void btnNakitKart_Click(object sender, EventArgs e)
        {
            FrmNakitKart nakitkart = new FrmNakitKart();
            nakitkart.ShowDialog();
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void FrmSatis_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F1)           
                SatisYap("Nakit");          
            if (e.KeyCode == Keys.F2)
                SatisYap("Kart");
            if(e.KeyCode==Keys.F3)
            {
                FrmNakitKart f = new FrmNakitKart();
                f.ShowDialog();
            }
           
        }

        private void btnIslemBekletme_Click(object sender, EventArgs e)
        {
            if(btnIslemBekletme.Text=="İşlem Beklet")
            {
                Bekle();
                btnIslemBekletme.BackColor = System.Drawing.Color.OrangeRed;
                btnIslemBekletme.Text = "İşlem Bekliyor";
                dgwSatisListesi.Rows.Clear();
                
            }
            else
            {
                BeklemedenCik();
                btnIslemBekletme.BackColor = System.Drawing.Color.Gray;
                btnIslemBekletme.Text = "İşlem Beklet";
                dgwBekle.Rows.Clear();
            }
            GenelToplam();
            
        }
        private void Bekle()
        {
            int satir = dgwSatisListesi.Rows.Count;
            int sutun = dgwSatisListesi.Columns.Count;
            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    dgwBekle.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        dgwBekle.Rows[i].Cells[j].Value = dgwSatisListesi.Rows[i].Cells[j].Value;
                    }
                }
            }
        }
            private void BeklemedenCik()
            {
                int satir = dgwBekle.Rows.Count;
                int sutun = dgwBekle.Columns.Count;
                if (satir > 0)
                {
                    for (int i = 0; i < satir; i++)
                    {
                        dgwSatisListesi.Rows.Add();
                        for (int j = 0; j < sutun - 1; j++)
                        {
                            dgwSatisListesi.Rows[i].Cells[j].Value = dgwBekle.Rows[i].Cells[j].Value;
                        }
                    }
                }
            }

        private void btnKart_Click(object sender, EventArgs e)
        {
            SatisYap("Kart");
        }

        private void chSatisIadeIslem_CheckedChanged(object sender, EventArgs e)
        {
            if(chSatisIadeIslem.Checked)
            {
                chSatisIadeIslem.Text = "İade Yapılıyor";
            }
            else
            {
                chSatisIadeIslem.Text = "Satış Yapılıyor";
            }
        }

        private void btnVeresiye_Click(object sender, EventArgs e)
        {
            string tutar = txtGenelToplam.Text;
            FrmMusteriBilgi musteri = new FrmMusteriBilgi(tutar);
            musteri.Show();
        }
    }
}
