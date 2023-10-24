using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UB_Bank
{
    public class BireyselMusteri : Musteri
    {
        private List<Hesap> BHesaplar = new List<Hesap>();

        public List<Hesap> getBHesaplar
        {
            get { return BHesaplar; }
            set { BHesaplar = value; }
        }

        private string musteriNo { get; set; }
        public string MusteriNo
        {
            get { return musteriNo; }
            set { musteriNo = value; }
        }

        private string adSoyad;
        public string AdSoyad { get { return adSoyad; } set { adSoyad = value; } } 


        
        private string tc;
        public string Tc { get { return tc; } set { tc = value; } } 


        public override void HesapEkle(Hesap h1)
        {
            getBHesaplar.Add(h1);
        }

        public override void HesapKapa(Hesap h1)
        {
            getBHesaplar.Remove(h1);
        }

        
       

    }
}
