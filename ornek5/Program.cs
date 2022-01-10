using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulke ulke1 = new Ulke();
            ulke1.Ad = "İsveç";
            ulke1.Baskent = "Stokholm";
            ulke1.ParaBirimi = "KR";
            ulke1.Nufus = 1035000;
            ulke1.Yazdir();

            Ulke ulke2 = new Ulke();
            ulke2.Ad = "İspanya";
            ulke2.Baskent = "Madrid";
            ulke2.Nufus = 47035000;
            ulke2.ParaBirimi = "Euro";
            ulke2.Yazdir();

            Console.ReadKey();
        }
    }
}
