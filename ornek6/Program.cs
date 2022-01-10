using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek6
{
    class Program
    {
        static void Main(string[] args)
        { //ürün adı,fiyatı ve kodu var hepsi private tanımlanacak. prop ile yapacağız get,set. tüm bilgiler yazdırılacak.
            //ürünün kodunu sistem random atacak. fiyatta get set yaparken yuvarlama yapılacak math sınıfıyla

            Urun urn = new Urun();
            urn.ad = "Laptop";
            urn.urunkodu = "LPT";
            urn.fiyat = 8999.99;
            Console.WriteLine("Ürün Adı:{0}-Ürün Kodu:{1}-Ürün Fiyatı:{2}",urn.ad,urn.urunkodu,urn.fiyat);
            Console.ReadKey();
        }
    }
}
