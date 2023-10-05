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
            string[] hosszusag = { "mm","cm","dm","m","km" };
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
                if (hosszusag.Contains(darab[1]))
                {

                }
                else
                {
                    Console.WriteLine("Nem jó mértékegység!");
                    jo = false;
                    continue;
                }

            }
            Console.WriteLine("Mire szeretnéd átváltani?");
            for (int i = 0; i < hosszusag.Length; i++)
            {
                Console.WriteLine(hosszusag[i]);
            }
            Console.Write("Válassz: ");
            string valasz = Console.ReadLine();
        }
    }
}
