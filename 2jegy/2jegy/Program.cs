using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2jegy
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = "";
            while (v != "Kilép")
            {
                Console.Write("Kérek egy számot: ");
                v = Console.ReadLine();
                if (v != "Kilép")
                {
                    
                    int szam = int.Parse(v);
                    int mar = 0;
                    Console.WriteLine();
                    if (szam / 10 == 1)
                    {
                        mar = szam % 10;
                        switch (mar)
                        {
                            case 1:
                                Console.WriteLine("Tizenegy");
                                break;

                            case 2:
                                Console.WriteLine("Tizenkettő");
                                break;

                            case 3:
                                Console.WriteLine("Tizenhárom");
                                break;

                            case 4:
                                Console.WriteLine("Tizennégy");
                                break;

                            case 5:
                                Console.WriteLine("Tizenöt");
                                break;

                            case 6:
                                Console.WriteLine("Tizenhat");
                                break;

                            case 7:
                                Console.WriteLine("Tizenhét");
                                break;

                            case 8:
                                Console.WriteLine("Tizennyolc");
                                break;

                            case 9:
                                Console.WriteLine("Tizenkilenc");
                                break;

                            case 0:
                                Console.WriteLine("Tíz");
                                break;

                        }
                    }
                    if (szam / 20 == 1)
                    {
                        mar = szam % 20;
                        switch (mar)
                        {
                            case 1:
                                Console.WriteLine("Huszonegy");
                                break;

                            case 2:
                                Console.WriteLine("Huszonkettő");
                                break;

                            case 3:
                                Console.WriteLine("Huszonhárom");
                                break;

                            case 4:
                                Console.WriteLine("Huszonnégy");
                                break;

                            case 5:
                                Console.WriteLine("Huszonöt");
                                break;

                            case 6:
                                Console.WriteLine("Huszonhat");
                                break;

                            case 7:
                                Console.WriteLine("Huszonhét");
                                break;

                            case 8:
                                Console.WriteLine("Huszonnyolc");
                                break;

                            case 9:
                                Console.WriteLine("Huszonkilenc");
                                break;

                            case 0:
                                Console.WriteLine("Húsz");
                                break;

                        }
                    }
                    if (szam / 30 == 1)
                    {
                        mar = szam % 30;
                        switch (mar)
                        {
                            case 1:
                                Console.WriteLine("Harmincegy");
                                break;

                            case 2:
                                Console.WriteLine("Harminckettő");
                                break;

                            case 3:
                                Console.WriteLine("Harminchárom");
                                break;

                            case 4:
                                Console.WriteLine("Harmincnégy");
                                break;

                            case 5:
                                Console.WriteLine("Harmincöt");
                                break;

                            case 6:
                                Console.WriteLine("Harminchat");
                                break;

                            case 7:
                                Console.WriteLine("Harminchét");
                                break;

                            case 8:
                                Console.WriteLine("Harmincnyolc");
                                break;

                            case 9:
                                Console.WriteLine("Harminckilenc");
                                break;

                            case 0:
                                Console.WriteLine("Harminc");
                                break;

                        }
                    }
                    if (szam / 40 == 1)
                    {
                        mar = szam % 40;
                        switch (mar)
                        {
                            case 1:
                                Console.WriteLine("Negyvenegy");
                                break;

                            case 2:
                                Console.WriteLine("Negyvenkettő");
                                break;

                            case 3:
                                Console.WriteLine("Negyvenhárom");
                                break;

                            case 4:
                                Console.WriteLine("Negyvennégy");
                                break;

                            case 5:
                                Console.WriteLine("Negyvenöt");
                                break;

                            case 6:
                                Console.WriteLine("Negyvenhat");
                                break;

                            case 7:
                                Console.WriteLine("Negyvenhét");
                                break;

                            case 8:
                                Console.WriteLine("Negyvennyolc");
                                break;

                            case 9:
                                Console.WriteLine("Negyvenkilenc");
                                break;

                            case 0:
                                Console.WriteLine("Negyven");
                                break;

                        }
                    }
                    if (szam / 50 == 1)
                    {
                        mar = szam % 50;
                        switch (mar)
                        {
                            case 1:
                                Console.WriteLine("Ötvenegy");
                                break;

                            case 2:
                                Console.WriteLine("Ötvenkettő");
                                break;

                            case 3:
                                Console.WriteLine("Ötvenhárom");
                                break;

                            case 4:
                                Console.WriteLine("Ötvennégy");
                                break;

                            case 5:
                                Console.WriteLine("Ötvenöt");
                                break;

                            case 6:
                                Console.WriteLine("Ötvenhat");
                                break;

                            case 7:
                                Console.WriteLine("Ötvenhét");
                                break;

                            case 8:
                                Console.WriteLine("Ötvennyolc");
                                break;

                            case 9:
                                Console.WriteLine("Ötvenkilenc");
                                break;

                            case 0:
                                Console.WriteLine("Ötven");
                                break;

                        }
                    }
                    if (szam / 60 == 1)
                    {
                        mar = szam % 60;
                        switch (mar)
                        {
                            case 1:
                                Console.WriteLine("Hatvanegy");
                                break;

                            case 2:
                                Console.WriteLine("Hatvankettő");
                                break;

                            case 3:
                                Console.WriteLine("Hatvanhárom");
                                break;

                            case 4:
                                Console.WriteLine("Hatvannégy");
                                break;

                            case 5:
                                Console.WriteLine("Hatvanöt");
                                break;

                            case 6:
                                Console.WriteLine("Hatvanhat");
                                break;

                            case 7:
                                Console.WriteLine("Hatvanhét");
                                break;

                            case 8:
                                Console.WriteLine("Hatvannyolc");
                                break;

                            case 9:
                                Console.WriteLine("Hatvankilenc");
                                break;

                            case 0:
                                Console.WriteLine("Hatvan");
                                break;

                        }
                    }
                    if (szam / 70 == 1)
                    {
                        mar = szam % 70;
                        switch (mar)
                        {
                            case 1:
                                Console.WriteLine("Hetvenegy");
                                break;

                            case 2:
                                Console.WriteLine("Hetvenkettő");
                                break;

                            case 3:
                                Console.WriteLine("Hetvenhárom");
                                break;

                            case 4:
                                Console.WriteLine("Hetvennégy");
                                break;

                            case 5:
                                Console.WriteLine("Hetvenöt");
                                break;

                            case 6:
                                Console.WriteLine("Hetvenhat");
                                break;

                            case 7:
                                Console.WriteLine("Hetvenhét");
                                break;

                            case 8:
                                Console.WriteLine("Hetvennyolc");
                                break;

                            case 9:
                                Console.WriteLine("Hetvenkilenc");
                                break;

                            case 0:
                                Console.WriteLine("Hetven");
                                break;

                        }
                    }
                    if (szam / 80 == 1)
                    {
                        mar = szam % 80;
                        switch (mar)
                        {
                            case 1:
                                Console.WriteLine("Nyolcvanegy");
                                break;

                            case 2:
                                Console.WriteLine("Nyolcvankettő");
                                break;

                            case 3:
                                Console.WriteLine("Nyolcvanhárom");
                                break;

                            case 4:
                                Console.WriteLine("Nyolcvannégy");
                                break;

                            case 5:
                                Console.WriteLine("Nyolcvanöt");
                                break;

                            case 6:
                                Console.WriteLine("Nyolcvanhat");
                                break;

                            case 7:
                                Console.WriteLine("Nyolcvanhét");
                                break;

                            case 8:
                                Console.WriteLine("Nyolcvannyolc");
                                break;

                            case 9:
                                Console.WriteLine("Nyolcvankilenc");
                                break;

                            case 0:
                                Console.WriteLine("Nyolcvan");
                                break;

                        }
                    }
                    if (szam / 90 == 1)
                    {
                        mar = szam % 90;
                        switch (mar)
                        {
                            case 1:
                                Console.WriteLine("Kilencvenegy");
                                break;

                            case 2:
                                Console.WriteLine("Kilencvenkettő");
                                break;

                            case 3:
                                Console.WriteLine("Kilencvenhárom");
                                break;

                            case 4:
                                Console.WriteLine("Kilencvennégy");
                                break;

                            case 5:
                                Console.WriteLine("Kilencvenöt");
                                break;

                            case 6:
                                Console.WriteLine("Kilencvenhat");
                                break;

                            case 7:
                                Console.WriteLine("Kilencvenhét");
                                break;

                            case 8:
                                Console.WriteLine("Kilencvennyolc");
                                break;

                            case 9:
                                Console.WriteLine("Kilencvenkilenc");
                                break;

                            case 0:
                                Console.WriteLine("Kilencven");
                                break;

                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine(szam);
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
