using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatElagazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= szam; i++)
            {
                Console.WriteLine(i + " * 10 = "+ (i *10) );
            }
            */
            //Bukott szorzótábla
            /*int ossz = 0;
            int szamok = 0;
            int szam = 1;
            while (true)
            {
                if (ossz > 999)
                {
                    break;
                }
                szamok++;
                szam++;
                ossz = ossz + szam;
            }
            Console.WriteLine("Ennyi számot kell összeadni: " + szamok);
            */
            int szam = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("alama");
                while (szam < 10 || szam > 99)
                {
                    try
                    {
                        Console.Write("Kérek egy 2 jegyű számot: ");
                        szam = Convert.ToInt32(Console.ReadLine());
                        if (szam < 10 || szam > 99)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Nem kétgyejű!");
                        }

                    }
                    catch
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nem szám!");
                    }
                }
            }
            
        }
    }
}
