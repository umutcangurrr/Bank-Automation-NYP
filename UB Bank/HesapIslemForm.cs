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
    public partial class HesapIslemForm : Form
    {

        public Hesap BurayaGelenHesap;
        public HesapIslemForm()
        {
            InitializeComponent();
        }

        
        

        private void hesapOzetTab_Click(object sender, EventArgs e)
        {

        }

        private void paraCekTab_Click(object sender, EventArgs e)
        {

        }

        private void uBBankToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            HesapGirisForm hgf = new HesapGirisForm();
            hgf.Show();
            this.Close();
        }


        private void paraCekBtn_Click(object sender, EventArgs e)
        {
            İslem i1 = new İslem();
            int tutar = Convert.ToInt32(cekilecekTutarTxt.Text);
            i1.Tarih = DateTime.Now;
            i1.Miktar -= tutar;
            i1.KisiAdi = "Kendisi";
            i1.İslemTuru = "Para Çekme";
            BurayaGelenHesap.HesapOzetiEkle(i1,BurayaGelenHesap);

            BurayaGelenHesap.ParaCekme(tutar);
            MessageBox.Show("İşlem Başarılı");
            
        }

        private void paraYatırBtn_Click(object sender, EventArgs e)
        {
            İslem i1 = new İslem();
            int tutar = Convert.ToInt32(paraYatırTxt.Text);
            i1.Tarih = DateTime.Now;
            i1.Miktar += tutar;
            i1.KisiAdi = "Kendisi";
            i1.İslemTuru = "Para Yatırma";
            BurayaGelenHesap.HesapOzetiEkle(i1,BurayaGelenHesap);

            BurayaGelenHesap.ParaYatırma(tutar);
            MessageBox.Show("İşlem Başarılı");
        }

        private void havaleBtn_Click(object sender, EventArgs e)
        {
            int tutar = Convert.ToInt32(havaleTutarTxt.Text);


            
            if (BurayaGelenHesap.HesapNo % 2 ==0)
            {
                if (Convert.ToInt32(havaleHesapNoTxt.Text) % 2 == 0)
                {
                    foreach (BireyselMusteri bm1 in Banka.BireyselMusteriler)
                    {
                        foreach (Hesap h1 in bm1.getBHesaplar)
                        {
                            if (Convert.ToInt32(havaleHesapNoTxt.Text) == h1.HesapNo)
                            {                                
                                BurayaGelenHesap.BireyselMusteri_HavaleYap(tutar, h1);
                                MessageBox.Show("İşlem Başarılı");
                                BurayaGelenHesap.i1.Tarih = DateTime.Now;
                                h1.i1.Tarih = DateTime.Now;
                                BurayaGelenHesap.i1.Miktar -= tutar;
                                h1.i1.Miktar += tutar;

                                BurayaGelenHesap.i1.KisiAdi += Convert.ToString(h1.HesapNo);
                                h1.i1.KisiAdi += Convert.ToString(BurayaGelenHesap.HesapNo);

                                BurayaGelenHesap.i1.İslemTuru = "Eft Gönderildi";
                                h1.i1.İslemTuru = "Eft Geldi";
                                BurayaGelenHesap.HesapOzetiEkle(h1.i1,h1);
                                BurayaGelenHesap.HesapOzetiEkle(BurayaGelenHesap.i1,BurayaGelenHesap);

                            }
                        }
                    }
                }
                else
                {
                    foreach (TicariMusteri tm1 in Banka.TicariMusteriler)
                    {
                        foreach(Hesap h1 in tm1.getTHesaplar)
                        {
                            if (Convert.ToInt32(havaleHesapNoTxt.Text) == h1.HesapNo)
                            {
                                BurayaGelenHesap.BireyselMusteri_HavaleYap(tutar, h1);
                                MessageBox.Show("İşlem Başarılı");
                                BurayaGelenHesap.i1.Tarih = DateTime.Now;
                                h1.i1.Tarih = DateTime.Now;

                                BurayaGelenHesap.i1.Miktar -= tutar;
                                h1.i1.Miktar += tutar;

                                BurayaGelenHesap.i1.KisiAdi += Convert.ToString(h1.HesapNo);
                                h1.i1.KisiAdi += Convert.ToString(BurayaGelenHesap.HesapNo);

                                BurayaGelenHesap.i1.İslemTuru = "Eft Gönderildi";
                                h1.i1.İslemTuru = "Eft Geldi";
                                BurayaGelenHesap.HesapOzetiEkle(h1.i1,h1);
                                BurayaGelenHesap.HesapOzetiEkle(BurayaGelenHesap.i1, BurayaGelenHesap);

                            }
                        }
                    }
                }
            }
            else
            {
                if (Convert.ToInt32(havaleHesapNoTxt.Text) % 2 == 0)
                {
                    foreach (BireyselMusteri bm1 in Banka.BireyselMusteriler)
                    {
                        foreach (Hesap h1 in bm1.getBHesaplar)
                        {
                            if (Convert.ToInt32(havaleHesapNoTxt.Text) == h1.HesapNo)
                            {
                                BurayaGelenHesap.TicariMüsteri_HavaleYap(tutar, h1);
                                MessageBox.Show("İşlem Başarılı");
                                BurayaGelenHesap.BireyselMusteri_HavaleYap(tutar, h1);
                                MessageBox.Show("İşlem Başarılı");
                                BurayaGelenHesap.i1.Tarih = DateTime.Now;
                                h1.i1.Tarih = DateTime.Now;
                                BurayaGelenHesap.i1.Miktar -= tutar;
                                h1.i1.Miktar += tutar;

                                BurayaGelenHesap.i1.KisiAdi += Convert.ToString(h1.HesapNo);
                                h1.i1.KisiAdi += Convert.ToString(BurayaGelenHesap.HesapNo);

                                BurayaGelenHesap.i1.İslemTuru = "Eft Gönderildi";
                                h1.i1.İslemTuru = "Eft Geldi";
                                BurayaGelenHesap.HesapOzetiEkle(h1.i1, h1);
                                BurayaGelenHesap.HesapOzetiEkle(BurayaGelenHesap.i1, BurayaGelenHesap);


                            }
                        }
                    }
                }
                else
                {
                    foreach (TicariMusteri tm1 in Banka.TicariMusteriler)
                    {
                        foreach (Hesap h1 in tm1.getTHesaplar)
                        {
                            if (Convert.ToInt32(havaleHesapNoTxt.Text) == h1.HesapNo)
                            {
                                BurayaGelenHesap.TicariMüsteri_HavaleYap(tutar, h1);
                                MessageBox.Show("İşlem Başarılı");
                                BurayaGelenHesap.HesapOzetiEkle(h1.i1, h1);
                                BurayaGelenHesap.HesapOzetiEkle(BurayaGelenHesap.i1, BurayaGelenHesap);
                            }
                        }
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapOzetDgw.DataSource =  BurayaGelenHesap.İslemListele(); 
            
        }
    }
}
