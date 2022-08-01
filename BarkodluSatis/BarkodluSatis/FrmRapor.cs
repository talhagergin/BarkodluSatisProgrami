using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BarkodluSatis
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        public void btnGoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangic = DateTime.Parse(dtBaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dtBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var db=new BarkodDbEntities())
            {
                if (lstFiltreleme.SelectedIndex == 0) //Tümünü getir
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    dgwListe.DataSource = islemozet;

                    txtSatisNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString("C2");
                    txtSatisKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Kart)).ToString("C2");

                    txtIadeNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Nakit)).ToString("C2");
                    txtIadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString("C2");

                    txtGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    txtGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Kart)).ToString("C2");

                    txtGiderNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    txtGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Kart)).ToString("C2");

                    db.Satis.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satistablosu = db.Satis.Local.ToBindingList();
                    double kdvtutarisatis = Islemler.DoubleYap(satistablosu.Where(x => x.Iade == false).Sum(x => x.KdvTutari).ToString());
                    double kdvtutariiade = Islemler.DoubleYap(satistablosu.Where(x => x.Iade == true).Sum(x => x.KdvTutari).ToString());
                    txtKdvToplam.Text = (kdvtutarisatis - kdvtutariiade).ToString("C2");

                }
                else if (lstFiltreleme.SelectedIndex == 1)//satışlar
                {
                    db.IslemOzet.Where(x=>x.Tarih>=baslangic && x.Tarih<=bitis && x.Iade==false && x.Gelir==false && x.Gider==false).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    dgwListe.DataSource = islemozet;
                }
                else if(lstFiltreleme.SelectedIndex==2) //iadeler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == true).Load();
                    dgwListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if(lstFiltreleme.SelectedIndex==3)
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.OdemeSekli == "Veresiye").Load();
                    dgwListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if (lstFiltreleme.SelectedIndex == 4) //gelirler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).Load();
                    dgwListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
                else if (lstFiltreleme.SelectedIndex == 5) //giderler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).Load();
                    dgwListe.DataSource = db.IslemOzet.Local.ToBindingList();
                }
            }
            Islemler.GridDuzenle(dgwListe);
           Cursor.Current = Cursors.Default;
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            lstFiltreleme.SelectedIndex = 0;
            txtKomisyon.Text = Islemler.KartKomisyon().ToString();
            btnGoster_Click(null, null);
        }

        private void lStandart14_Click(object sender, EventArgs e)
        {

        }

        private void dgwListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==2 || e.ColumnIndex==6 || e.ColumnIndex==7)
            {
                if(e.Value is bool)
                { bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnGelirEkle_Click(object sender, EventArgs e)
        {
            FrmGelirGider f = new FrmGelirGider();
            f.gelirgider = "GELİR";
            f.kullanici = lblKullanici.Text;
            f.ShowDialog();
        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            FrmGelirGider f = new FrmGelirGider();
            f.gelirgider = "GİDER";
            f.kullanici = lblKullanici.Text;
            f.ShowDialog();
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgwListe.Rows.Count>0)
            {
                int islemno = Convert.ToInt32(dgwListe.CurrentRow.Cells["IslemNo"].Value.ToString());
                if(islemno!=0)
                {
                    FrmDetayGoster f = new FrmDetayGoster();
                    f.islemno = islemno;
                    f.ShowDialog();
                }
            }
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            Raporlar.Baslik = "GENEL RAPORLAR";
            Raporlar.SatisKart = txtSatisKart.Text;
            Raporlar.SatisNakit = txtSatisNakit.Text;
            Raporlar.IadeKart = txtIadeKart.Text;
            Raporlar.IadeNakit = txtIadeNakit.Text;
            Raporlar.GelirKart = txtGelirKart.Text;
            Raporlar.GelirNakit = txtGelirNakit.Text;
            Raporlar.GiderKart =  txtGiderKart.Text;
            Raporlar.GiderNakit =  txtGiderNakit.Text;
            Raporlar.TarihBaslangic = dtBaslangic.Value.ToShortDateString();
            Raporlar.TarihBitis = dtBitis.Value.ToShortDateString();
            Raporlar.KdvToplam = txtKdvToplam.Text;
            Raporlar.KartKomisyon = txtKomisyon.Text;

            Raporlar.RaporSayfasiRaporu(dgwListe);
            
        }
    }
}
