using sebesseg;
using System.Text.RegularExpressions;
//1.feladat
List<utSzakasz> utak = new List<utSzakasz>();
int teljes = Convert.ToInt32( File.ReadLines("ut.txt").First());
string[] file = File.ReadAllLines("ut.txt");
for (int i = 1; i < file.Length; i++)
{
    string[] sorok = file[i].Split("\n");
    string[] vag = sorok[0].Split(" ");
    utak.Add(new utSzakasz(int.Parse(vag[0]), vag[1]));
}

//2.feladat
Console.WriteLine("2.feladat");
Console.WriteLine("A települések neve: ");
for (int i = 0; i < utak.Count; i++)
{
    if (Regex.IsMatch(utak[i].jeloles, @"^Varos\d{3}$"))
    {
        Console.WriteLine(utak[i].jeloles);
    }
}
Console.WriteLine();

//3.feladat
Console.WriteLine("3. feladat:");
Console.Write("Adja meg a vizsgált szakasz hosszát km-ben! ");
double be = Convert.ToDouble(Console.ReadLine())*1000;
List<int> sebessegek = new List<int>();
sebessegek.Add(int.Parse(utak[0].jeloles));
for (int i = 0; i < utak.Count; i++)
{
    if (utak[i].szakaszHossza <= be)
    {
        if (utak[i].jeloles == "]")
        {
            sebessegek.Add(90);
        }
        else if (int.TryParse(utak[i].jeloles, out int szam))
        {
            sebessegek.Add(szam);
        }
        else if (Regex.IsMatch(utak[i].jeloles, @"^Varos\d{3}$"))
        {
            sebessegek.Add(50);
        }
    }
}
Console.WriteLine("Az első {0} km-en {1} km/h volt a legalacsonyabb megengedett sebesség.",be/1000,sebessegek.Min());
Console.WriteLine();

//4.feladat
int belul = 0;
int kezdet = -1;
for (int i = 0; i < utak.Count; i++)
{
    if (Regex.IsMatch(utak[i].jeloles, @"^Varos\d{3}$"))
        kezdet = utak[i].szakaszHossza;
    else if (utak[i].jeloles == "]" && kezdet != -1)
    {
        belul += utak[i].szakaszHossza - kezdet;
        kezdet = -1;
    }
}
double szazalek = (double)belul / teljes * 100;
Console.WriteLine("4. feladat:");
Console.WriteLine("Az út {0} százaléka vezet településen belül.",szazalek.ToString("0.00"));
Console.WriteLine();

//5.feladat
Console.WriteLine("5.feladat");
Console.Write("Adj meg egy település nevét! ");
string telepules = Console.ReadLine();

int telKezdet = 0;
int telVege = 0;
int tablakSzama = 0;
bool bent = false;

for (int i = 0; i < utak.Count; i++)
{
    if (utak[i].jeloles == telepules)
    {
        telKezdet = utak[i].szakaszHossza;
        bent = true;
    }
    else if (bent && utak[i].jeloles == "]")
    {
        telVege = utak[i].szakaszHossza;
        bent = false;
    }
    else if (bent)
    {
        int seb;
        if (int.TryParse(utak[i].jeloles, out seb))
            tablakSzama++;
    }
}
int utHossz = telVege - telKezdet;
Console.WriteLine("A sebességkorlátozó táblák száma: {0}",tablakSzama);
Console.WriteLine("Az út hossza a településen belül {0} méter.",utHossz);
Console.WriteLine();

//6.feladat
Console.WriteLine("6.feladat");

string legkozVaros = "";
int maxHossz = int.MinValue;

for (int i = 0; i < utak.Count; i++)
{
    if (Regex.IsMatch(utak[i].jeloles, @"^Varos\d{3}$"))
    {
        if (utak[i].szakaszHossza > maxHossz)
        {
            maxHossz = utak[i].szakaszHossza;
            legkozVaros = utak[i].jeloles;
        }
    }
}

Console.WriteLine("A legközelebbi település: {0}",legkozVaros);
