using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.kilo2 = 54.5;
            Console.WriteLine(customer1.kilo2);
            Console.ReadKey();
        }
    }
}
