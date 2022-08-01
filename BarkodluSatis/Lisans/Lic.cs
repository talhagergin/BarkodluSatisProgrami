using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
namespace Lisans
{
    public class Lic
    {
        public string CpuNo()
        {
            string islemciid = "";
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select ProcessorID From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
           foreach (ManagementObject mo in mbsList)
            {
               islemciid = mo["ProcessorID"].ToString();
            }
            return islemciid;
        }
        public int CpuKarakterToplam()
        {
            int toplam = 0;
            foreach (char item in CpuNo().ToCharArray())
            {
                toplam += (int) item;
            }
            return toplam;
        }
        public string gunkarakter = "WESVAEIIVOBJASDOBJAJBASDIDAVBDJNTMDANYTRQADSVAZDAPOKSDJGNBIHGDSWRQTWM";
        public string aykarakter = "HGYTKRIUSOXMKHNSAVDJCBHJLDPYRIAZDSFGKJDDCXSADWR";
        public string yilkarakter = "SAKAOAYAKSMXVKASDJVABYTAILWEDSASQFCFKJYIMXBGSERE";
        
        public bool TarihKontrol(DateTime baslangic,DateTime bitis)
        {
            return baslangic < DateTime.Now && DateTime.Now < bitis;
        }
        public int GirilenLisansiKontrolEt(string girilenLisansBilgisi)
        {
            Cursor.Current = Cursors.WaitCursor;
            double girilen = Convert.ToDouble(girilenLisansBilgisi);
            bool demomu = girilen == CpuKarakterToplam() * TarihFonksiyon() * 3;
            bool yillikmi = girilen == CpuKarakterToplam() * TarihFonksiyon() * 13;
            int durum = 0;
            if(demomu)
            {
                durum = 1; //demo kurulum için bir döndürüyoruz
            }
            else if(yillikmi)
            {
                durum = 2;
            }
            else
            {
                durum = 0;
            }
            return durum;
            Cursor.Current = Cursors.Default;
        }
        public DateTime DemoTarihOlustur()
        {
            DateTime tarih = DateTime.Now.AddDays(10);
            return tarih;
        }
        public DateTime YillikTarihOlustur()
        {
            DateTime tarih = DateTime.Now.AddYears(1);
            return tarih;
        }
        public long EkrandaGoster()
        {
            long gosterilecekNo = CpuKarakterToplam() * TarihFonksiyon();
            return gosterilecekNo;

        }
        public long TarihFonksiyon()
        {
            return (DateTime.Now.Day + DateTime.Now.Month) * DateTime.Now.Year;
        }

        public List<Sablon> gunler()
        {
            List<Sablon> listGun = new List<Sablon>();
            for (int i = 0; i < 31; i++)
            {
                listGun.Add(new Sablon { Numara = i + 1, Ad = gunkarakter.ToString().Substring(i * 2, 2) });
            }
            return listGun;
        }
        public List<Sablon> aylar ()
        {
            List<Sablon> listAy = new List<Sablon>();
            for(int i=0;i<12;i++)
            {
                listAy.Add(new Sablon { Numara = i + 1, Ad = aykarakter.ToString().Substring(i * 2, 2) });
            }
            return listAy;
        }
        public List<Sablon> yillar()
        {
            List<Sablon> listYil = new List<Sablon>();
            int karaktersayisi = 0;
            for(int i = 2022; i < 2032; i++)
            {
                listYil.Add(new Sablon { Numara = i , Ad = yilkarakter.ToString().Substring(karaktersayisi * 2, 2) });
                karaktersayisi+=2;
            }
            return listYil;

        }
        public DateTime TarihCoz(string sifreliTarih)
        {
            string strgun = sifreliTarih.Substring(0, 2);
            string stray = sifreliTarih.Substring(2, 2);
            string stryil = sifreliTarih.Substring(4, 2);
            int ay = aylar().Where(x => x.Ad == stray).FirstOrDefault().Numara;
            int gun = gunler().Where(x => x.Ad == strgun).FirstOrDefault().Numara;       
            int yil = yillar().Where(x => x.Ad == stryil).FirstOrDefault().Numara;
            DateTime tarih = new DateTime(yil, ay, gun);
            return tarih;
        }
        public string TarihSifrele(DateTime tarih)
        {
            int gun = tarih.Day;
            int ay = tarih.Month;
            int yil = tarih.Year;
            string strgun = gunler().Where(x => x.Numara == gun).FirstOrDefault().Ad;
            string stray = aylar().Where(x => x.Numara == ay).FirstOrDefault().Ad;
            string stryil = yillar().Where(x => x.Numara == yil).FirstOrDefault().Ad;
            string olusantarih=strgun + stray + stryil;
            return olusantarih;
        }
    }
}
