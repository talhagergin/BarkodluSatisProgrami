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
    public partial class FrmUrunGrubuEkle : Form
    {
        public FrmUrunGrubuEkle()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        private void FrmUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtGrupAd.Text!="")
            {
                UrunGrup ug = new UrunGrup();
                ug.UrunGrupAd = txtGrupAd.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                GrupDoldur();
                txtGrupAd.Clear();
                MessageBox.Show("Ürün Grubu eklenmiştir");
                FrmUrunGiris f = (FrmUrunGiris)Application.OpenForms["FrmUrunGiris"];
                if(f!=null)
                {
                    f.GrupDoldur();
                }
                
            }
            else
            {
                MessageBox.Show("Ürün Grup İsmi Giriniz!");
            }
        }
        private void GrupDoldur()
        {
            lstGrup.DisplayMember = "UrunGrupAd";
            lstGrup.ValueMember = "Id";
            lstGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bStandart1_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(lstGrup.SelectedValue.ToString());
            string grupad = lstGrup.Text;
            DialogResult onay = MessageBox.Show(grupad + " grubunu silmek istiyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo);
            if (onay==DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault(x => x.Id == grupid);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                txtGrupAd.Focus();
                MessageBox.Show(grupad + "ürün grubu silindi");
                FrmUrunGiris f = (FrmUrunGiris)Application.OpenForms["FrmUrunGiris"];
                f.GrupDoldur();
            }

        }
    }
}
