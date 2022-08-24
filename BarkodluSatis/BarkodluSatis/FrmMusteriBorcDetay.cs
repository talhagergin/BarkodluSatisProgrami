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
    public partial class FrmMusteriBorcDetay : Form
    {
        public FrmMusteriBorcDetay()
        {
            InitializeComponent();
        }
        BarkodDbEntities db = new BarkodDbEntities();
        public DateTime _tarih { get; set; }
        public int? musterino { get; set; }
        private void FrmMusteriBorcDetay_Load(object sender, EventArgs e)
        {
           
                var islemnosu = db.IslemOzet.Where(x => (x.Tarih) == null ? false : ((DateTime)x.Tarih).Day == _tarih.Day && ((DateTime)x.Tarih).Month == _tarih.Month && ((DateTime)x.Tarih).Year == _tarih.Year && ((DateTime)x.Tarih).Hour == _tarih.Hour && ((DateTime)x.Tarih).Minute == _tarih.Minute).FirstOrDefault().IslemNo;
                //var asilislem = islemnosu.Where(x => x.Tarih?.ZartZurtEqual(_tarih) ?? false).FirstOrDefault();
                lblIslemNo.Text = "İşlem No: " + islemnosu.ToString();
                using (var db = new BarkodDbEntities())
                {
                dgwBorc.DataSource = db.Satis.Select(x => new { x.IslemNo, x.UrunAd, x.UrunGrup, x.Miktar, x.Toplam, x.Tarih }).Where(x => x.IslemNo == islemnosu).OrderByDescending(x => x.Tarih).ToList();
                    Islemler.GridDuzenle(dgwBorc);
                }
            
      
        }
    }
}
