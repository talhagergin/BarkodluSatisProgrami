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
    public partial class FrmMusteriDetayGoster : Form
    {
        public FrmMusteriDetayGoster()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        public int musterino { get; set; }
        public int? _islemno { get; set; }
        public string ad { get; set; }
        private void FrmMusteriDetayGoster_Load(object sender, EventArgs e)
        {
            lblMusteriNo.Text = "Müşteri No: " + musterino.ToString();
            lblAd.Text = " : " + ad;
            using (var db = new BarkodDbEntities())
            {
                dgwMusteri.DataSource = db.BorcOzet.Select(x => new { x.MusteriNo,x.Ad,x.Odenen,x.Eklenen,x.Kalan,x.Tarih}).Where(x => x.MusteriNo == musterino).OrderByDescending(x=>x.Tarih).ToList();
                Islemler.GridDuzenle(dgwMusteri);
            }
        }
        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwMusteri.Rows.Count > 0)
            {               
                using (var db = new BarkodDbEntities())
                {
                    var islemnobul = db.MusteriVeIslemNo.Where(x => x.MusteriNo == musterino).ToArray();
                    DateTime _tarihi = DateTime.Parse(dgwMusteri.CurrentRow.Cells["Tarih"].Value.ToString());
                    var islemTuru = dgwMusteri.CurrentRow.Cells["Eklenen"].Value.ToString();
                    if (islemTuru != "0")
                    {
                        //_islemno = islemno;
                        if (musterino != 0)
                        {
                            FrmMusteriBorcDetay f = new FrmMusteriBorcDetay();
                            f.musterino = Convert.ToInt32(musterino);
                            f._tarih = _tarihi;
                            f.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ödeme işlemlerinin detayı bulunmaz.");
                    }
                }
                
            }
        }
    }
}
