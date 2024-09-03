using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFBeKeres
{
    class Program
    {
        static void Main(string[] args)
        {
            string szo = " ";
            string nSzo = "";
            while (szo != "")
            {
                Console.Write("Kérek egy szót: ");
                szo = Console.ReadLine();
                if (szo != "")
                {
                    nSzo += szo + " ;";
                    Console.WriteLine(nSzo);
                }
                else
                {
                    Console.WriteLine(nSzo);
                    
                }
            }

            Console.WriteLine();

            Console.Write("Kérem az első számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            int osszeg = 0;
            for (int i = szam1; i <= szam2; i++)
            {
                osszeg += i * i;
            }
            Console.WriteLine(osszeg);
        }
    }
}
