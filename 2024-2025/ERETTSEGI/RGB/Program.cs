﻿using RGB;

List<Pixel> pontok = new List<Pixel>();
StreamReader olvas = new StreamReader("kep.txt");

int y = 1;
int x = 1;
while (!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    string[] vag = line.Split(" ");
    x = 1;
    for (int i = 0; i < vag.Length; i += 3)
    {
        int r = int.Parse(vag[i]);
        int g = int.Parse(vag[i + 1]);
        int b = int.Parse(vag[i + 2]);
        pontok.Add(new Pixel(x, y, new Szin(r, g, b)));
        x++;
    }
    y++;
}
olvas.Close();

//2.feldat
Console.WriteLine("2.feladat: Kérem egy képpont adatait");
Console.Write("Sor: ");
int sor = int.Parse(Console.ReadLine());
Console.Write("Oszlop: ");
int oszlop =  int.Parse(Console.ReadLine());
var talalat = pontok.Where(pont => pont.x == oszlop && pont.y == sor).First();
Console.WriteLine("A képpont színe {0}", talalat.rgb);

//3.feladat
/*var talalat2 = pontok.Where(ertek => ertek.rgb.osszge() > 600).ToList();
Console.WriteLine(talalat2.Count);
*/
Console.WriteLine("3.feladat");
var vilagosok = pontok.Where(pont => pont.rgb.vilagos()).ToList();
int vilagosokSzama = pontok.Where(pont => pont.rgb.vilagos()).ToList().Count;
Console.WriteLine($"A világos képpontok száma {vilagosok.Count}");

//4.feladat
Console.WriteLine("4.feladat");
int minSzin = pontok.Min(pont => pont.rgb.osszge());
Console.WriteLine($"A legsötétebb pont RGB összege: {minSzin}");
var minSzinesek = pontok.Where(pont => pont.rgb.osszge() == minSzin).Select(pont => pont.rgb.ToString()).ToList();
Console.WriteLine(String.Join("\n",minSzinesek));


//5.feladat
static bool valami(int sor, int elteres, List<Pixel> pontok)
{  
    var uj = pontok.Where(pont => pont.y == sor).ToList();
    List<int> deltaB = new List<int>();
    for (int i = 0; i < uj.Count - 1; i++)
    {
        deltaB.Add(Math.Abs(uj[i].rgb.b - uj[i + 1].rgb.b));
    }
     return Convert.ToBoolean(deltaB.Where(elem => elem > elteres));
}

//6.feladat
Console.WriteLine("6.feladat");

//var felhoSorok = pontok.GroupBy(pont => pont.y).Select(csoport => new { valami(csoport.Key, 10, pontok));

