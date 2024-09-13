using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak0913
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kutya k = new kutya("fasz");

            k.ugat();
            k.suly = -145;
            Console.WriteLine(k.suly);
            Console.WriteLine(kutya.ezMiEz());
        }
    }
}
