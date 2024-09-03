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

            Console.WriteLine();


            double szamW = 1;

            while(szamW < 5)
            {
                Console.WriteLine(szamW);
                szamW += .1;
            }

            Console.WriteLine();

            do
            {
                Console.WriteLine(szamW);
                szamW -= .2;
            }
            while (szamW > 1);

            Console.WriteLine();

            Console.WriteLine((int)('a'));

            Console.WriteLine();

            int betu = 97;

            while (betu <= 'z')
            {
                
                Console.Write((char)betu);
                betu += 1;
            }
            Console.WriteLine();
            Console.WriteLine();

            int karakter2 = 32;
            int tag = 0;
            while (karakter2 <= 255)
            {
                
                if (tag < 8)
                {
                    Console.Write((char)(karakter2)+"  ");
                    karakter2 += 1;
                    tag += 1;
                }
                else
                {
                    Console.WriteLine();
                    tag = 0;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine();

            int osszeg = 0;
            int iszam = 100;
            for (int e = 100; e < 1000; e++)
            {
                osszeg += iszam;
                iszam += 1;
            }

            Console.WriteLine(osszeg);
            Console.WriteLine();

            for (int i = 9; i >= 0; i--)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(9-i);
            }
            Console.WriteLine();
        }
    }
}
