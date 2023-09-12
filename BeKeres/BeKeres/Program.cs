using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeKeres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Kérek egy szöveget: ");
            string szoveg = Console.ReadLine();
            Console.WriteLine('\n'+"A bekért szöveg a(z): "+szoveg+'\n');
            Console.WriteLine();

            szoveg = " ";
            while (szoveg != "") 
            {
                Console.WriteLine(szoveg);
                Console.Write("Kérek egy szót: ");
                szoveg = Console.ReadLine();

            }
            Console.WriteLine();

            Console.Write("Kérek egy nem egész számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A szám négyzete: "+(szam * szam+1));
            */

            Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < szam+1; i++) 
            {
                Console.Write("Kérem az "+i+". szöveget: ");
                string szo = Console.ReadLine();
                Console.WriteLine(szo);
            }
            Console.WriteLine();

            Console.Write("Kérek egy számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hány karakter legyen a szó?: ");
            int hosz = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < szam2; i++)
            {
                Console.Write("Kérem a(z) " + hosz + " karakter hosszú szót: ");
                string szo = Console.ReadLine();
                while (hosz != szo.Length)
                {
                    Console.WriteLine("Hosszú/Rövid a szó!");
                    Console.Write(hosz+" karakter hosszú szó legyen: ");
                    szo = Console.ReadLine();
                }
            }

        }
    }
}
