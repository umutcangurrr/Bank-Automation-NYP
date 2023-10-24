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
    public partial class MusteriGirisForm : Form
    {
        public MusteriGirisForm()
        {
            InitializeComponent();
        }
        
        private void musteriGirisBtn_Click(object sender, EventArgs e)
        {
             

            HesapGirisForm hg = new HesapGirisForm();
            hg.txtGelen = Convert.ToInt32(musteriGirisTxt.Text);
            hg.Show();

            bool kontrol = true;

            foreach(BireyselMusteri bm1 in Banka.BireyselMusteriler)
            {
                if (bm1.MusteriNo == Convert.ToString(musteriGirisTxt.Text))
                {
                    hg.BurayaGelecekListe = bm1.getBHesaplar;
                    kontrol = false;
                }

            }

            if (kontrol == true)
            {
                foreach (TicariMusteri tm1 in Banka.TicariMusteriler)
                {
                    if (tm1.MusteriNo == Convert.ToString(musteriGirisTxt.Text))
                    {
                        hg.BurayaGelecekListe = tm1.getTHesaplar;
                        
                    }

                }


            }

            this.Close();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
