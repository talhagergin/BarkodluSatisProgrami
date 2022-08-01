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
        public int musterino { get; set; }
        private void FrmMusteriBorcDetay_Load(object sender, EventArgs e)
        {
            using (var db = new BarkodDbEntities())
            {
                dgwBorc.DataSource = db.IslemOzet.Select(x => new {x.IslemNo}).Where(x => x.IslemNo == musterino).ToList();
                Islemler.GridDuzenle(dgwBorc);
            }
        }
    }
}
