using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UB_Bank
{
    public class Banka
    {
        

        public static  List<BireyselMusteri> BireyselMusteriler = new List<BireyselMusteri>();

        public static List<TicariMusteri> TicariMusteriler = new List<TicariMusteri>();




        public static float GelenBakiye = 0;
        public static float GidenBakiye = 0;
        public static float ToplamBakiye = 0;
            
        public static void BireyselMusteriEkle(BireyselMusteri bm1)
        {
            BireyselMusteriler.Add(bm1);
        }

        public static void TicariMusteriEkle(TicariMusteri tm1)
        {
            TicariMusteriler.Add(tm1);
        }

       


    }
}
