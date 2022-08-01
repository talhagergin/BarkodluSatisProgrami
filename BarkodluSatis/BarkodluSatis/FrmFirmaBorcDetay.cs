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
    public partial class FrmFirmaBorcDetay : Form
    {
        public FrmFirmaBorcDetay()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        public int borcnno { get; set; }
        private void FrmFirmaBorcDetay_Load(object sender, EventArgs e)
        {
            lblBorcNo.Text = "Borç No: " + borcnno.ToString();
            using (var db = new BarkodDbEntities())
            {
                dgwListe.DataSource = db.FirmaBorc.Select(x => new { x.BorcNo, x.UrunAd, x.UrunGrup, x.Miktar, x.ToplamTutar, x.Tarih,x.Aciklama }).Where(x => x.BorcNo == borcnno).ToList();
                Islemler.GridDuzenle(dgwListe);
            }
        }
    }
}
