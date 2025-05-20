
using Morze;
using System.Xml.Schema;

List<Kodolas> morze =  new List<Kodolas>();

string[] sorok = File.ReadAllLines("morzeabc.txt");

for (int i = 1; i < sorok.Length; i++)
{
    string[] vag = sorok[i].Split("\t");
    morze.Add(new Kodolas(vag[0], vag[1]));
}
//3.feldat
Console.WriteLine("3.feladat: A morze abc {0} db karakter kódját tartalmazza",morze.Count);

//4.feladat
Console.Write("4.feladat: Kérek egy betüt: ");
string bekertBetu = Console.ReadLine();
List<Kodolas> karakter = morze.Where(x => x.betu == bekertBetu).ToList();
if (karakter.Count != 0)
{
    Console.WriteLine("A {0} karakter morze kódja: {1}", bekertBetu, karakter[0].morzeKod);
}
else
{
    Console.WriteLine("Nem található a kódtárban ilyen karakter");
}

sorok = File.ReadAllLines("morze.txt");
List<Fordito> szovegek = new List<Fordito>();
for (int i = 0; i < sorok.Length; i++)
{
    string[] vag = sorok[i].Split(";");
    szovegek.Add(new Fordito(vag[0], vag[1]));
}
