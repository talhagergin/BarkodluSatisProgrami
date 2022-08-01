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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        public string gelirgider { get; set; }
        public string kullanici { get; set; }
        public string aciklama { get; set; }
        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            lblGelirGider.Text = gelirgider + " İŞLEMİ YAPILIYOR ";
        }
        public double tutar { get; set; }
        public double tutar2 { get; set; }
        private void cmbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOdemeTuru.SelectedIndex==0)
            {
                txtNakit.Enabled = true;
                txtkart.Enabled = false;
            }
            else if(cmbOdemeTuru.SelectedIndex==1)
            {
                txtNakit.Enabled=false;
                txtkart.Enabled=true;
            }
            else if (cmbOdemeTuru.SelectedIndex == 2)
            {
                txtNakit.Enabled = true;
                txtkart.Enabled = true;
            }
            txtNakit.Text = "0";
            txtkart.Text = "0";
        }
        private void bStandart1_Click(object sender, EventArgs e)
        {
            if(cmbOdemeTuru.Text!="")
            {
                if(txtNakit.Text!="" && txtkart.Text!="")
                {
                    using (var db=new BarkodDbEntities())
                    {
                        IslemOzet io = new IslemOzet(); ;
                        io.IslemNo = 0;
                        io.Iade = false;
                        io.OdemeSekli = cmbOdemeTuru.Text;
                        io.Nakit = Islemler.DoubleYap(txtNakit.Text); 
                        io.Kart = Islemler.DoubleYap(txtkart.Text);
                        
                        io.AlisFiyatToplam = 0;
                        io.Aciklama = gelirgider + "- İşlemi " + txtAciklama.Text;
                        io.Tarih = dtTarih.Value;
                        io.Kullanici = kullanici;
                        if (gelirgider == "GELİR")
                        {
                            io.Gelir = true;
                            io.Gider = false;
                            if (txtNakit.Text != "") { tutar = Islemler.DoubleYap(txtNakit.Text); }
                            if (txtkart.Text != "") { tutar2 = Islemler.DoubleYap(txtkart.Text); }
                        }
                        else
                        {
                            io.Gelir = false;
                            io.Gider = true;
                            io.Nakit = io.Nakit * -1;
                            io.Kart = io.Kart * -1;
                            io.AlisFiyatToplam = io.AlisFiyatToplam * -1;
                            if (txtNakit.Text != "") { tutar = Islemler.DoubleYap(txtNakit.Text); }
                            if (txtkart.Text != "") { tutar2 = Islemler.DoubleYap(txtkart.Text); }
                        }
                        db.IslemOzet.Add(io); ;
                        db.SaveChanges();
                        
                        
                        aciklama = txtAciklama.Text;
                        MessageBox.Show(gelirgider + " işlemi kaydedildi ");
                        txtNakit.Text = "0";
                        txtkart.Text = "0";
                        txtAciklama.Clear();
                        cmbOdemeTuru.Text = "";
                        FrmRapor f = (FrmRapor)Application.OpenForms["FrmRapor"];
                        if(f!=null)
                        {
                            f.btnGoster_Click(null, null);
                        }
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödeme türünü belirleyiniz");
            }
        }
    }
}
