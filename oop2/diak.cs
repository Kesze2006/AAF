using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class diak : udvariasEmber
    {
        private int kor;
        public diak(string vNev, string kNev, int kor) : base(vNev, kNev)
        {
            this.kor = kor;
        }

       

        public void iskola()
        {
            if (kor < 2)
            {
                Console.WriteLine("*Gügyög*");
            }
            else if (kor < 3)
            {
                Console.WriteLine("Bölcsöde");
            }
            else if (kor < 7)
            {
                Console.WriteLine("Óvoda");
            }
            else if (kor < 11)
            {
                Console.WriteLine("Alsós");
            }
            else if (kor < 15)
            {
                Console.WriteLine("Felsős");
            }
            else if (kor < 20)
            {
                Console.WriteLine("Technikus");
            }
            else if (kor < 25)
            {
                Console.WriteLine("Egyetem");
            }
            else
            {
                Console.WriteLine("Felnőtt");
            }

        }

        public void koszon(diak diakValtozo)
        {
            Console.WriteLine("Csá {0} !",diakValtozo.keresztNev);
        }
    }
}
