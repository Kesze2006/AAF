using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word!");
            int szam = 20; Console.WriteLine(szam); 
            int nszam = -3; Console.WriteLine(nszam);
            double tszam = 12.5; Console.WriteLine(tszam);
            char karakter = '='; Console.WriteLine(karakter);
            Console.WriteLine(szam % tszam);
            Console.WriteLine((char)(karakter + 2));
            Console.WriteLine(szam++);
            Console.WriteLine(++szam);

        }
    }
}
