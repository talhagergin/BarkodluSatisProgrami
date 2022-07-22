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
    public partial class FrmDetayGoster : Form
    {
        public FrmDetayGoster()
        {
            InitializeComponent();
        }
        public int islemno { get; set; }
        private void FrmDetayGoster_Load(object sender, EventArgs e)
        {
            lblIslemNo.Text="İşlem No: "+islemno.ToString();
            using (var db = new BarkodDbEntities())
            {
                dgwListe.DataSource = db.Satis.Select(x => new {x.IslemNo,x.UrunAd,x.UrunGrup,x.Miktar,x.Toplam}).Where(x => x.IslemNo == islemno).ToList();
                Islemler.GridDuzenle(dgwListe);
            }
        }
    }
}
