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
    public partial class FrmFirmaOdemeEkranı : Form
    {
        public FrmFirmaOdemeEkranı()
        {
            InitializeComponent();
        }
        public int _firmaId { get; set; }
        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.Text != "")
            {
                if (txtNakit.Text != "" && txtkart.Text != "")
                {
                    try
                    {
                        using (var db=new BarkodDbEntities())
                        {
                            FirmaOdenenDetay firma = new FirmaOdenenDetay();
                            firma.FirmaId = _firmaId;
                            firma.OdemeSekli = cmbOdemeTuru.Text;
                            firma.Nakit = Islemler.DoubleYap(txtNakit.Text);
                            firma.Kart = Islemler.DoubleYap(txtkart.Text);
                            firma.ToplamTutar= Islemler.DoubleYap(txtNakit.Text) + Islemler.DoubleYap(txtkart.Text);
                            firma.Aciklama = txtAciklama.Text;
                            firma.Tarih = dtTarih.Value.GetRidOfSeconds();
                            db.FirmaOdenenDetay.Add(firma);
                            db.SaveChanges();
                            //firma genel borç tablosunda da güncelleme işlemi
                            var guncelle = db.FirmaBilgi.Where(a => a.FirmaId == _firmaId).FirstOrDefault();
                            guncelle.Odenen+= Islemler.DoubleYap(txtNakit.Text) + Islemler.DoubleYap(txtkart.Text);
                            guncelle.Kalan -= guncelle.GenelBorc - guncelle.Odenen;
                            db.SaveChanges();
                            MessageBox.Show("Ödeme Yapıldı !");
                        }
                        this.Hide();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Database Connection Error!" + ex);
                    }
                }
                else { MessageBox.Show("Ödeme Miktarını Belirtiniz!"); }
            }
            else
            {
                MessageBox.Show("Ödeme Türünü Seçiniz");
            }
        }

        private void cmbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.SelectedIndex == 0)
            {
                txtNakit.Enabled = true;
                txtkart.Enabled = false;
            }
            else if (cmbOdemeTuru.SelectedIndex == 1)
            {
                txtNakit.Enabled = false;
                txtkart.Enabled = true;
            }
            else if (cmbOdemeTuru.SelectedIndex == 2)
            {
                txtNakit.Enabled = true;
                txtkart.Enabled = true;
            }
            txtNakit.Text = "0";
            txtkart.Text = "0";
        }
    }
}
