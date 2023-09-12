using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_valahogy
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 10;
            while (szam != 99) 
            {
                if (szam % 5 == 0)
                {
                    Console.Write(szam+"  ");
                    szam++;
                }
                else
                {
                    szam++;
                }
            }
            Console.WriteLine();
            int szam2 = 5;
            while (szam2 < 95)
            {
                szam2 += 5;
                Console.Write(szam2 + "  ");
            }
            Console.WriteLine();
        }
    }
}
