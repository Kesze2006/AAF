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
            int szam = 5; Console.WriteLine(szam); 
            int nszam = -3; Console.WriteLine(nszam);
            double tszam = 12.5; Console.WriteLine(tszam);
            char karakter = '='; Console.WriteLine(karakter);
            Console.WriteLine(szam % tszam);
            Console.WriteLine((char)(karakter + 2));

            Console.WriteLine();

            if (szam > 2)
            {
                Console.WriteLine("Nagyobb!");
            }
            else if (szam < 2)
            {
                Console.WriteLine("Nem jó!");
            }
            else if (szam%2==0)
            {
                Console.WriteLine("Páros!");
            }
            else
            {
                Console.WriteLine("Ugyan az az érték!");
            }

            Console.WriteLine();

            switch (szam)
            {
                case 1:
                    Console.WriteLine("Egy");
                    break;
                case 2:
                    Console.WriteLine("Kettő");
                    break;
                case 3:
                    Console.WriteLine("Három");
                    break;
                case 4:
                    Console.WriteLine("Négy");
                    break;
                default:
                    Console.WriteLine("Valami más");
                    break;

            }



        }
    }
}
