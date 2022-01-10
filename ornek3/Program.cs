using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.tckimlikno1 = "12345678950";
            Console.WriteLine("T.C.Kimlik Numarası:" + musteri1.tckimlikno1);  
            Console.ReadKey();
        }
    }
}
