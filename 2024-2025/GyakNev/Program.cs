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
            /*StreamReader olavs = new StreamReader("nevek.txt");
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
            */

            StreamReader fiolvas = new StreamReader("nevek.txt");
            StreamReader lanyolvas = new StreamReader("noinevek.txt");
            StreamReader veztekolvas = new StreamReader("vezetek.txt");

            List<string> fiu = new List<string>();
            List<string> lany = new List<string>();
            List<string> veztek = new List<string>();

            while (fiolvas.EndOfStream != true)
            {
                string fiusor = fiolvas.ReadLine();
                string noisor = lanyolvas.ReadLine();
                string vezeteksor = veztekolvas.ReadLine();

                fiu.Add(fiusor);
                lany.Add(noisor);
                veztek.Add(vezeteksor);

            }
            fiolvas.Close();
            lanyolvas.Close();
            veztekolvas.Close();

            StreamWriter ir = new StreamWriter("teljes.txt");

            Random szam = new Random();

            
            

            for (int i = 1; i < 101; i++)
            {
                if (i % 5 != 0)
                {
                    if (szam.Next(2) == 1)
                    {
                        ir.WriteLine(veztek[szam.Next(100)] + " " + fiu[szam.Next(100)]);
                    }
                    else
                    {

                        ir.WriteLine(veztek[szam.Next(100)] + " " + lany[szam.Next(100)]);
                    }
                }
                else
                {
                    if (szam.Next(2) == 1)
                    {
                        ir.WriteLine(veztek[szam.Next(100)] + " " + fiu[szam.Next(100)]+" " + fiu[szam.Next(100)]);
                    }
                    else
                    {

                        ir.WriteLine(veztek[szam.Next(100)] + " " + lany[szam.Next(100)] + " " + lany[szam.Next(100)]);
                    }
                }

            }
            ir.Close();
        }

    }
}
