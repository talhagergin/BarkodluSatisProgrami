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
    public partial class FrmFiyatGuncelle : Form
    {
        public FrmFiyatGuncelle()
        {
            InitializeComponent();
        }

        private void tStandart1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                using (var db=new BarkodDbEntities())
                {
                    if(db.Urun.Any(x=>x.Barkod==txtBarkod.Text))
                    {
                        var getir = db.Urun.Where(x => x.Barkod == txtBarkod.Text).SingleOrDefault();
                        lblBarkod.Text = getir.Barkod;
                        lblUrunAd.Text = getir.UrunAd;
                        double fiyat = Convert.ToDouble(getir.SatisFiyat);
                        lblFiyat.Text = fiyat.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Kayıtlı Değil");
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtYeniFiyat.Text!="" && txtBarkod.Text!="")
            {
                using (var db=new BarkodDbEntities())
                {
                    var guncellenecek = db.Urun.Where(x => x.Barkod == lblBarkod.Text).SingleOrDefault();
                    guncellenecek.SatisFiyat = Islemler.DoubleYap(txtYeniFiyat.Text);
                    int kdvorani = Convert.ToInt16(guncellenecek.KdvOrani);
                    Math.Round(Islemler.DoubleYap(txtYeniFiyat.Text) * kdvorani / 100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Yeni fiyat kaydedilmiştir");
                    lblBarkod.Text = "";
                    lblUrunAd.Text = "";
                    lblFiyat.Text = "";
                    txtBarkod.Clear();
                    txtYeniFiyat.Clear();
                    txtBarkod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ürün okutunuz");
                txtBarkod.Focus();
            }
        }

        private void FrmFiyatGuncelle_Load(object sender, EventArgs e)
        {
            lblBarkod.Text = "";
            lblUrunAd.Text = "";
            lblFiyat.Text = "";
            txtYeniFiyat.Clear();
        }
    }
}
