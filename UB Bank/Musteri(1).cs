using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UB_Bank
{
    public  class Musteri 
    {
        public string AdSoyad
            { get; set; }
        public List<Hesap> Hesaplar;
        

        public void HesapEkle(Hesap h1)
        {
            Hesaplar.Add(h1);

        }

        

    }
}
