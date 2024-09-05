using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyakNev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader olavs = new StreamReader("nevek.txt");
            List<string> furanevek = new List<string>();
            
            while (olavs.EndOfStream != true)
            {
                string sor = olavs.ReadLine();

                List<string> list = new List<string>();
                for (int i = 0; i < sor.Length; i++)
                {
                    list.Add(Convert.ToString(sor[i]));
                }
                list.Sort(delegate (string item1, string item2) { return String.Compare(item1, item2, false, new CultureInfo("")); });

                furanevek.Add(list[0]);
            }
            for (int i = 0; i < furanevek.Count; i++)
            {
                Console.WriteLine(furanevek[i]);
            }
        }

    }
}
