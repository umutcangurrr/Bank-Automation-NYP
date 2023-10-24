using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UB_Bank
{
    public class İslem 
    {
        private DateTime tarih { get; set; }

        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }


        private string kisiAdi { get; set; }

        public string KisiAdi
        {
            get { return kisiAdi; }
            set { kisiAdi = value; }
        }
        private string islemTuru { get; set; }

        public string İslemTuru
        {
            get { return islemTuru; }
            set { islemTuru = value; }
        }
        private float miktar { get; set; }

        public float Miktar
        {
            get { return miktar; }
            set { miktar = value; }

        }

    }
}
