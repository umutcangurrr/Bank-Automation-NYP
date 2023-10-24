using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UB_Bank
{
    
    public partial class Bankacıİslem : Form
    {
        public Bankacıİslem()
        {
            InitializeComponent();
        }

        public Random rastgele = new Random();
        

        private void bireyselMüşteriEkleBtn_Click(object sender, EventArgs e)
        {
            BireyselMusteri bm1 = new BireyselMusteri();
            bm1.AdSoyad = musteriAdSoyadEkleTxt.Text;
            bm1.Tc = musteriTcEkleTxt.Text;
            int a = 0;
            for (int i = 0; i > -1; i++)
            {
                bool Kontrol = true;
                a = rastgele.Next(99, 1000);
                if (a % 2 == 0)
                {
                    foreach (BireyselMusteri bm2 in Banka.BireyselMusteriler)
                    {
                        if (bm2.MusteriNo == Convert.ToString(a)) Kontrol = false;
                    }
                    if (Kontrol == true) break;
                }
                    
            }
            MessageBox.Show("Bireysel Müşteri Numaranız: " + Convert.ToString(a));
            bm1.MusteriNo = Convert.ToString(a);

            Banka.BireyselMusteriEkle(bm1);


        }

        private void ticariMusteriEkleBtn_Click(object sender, EventArgs e)
        {
            TicariMusteri tm1 = new TicariMusteri();    
            tm1.AdSoyad = musteriAdSoyadEkleTxt.Text;
            tm1.Tc = musteriTcEkleTxt.Text;
            int a = 0;
            for (int i = 0; i > -1; i++)
            {
                bool Kontrol = true;
                a = rastgele.Next(99, 1000);
                if (a % 2 != 0)
                {
                    foreach (TicariMusteri tm2 in Banka.TicariMusteriler)
                    {
                        if(tm2.MusteriNo == Convert.ToString(a)) Kontrol = false;
                    }

                    if (Kontrol == true) break;

                }
                    

            }


            
            tm1.MusteriNo = Convert.ToString(a);

            Banka.TicariMusteriEkle(tm1);
            MessageBox.Show("Ticari Müşteri Numaranız: " + Convert.ToString(a));

        }

        private void müsteriEklemeTab_Click(object sender, EventArgs e)
        {
            // Yanlışlıkla Açıldı
        }

        private void hesapEkleBtn_Click(object sender, EventArgs e)
        {
            // Ticari ve Bireysel müşterilerin hesap noları da tek çift ayırt edilme özelliği taşıyacak.  (Çiftse bireysel müşteri)         
            Hesap h1 = new Hesap();
            Random rastgele = new Random();

            int a = 0;

            for (int i = 0; i > -1; i++)
            {
                a = rastgele.Next(999, 10000);
                bool Control = true;

                if (Convert.ToInt32(musteriNoKontrolTxt.Text) % 2 == 0)
                {
                    if(a % 2 == 0)
                    {
                        foreach (BireyselMusteri bm1 in Banka.BireyselMusteriler)
                        {
                            
                            
                                foreach(Hesap h2 in bm1.getBHesaplar)
                                {
                                    if(h2.HesapNo == a)
                                    {
                                        Control = false;
                                    }
                                }
                            
                        }
                    }
                    else Control = false;
                }
                else
                {
                    if(a % 2 != 0)
                    {
                        foreach (TicariMusteri tm1 in Banka.TicariMusteriler)
                        {


                            foreach (Hesap h2 in tm1.getTHesaplar)
                            {
                                if (h2.HesapNo == a)
                                {
                                    Control = false;
                                }
                            }

                        }
                    }
                    else Control=false;
                }
                // ALT FOR BİTİŞ
                if (Control == true) break;
            }

            h1.HesapNo = a;
            h1.Hesapbakiye = 0;
            h1.Cekmelimit = 750;

                bool kontrol = true;

            foreach(BireyselMusteri bm1 in Banka.BireyselMusteriler)
            {
                if (bm1.MusteriNo == Convert.ToString(musteriNoKontrolTxt.Text))
                {
                    bm1.HesapEkle(h1);
                    MessageBox.Show("Hesap Eklendi");
                     kontrol = false;
                }
            }

            if (kontrol == true)
            {
                foreach (TicariMusteri tm1 in Banka.TicariMusteriler)
                {
                    if (tm1.MusteriNo == Convert.ToString(musteriNoKontrolTxt.Text))
                    {
                        tm1.HesapEkle(h1);
                        MessageBox.Show("Hesap Eklendi");

                    }
                }


            }





        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            BankacıForm bf = new BankacıForm();
            bf.Show();
        }

        private void hesapKapamaBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(hesapKapamaTxt.Text)%2 ==0)
            {
                foreach  ( BireyselMusteri bm1  in Banka.BireyselMusteriler)
                {
                    foreach (Hesap h1 in bm1.getBHesaplar.ToList())
                    {
                        if(h1.HesapNo == Convert.ToInt32(hesapKapamaTxt.Text))
                        {
                            bm1.HesapKapa(h1);
                        }
                    }
                }

                
            }

            else
            {
                foreach (TicariMusteri tm1 in Banka.TicariMusteriler)
                {
                    foreach (Hesap h1 in tm1.getTHesaplar.ToList())
                    {
                        if (h1.HesapNo == Convert.ToInt32(hesapKapamaTxt.Text))
                        {
                            tm1.HesapKapa(h1);
                        }
                    }
                }
            }
        }

        private void bankaGelirGiderBtn_Click(object sender, EventArgs e)
        {
            bankaGelirTxt.Text = Banka.GelenBakiye.ToString();
            bankaGiderTxt.Text = Banka.GidenBakiye.ToString();
            toplamBakiyeTxt.Text = Banka.ToplamBakiye.ToString();
        }
    }
}
