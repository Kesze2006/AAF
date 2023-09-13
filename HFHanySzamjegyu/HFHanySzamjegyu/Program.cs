using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFHanySzamjegyu
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = -1;

            while(szam < 0 && szam < 999999 || szam < 0 && szam > -999999)
            try
            {
                Console.Write("Kérek egy számot 0 és 999.999 között: ");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam < 0)
                {
                    break;
                }
            }
            catch
            {
                Console.WriteLine("Nem számot adott meg!");
                Console.WriteLine();
            }
            int szamjegy = 0;
            Console.WriteLine(szam);
            if (szam == 0)
            {
                szamjegy += 1;
            }
            while (szam > 0)
            {
                szam /= 10;
                szamjegy += 1;
            }
            Console.WriteLine("A szám "+szamjegy+" számjegyből áll");
        }
    }
}
