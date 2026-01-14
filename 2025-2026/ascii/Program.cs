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
static string atalakit(string sor)
{
    string[] darabok = sor
            .Select(c => c)
            .Chunk(2)
            .Select(chunk => new string(chunk))
            .ToArray();
    string szoveg = "";
    for (int i = 0; i < darabok.Length; i++)
    {
        int szam = int.Parse(darabok[i][0].ToString());
        for (int j = 0; j < szam; j++)
        {
            szoveg += darabok[i][1];
        }
    }
    return szoveg+"\n";
}

//4.feladat
Console.WriteLine("4.feladat");
string[] abra = File.ReadAllLines("szg_t.txt");
string rajz = "";
StreamWriter w = new StreamWriter("szg.txt");
foreach (string sor in abra)
{
    rajz += atalakit(sor);
}
w.Write(rajz);
w.Close();
Console.WriteLine(rajz);

//5.feladat
Console.WriteLine("5.feladat");
Console.Write("Kérem adja meg a tömörített ábra fájlnevét: ");
string tomoritett = Console.ReadLine();
Console.Write("Kérem adja meg a tömörítetlen ábra fájlnevét: ");
string tomoritetlen = Console.ReadLine();
int tomoritettHossz = File.ReadAllText(tomoritett)
    .Count(c => c != '\r' && c != '\n');
int tomoritetlenHossz = File.ReadAllText(tomoritetlen)
    .Count(c => c != '\r' && c != '\n');
Console.WriteLine("A karakterek száma a tömörített állományban: {0}", tomoritettHossz);
Console.WriteLine("A karakterek száma a tömörítetlen állományban: {0}", tomoritetlenHossz);
Console.WriteLine("A tömörítési arány: {0:F2}", (double)tomoritettHossz / tomoritetlenHossz);

//6.feladat
Console.WriteLine("6.feladat");
string[] sorok = File.ReadAllLines("konyv.txt");
int sorokSzama = sorok.Length;
Console.WriteLine("Az ábra magassága sorokban: {0}",sorokSzama);
