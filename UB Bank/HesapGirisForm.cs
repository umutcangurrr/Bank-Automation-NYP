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
    public partial class HesapGirisForm : Form
    {
        public HesapGirisForm()
        {
            InitializeComponent();
        }

        public List<Hesap> BurayaGelecekListe;
        public int txtGelen;

        
        private void hesapGirisBtn_Click(object sender, EventArgs e)
        {
            MusteriGirisForm mgf = new MusteriGirisForm();
            HesapIslemForm hı = new HesapIslemForm();
            

             

            if(txtGelen % 2 ==0)
            {
                foreach(BireyselMusteri bm1 in Banka.BireyselMusteriler)
                {
                    if(Convert.ToInt32(bm1.MusteriNo) == this.txtGelen)
                    {
                        foreach(Hesap h1 in bm1.getBHesaplar)
                        {
                            if(h1.HesapNo == Convert.ToInt32(hesapGirisTxt.Text))
                            {
                                hı.BurayaGelenHesap = h1;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (TicariMusteri tm1 in Banka.TicariMusteriler)
                {
                    if (Convert.ToInt32(tm1.MusteriNo) == this.txtGelen)
                    {
                        foreach (Hesap h1 in tm1.getTHesaplar)
                        {
                            if (h1.HesapNo == Convert.ToInt32(hesapGirisTxt.Text))
                            {
                                hı.BurayaGelenHesap = h1;
                            }
                        }
                    }
                }
            }
            hı.Show();
            this.Close();
        }

        

        private void hesapListeleyiciBtn_Click(object sender, EventArgs e)
        {
            hesaplarDgw.DataSource = BurayaGelecekListe;
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MusteriGirisForm mf = new MusteriGirisForm();
            mf.Show();

        }
    }
}
