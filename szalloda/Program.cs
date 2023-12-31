﻿static int fizetendo(int erkezes, int tavozas, int szemelydb, bool etkezes)
{
    int szobaar = 0;
    if (erkezes < 121)
    {
        szobaar = 9000;
    }
    else if (erkezes < 244) szobaar = 10000;
    else szobaar = 8000;

    int ejDb = tavozas - erkezes;
    if (szemelydb > 2)
    {
        szobaar += 2000;
    }
    if (etkezes == true)
    {
        szobaar += szemelydb * 1110;
    }
    return szobaar*ejDb;
}
static int melyikHonap(int napdb,List<int> holKezdodik)
{
    for (int i = 0; i < holKezdodik.Count; i++)
    {
        if (napdb < holKezdodik[i])
        {
            return i;
        }
    }
    return 12;
}








StreamReader olvas = new StreamReader("pitypang.txt");
olvas.ReadLine();
List<int> foglalSzama = new List<int>();
List<int> szobaSzam = new List<int>();
List<int> erkezesNapja = new List<int>();
List<int> tavozasNapja = new List<int>();
List<int> vendegekSzama = new List<int>();
List<bool> reggeli = new List<bool>();
List<string> nev = new List<string>();
while (!olvas.EndOfStream)
{
    string sor  = olvas.ReadLine();

    string[] vag = sor.Split(" ");

    foglalSzama.Add(Convert.ToInt32(vag[0]));
    szobaSzam.Add(Convert.ToInt32(vag[1]));
    erkezesNapja.Add(Convert.ToInt32(vag[2]));
    tavozasNapja.Add(Convert.ToInt32(vag[3]));
    vendegekSzama.Add(Convert.ToInt32(vag[4]));
    reggeli.Add(vag[5] == "1");
    nev.Add(vag[6]);
}
olvas.Close();
//2. feladat
int maxEj = 0;
int maxId =  0;
for (int i = 0; i < foglalSzama.Count; i++)
{
    int hossz = tavozasNapja[i] - erkezesNapja[i];
    if (hossz > maxEj)
    {
        maxEj = hossz;
        maxId = i;
    }
}
Console.WriteLine("2. feladat");
Console.WriteLine("{0} ({1}) - {2}", nev[maxId], erkezesNapja[maxId], maxEj);

int osszeg = 0;
StreamWriter ir = new StreamWriter("bevetel.txt");

for (int i = 0; i < foglalSzama.Count; i++)
{
    int fiz = fizetendo(erkezesNapja[i], tavozasNapja[i], vendegekSzama[i], reggeli[i]);
    ir.WriteLine("{0}:{1}", foglalSzama[i],fiz);
    osszeg += fiz;
}
ir.Close();
Console.WriteLine("Az éves bevétel {0:n0} Ft", osszeg);


olvas = new StreamReader("honapok.txt");
List<string> honapok = new List<string>();
List<int> napSzam = new List<int>();
List<int> holKezdodik = new List<int>();
string sor2 = "";
int mutato = 0;
while (!olvas.EndOfStream)
{
    sor2 = olvas.ReadLine();
    if (mutato == 0)
    {
        honapok.Add(sor2);
    }
    else if (mutato == 1)
    {
        napSzam.Add(Convert.ToInt32(sor2));
    }
    else
    {
        holKezdodik.Add(Convert.ToInt32(sor2));
        mutato = -1;
    }
    mutato++;
}


olvas.Close();
Dictionary<int,int> vendegejszaka = new Dictionary<int,int>();
for (int i = 0; i < foglalSzama.Count(); i++)
{
    Console.WriteLine(erkezesNapja[i]+" "+tavozasNapja[i]);
}
Console.WriteLine(melyikHonap(45, holKezdodik));










