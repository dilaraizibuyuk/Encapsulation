using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    public class dikdortgen
    {
        private int boy;
        private int en;
        public int alan = 0;

        public int Boy
        {
            get
            {
                return boy;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                }
                else
                {
                    boy = value;
                }
            }
        }
        public int En
        {
            get
            {
                return en;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                }
                else
                {
                    en = value;
                }

            }
        }
        public int AlanHesapla(int boy, int en)
        {
            return boy * en;
        }

    }
}




