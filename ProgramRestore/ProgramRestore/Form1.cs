using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;


namespace ProgramRestore
{
    public partial class FrmYedektenYukle : Form
    {
        public FrmYedektenYukle()
        {
            InitializeComponent();
        }

        private void btnYedek_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Veri dosyasını seçiniz|*.bak";
            ofd.ShowDialog();
            txtDosyaAd.Text = ofd.FileName;

        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            if(txtDosyaAd.Text!="")
            {
             // try
              //  {
                    string strSql = @"data source=(LocalDB)\MSSQLLocalDb;AttachDbFilename=|DataDirectory|\BarkodDb.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
                    Cursor.Current = Cursors.WaitCursor;
                    string yedekyolu = txtDosyaAd.Text;
                    Application.DoEvents();
                    string str = Application.StartupPath + @"\BarkodDb.mdf";
                    using (SqlConnection connection = new SqlConnection(strSql))
                    {
                        connection.Open();
                        SqlCommand isle = new SqlCommand(@"USE Master; If Exists(Select * From sys.databases where name='BarkodDb') Drop Database[" + str + "];RESTORE DATABASE[" + str + "]FROM DISK=N'" + txtDosyaAd.Text + "'", connection);
                        isle.ExecuteNonQuery();
                        connection.Close();                      
                    }MessageBox.Show("Veriler yüklenmiştir");
                    Process.Start(Application.StartupPath + "\\BarkodluSatis.exe");
                    Cursor.Current = Cursors.Default;
                    Application.Exit();
              // }
               // catch ( Exception ex)
               // {

                 //  MessageBox.Show(ex.ToString());
               // }
               
            }
        }
    }
}
