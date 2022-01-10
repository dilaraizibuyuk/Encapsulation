using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.setIsim("Dilara");
            string gelenIsim = ogrenci1.getIsim();
            if (gelenIsim=="Dilara")
            {
                Console.WriteLine("Doğru kullanıcı adını girdiniz");
            }
            else
                Console.WriteLine("Kullanıcı adını kontrol et");
            Console.ReadLine();
        }
    }
}
