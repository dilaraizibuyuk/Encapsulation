using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek6
{
    class Urun
    {
        private string Ad;

        public string ad {
            get { return Ad; }
            set { Ad = value; }
        }

        private double Fiyat;
        public double fiyat
        {
            get { return Fiyat; }
            set
            { Fiyat = Math.Round(value, 1); }

        }
    
        private string UrunKodu;

        public string urunkodu {
            get { return UrunKodu; }
            set
            {
                Random rnd = new Random();
                UrunKodu = value.ToString() + rnd.Next(100, 999).ToString();
            }
        }
       
    }
}
