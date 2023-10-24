using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UB_Bank
{
    public class TicariMusteri : Musteri


         

    {
        private List<Hesap> THesaplar = new List<Hesap>();

        public List<Hesap> getTHesaplar
        {
            get { return THesaplar; }
            set { THesaplar = value; }
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
            getTHesaplar.Add(h1);
        }

        public override void HesapKapa(Hesap h1)
        {
            getTHesaplar.Remove(h1);   
        }

       



    }
}
