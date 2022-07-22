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
    public partial class FrmHizliButonUrunEkle : Form
    {
        public FrmHizliButonUrunEkle()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if(txtUrunAra.Text!="")
            {
                string urunad = txtUrunAra.Text;
                var urunler = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
                dgwUrunler.DataSource = urunler;
                Islemler.GridDuzenle(dgwUrunler);
            }
        }

        private void dgwUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgwUrunler.Rows.Count>0)
            {
                string barkod = dgwUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunad = dgwUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double fiyat = Convert.ToDouble(dgwUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                int id = Convert.ToInt16(lblButonId.Text);
                var guncellenecek = db.HizliUrun.Find(id);
                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = urunad;
                guncellenecek.Fiyat = fiyat;
                db.SaveChanges();
                MessageBox.Show("Buton tanımlanmıştır");
                FrmSatis f = (FrmSatis)Application.OpenForms["FrmSatis"];
                if(f!=null)
                {
                    Button b = f.Controls.Find("bh" + id, true).FirstOrDefault() as Button;
                    b.Text = urunad + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void chTumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chTumu.Checked)
            {
                dgwUrunler.DataSource = db.Urun.ToList();
                dgwUrunler.Columns["AlisFiyat"].Visible = false;
                dgwUrunler.Columns["KdvOrani"].Visible = false;
                dgwUrunler.Columns["KdvTutari"].Visible = false;
                dgwUrunler.Columns["Miktar"].Visible = false;
                Islemler.GridDuzenle(dgwUrunler);
            }
            else
            {
                dgwUrunler.DataSource = null;
            }
        }
    }
}
