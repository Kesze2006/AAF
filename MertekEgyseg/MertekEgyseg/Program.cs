using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertekEgyseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double szam = 0;
            bool jo = false;
            while(!jo)
            {
                jo = true;
                Console.Write("Mit váltsak át? (pl: 12 kg): ");
                string be = Console.ReadLine();

                string[] darab = be.Split(' ');
                if (darab.Length != 2)
                {
                    jo = false;
                    continue;
                }

                try
                {
                    szam = Convert.ToDouble(darab[0]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Nem jó formátum! Legyen ilyen: 12,2 kg");
                    jo = false;
                    continue;
                }
                Console.WriteLine(szam);

            }

        }
    }
}
