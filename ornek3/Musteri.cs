using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    class Musteri
    {
        private string tckimlikno;

        public string tckimlikno1
        {
            get
            {

                return tckimlikno.Substring(0, 3) + "********";
            }

            set
            {
                bool control = false;
                if (value.Length==11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        if (sayiMi)
                        {
                            //işlem yok
                        }
                        else
                        {
                            control = true;
                            break;
                        }
                    }
                    if (control)
                    {
                        Console.WriteLine("TC kimlik numaranızda geçersiz karakter bulundu.");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                }
                else if (value.Length!=11)
                {

                    Console.WriteLine("TC kimlik numaranız 11 karakter olmalıdır.");
                    Console.ReadKey();
                }
                
            }
        }
    }
}
