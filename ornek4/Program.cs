using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            dikdortgen dikdortgen = new dikdortgen();
            dikdortgen.En = 20;
            dikdortgen.Boy = 30;
            dikdortgen.AlanHesapla(dikdortgen.En, dikdortgen.Boy);
            Console.WriteLine("Alan : " + dikdortgen.AlanHesapla(dikdortgen.En, dikdortgen.Boy));
            Console.ReadLine();
        }
    }
}
