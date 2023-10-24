using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UB_Bank
{
    public abstract class Hesap : Musteri
    {
        public int hesapNo { get; set; }
        public int hesapBakiye { get; set; }
        public int cekmeLimit   { get; set; }
        public List<HesapOzeti> HesapOzetiTutucu { get; set; }
        public void HesapDefteriEkle(HesapOzeti Ozet)
        {
            HesapOzetiTutucu.Add(Ozet);
        }

        public void HesapHareketleriniYazdir (DataGridView tablo , DateTime baslangic , DateTime bitis)
        {
            string tutar = "";
            string kimden = "";
            string tur = "";
            tablo.Rows.Clear();
            foreach(HesapOzeti hesapHareketi in this.HesapOzetiTutucu)
            {
                if(hesapHareketi.islemTarihi.Date >= baslangic.Date && hesapHareketi.islemTarihi <= bitis.Date)
                {
                    if(hesapHareketi.EklenenPara != 0)
                    {
                        tutar = "+" + hesapHareketi.EklenenPara;
                    }
                    else
                    {
                        tutar = "-" + hesapHareketi.EklenenPara;
                    }
                    if(hesapHareketi.TransferKontrol == false)
                    {
                        kimden = "";
                        tur = "BANKA";
                      
                    }
                    else
                    {
                        kimden = hesapHareketi.Kisi.AdSoyad;
                        tur = " Havale";
                    }
                    tablo.Rows.Add(tutar,kimden,hesapHareketi.islemTarihi.ToLongDateString(),tur);
                }
            }
            

        }

    }
}
