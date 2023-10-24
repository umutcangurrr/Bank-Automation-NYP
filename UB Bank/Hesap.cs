using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UB_Bank
{
    public class Hesap 
    {
        private List<İslem> İslemler = new List<İslem>();
        

        public İslem i1 = new İslem();

        private int hesapNo;
        public int HesapNo
       
        {
            get { return hesapNo; }
            set { hesapNo = value; }
        }

        private float hesapBakiye;  

        public float Hesapbakiye
        {
            get { return hesapBakiye; }
            set { hesapBakiye = value; }
        }


        private int CekmeLimit;

        public int Cekmelimit
        {
            get { return CekmeLimit ; }
            set { CekmeLimit = value; }
        }






        public void HesapOzetiEkle(İslem i1, Hesap h1)
        {
            h1.İslemler.Add(i1);
        }


        public void ParaCekme(int Tutar)
        {
            this.Cekmelimit -= Tutar;
            if (Cekmelimit < 0)
            {
                Cekmelimit += Tutar;
                MessageBox.Show("Günlük para çekme limitinizi doldurdunuz.");
            }
            else
            {
                this.Hesapbakiye -= Tutar;
                Banka.ToplamBakiye -= Tutar;
                Banka.GidenBakiye += Tutar;
               
                
            }
        }


        public void ParaYatırma(int Tutar)
        {
            this.Hesapbakiye += Tutar;
            Banka.ToplamBakiye += Tutar;
            Banka.GelenBakiye += Tutar;
            
        }

        public void TicariMüsteri_HavaleYap(float Tutar, Hesap h2)
        {
            this.Hesapbakiye -= Tutar;
            h2.Hesapbakiye += Tutar;
            



        }

        public void BireyselMusteri_HavaleYap(float Tutar, Hesap h2)
        {
            this.Hesapbakiye -= Tutar;
            this.Hesapbakiye -= Tutar * 0.02f;
            Banka.ToplamBakiye += Tutar * 0.02f;
            Banka.GelenBakiye += Tutar * 0.02f;
            h2.Hesapbakiye += Tutar;
            

            



        }

        public List<İslem> İslemListele()
        {
            return this.İslemler;
        }

    }
            

        }

    

