using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Ogrenci
    {
        private string isim;
        public void setIsim(string _isim) //method
        {
            isim = _isim;
        }

        public string getIsim() //method2
        {
            return isim;
        }
    }
}
