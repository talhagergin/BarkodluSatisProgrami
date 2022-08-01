using Lisans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public class GuvenlikKontrol
    {
        BarkodDbEntities db = new BarkodDbEntities();
        Guvenlik guvenlik = new Guvenlik();
        Lic lic = new Lic();
        public bool KontrolYap()
        {
            bool durum = false;
            if (db.Guvenlik.Count()==0)
            {
                LisansFormAc();
            }
            else
            {
                Lic lic = new Lic();
                var guvenlik = db.Guvenlik.First();
                if(lic.TarihCoz(guvenlik.baslangic) < DateTime.Now)
                {
                    guvenlik.baslangic = lic.TarihSifrele(DateTime.Now);
                    db.SaveChanges();
                    durum = true;
                }
                if (lic.TarihKontrol(lic.TarihCoz(guvenlik.baslangic), lic.TarihCoz(guvenlik.bitis)))
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                    LisansFormAc();
                }
                
            }
            return durum;
        }
        public void LisansFormAc()
        {
            Lic lic = new Lic();
            FrmLisans f = new FrmLisans();
            f.lblKontrolNo.Text = lic.EkrandaGoster().ToString();

            f.Show();
        }

        public void Lisansla(string girilenkod)
        {
            int durum = lic.GirilenLisansiKontrolEt(girilenkod);
            switch (durum)
            {
                case 0: //geçersiz lisans kodu
                    MessageBox.Show("Girilen lisans numarası geçersizdir!");
                    break;
                case 1:
                    DemoOlustur();
                    break;
                case 2:
                    YillikOlustur();
                    break;
                    
                default:
                    break;
            }
        }
        private int GuvenlikEkliMi()
        {
            return db.Guvenlik.Count();
        }
        private void GuvenlikEkle(string baslangic,string bitis)
        {
            guvenlik.baslangic = baslangic;
            guvenlik.bitis = bitis;
            db.Guvenlik.Add(guvenlik);
            db.SaveChanges();
        }
        private void GuvenikGuncelle(string baslangic,string bitis)
        {
            var guvenlikguncelle = db.Guvenlik.First();
            guvenlikguncelle.baslangic = baslangic;
            guvenlikguncelle.bitis = bitis;
            db.SaveChanges();
        }
        private void DemoOlustur()
        {
            try
            {  
                if(GuvenlikEkliMi()==0)
            {
                //db ekleme
                GuvenlikEkle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.DemoTarihOlustur()));
            }
            else
            {
                //db güncelleme 
                GuvenikGuncelle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.DemoTarihOlustur()));
            }
                MessageBox.Show("Program 10 Günlük Demo Olarak Başlatılmıştır \n Programı yeniden başlatınız...");
                Application.Exit();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }
          
        }
        private void YillikOlustur()
        {
            try
            {
                if (GuvenlikEkliMi() == 0)
            {
                //db ekleme
                GuvenlikEkle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.YillikTarihOlustur()));
            }
            else
            {
                //db güncelleme 
                GuvenikGuncelle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.YillikTarihOlustur()));
            }
                MessageBox.Show("Program 1 Yillik Olarak Kullanıma Açılmıştır \n Programı yeniden başlatınız...");
                Application.Exit();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu !");
            }
           
        }
    }
}
