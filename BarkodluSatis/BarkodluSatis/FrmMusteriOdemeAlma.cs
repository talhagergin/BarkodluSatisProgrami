using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class FrmMusteriOdemeAlma : Form
    {
        public FrmMusteriOdemeAlma()
        {
            InitializeComponent();
        }
        public int _musteriNo { get; set; }
        public string _musteriAd { get; set; }
        public string _musteriSoyad { get; set; }
        public double  _genelBorc { get; set; }
        public double  _kalanBorc { get; set; }
        private void FrmMusteriOdemeAlma_Load(object sender, EventArgs e)
        {
            lblMusteriNo.Text = _musteriNo.ToString();
            using (var db = new BarkodDbEntities())
            {
                txtAd.Text = _musteriAd.ToString();
                txtSoyad.Text = _musteriSoyad.ToString();
                txtGenel.Text = _genelBorc.ToString();
                txtKalan.Text=_kalanBorc.ToString();
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if(txtOdenecek.Text != "" && txtOdenecek.Text!="0")
            {
                using (var db=new BarkodDbEntities())
                {
                    try
                    {
                    var guncelle = db.MusteriBorcTakip.Where(x => x.MusteriNo == _musteriNo).FirstOrDefault();
                    guncelle.Ad = txtAd.Text;
                    guncelle.Soyad = txtSoyad.Text;
                    var dateTime = DateTime.Now.GetRidOfSeconds();
                    guncelle.OdemeTarihi = dateTime;
                        //guncelle.GenelBorc = Islemler.DoubleYap(txtGenel.Text) - Islemler.DoubleYap(txtOdenecek.Text);
                        guncelle.Odenen += Islemler.DoubleYap(txtOdenecek.Text);
                        guncelle.Kalan = Islemler.DoubleYap(txtKalan.Text) - Islemler.DoubleYap(txtOdenecek.Text);
                    db.SaveChanges();

                    BorcOzet borc = new BorcOzet();
                    borc.MusteriNo = _musteriNo;
                    borc.Ad = _musteriAd;
                    borc.Soyad = _musteriSoyad;
                    borc.Eklenen = Islemler.DoubleYap("0");
                    borc.Odenen = Islemler.DoubleYap(txtOdenecek.Text);
                    borc.Kalan= Islemler.DoubleYap(txtKalan.Text)-Islemler.DoubleYap(txtOdenecek.Text);
                    var dateTimee = DateTime.Now.GetRidOfSeconds();
                    borc.Tarih = dateTimee;
                    db.BorcOzet.Add(borc);
                    db.SaveChanges();
                    MessageBox.Show("Ödeme Yapılmıştır!");
                    Temizle();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error " + ex);
                    }

                }
            }
        }
        public void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtGenel.Clear();
            txtOdenecek.Clear();
            txtKalan.Clear();
            //FrmMusteriBilgi musteri = new FrmMusteriBilgi();
            //musteri.ShowDialog();

        }
    }
}
