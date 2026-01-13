//1.feladat
using System.Text.RegularExpressions;

Console.WriteLine("1.feladat");
string[] konyv = File.ReadAllLines("konyv.txt");
foreach (string sor in konyv)
{
    Console.WriteLine(sor);
}

//2.feladat
Console.WriteLine("2.feladat");
Console.Write("Kérem adja meg az ismétlések számát: ");
int ismSzám = int.Parse(Console.ReadLine());
string sokKonyv = "";
char z = ' ';
int t = 4;
int l = 0;
for (int j = 0; j < konyv.Length; j++)
{
    if (j == 0)
    {
        for (int i = 0; i < ismSzám; i++)
        {
            sokKonyv += new string(z, t) + konyv[j].Trim() + "  " + "|";
        }
        sokKonyv += "\n";
        t--;
        l++;
    }
    else
    {
        for (int i = 0; i < ismSzám; i++)
        {
            sokKonyv += new string(z, t) + konyv[j].Trim() + new string(z, l) + "|";
        }
    sokKonyv += "\n";
    t--;
    l++;
    }
}
Console.WriteLine(sokKonyv);

//3.feladat
static void atalakit(string sor)
{
    string[] darabok = sor
            .Select(c => c)
            .Chunk(2)
            .Select(chunk => new string(chunk))
            .ToArray();
    string szoveg = "";
    for (int i = 0; i < darabok.Length; i++)
    {
        int szam = darabok[i][0];
        for (int j = 0; j < szam; j++)
        {
            szoveg += darabok[i][1];
        }
    }
    Console.WriteLine(szoveg);
}
atalakit("9.9:8,7_");
