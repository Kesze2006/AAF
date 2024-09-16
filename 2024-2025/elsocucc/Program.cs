using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsocucc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter ir = new StreamWriter("fajl.txt");
            while (true)
            {
                Console.WriteLine("Kérek egy számot:");
                int szam = Convert.ToInt32(Console.ReadLine());
                ir.WriteLine(szam+" "+szam*szam);
                if (szam == 0)
                {
                    break;
                    
                }  
            }
            ir.Close();

            List<int> szamlista  = new List<int>();
            List<int> negyzetlista = new List<int>();
            StreamReader olvas = new StreamReader("fajl.txt");
            while (olvas.EndOfStream != true)
            {
                Console.WriteLine(olvas.ReadLine());

            }
            Console.WriteLine("Összesen {0} sorm van benne");
        }
    }
}
