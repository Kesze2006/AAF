using konyvek;

//1.feladat
List<Konyv> konyvecskek = new List<Konyv>();

string[] sorok =  File.ReadAllLines("kiadas.txt");

foreach (string s in sorok)
{
    string[] vag = s.Split(";");
    konyvecskek.Add(new Konyv(int.Parse(vag[0]), int.Parse(vag[1]), vag[2], vag[3], int.Parse(vag[4])));

}

//2.feladat
Console.WriteLine("2.feladat: ");
Console.Write("Kérek egy szerzőt: ");
string szerzo = Console.ReadLine();
int db = 0;
foreach (Konyv x in konyvecskek)
{
    if (x.leiras.Contains(szerzo))
    {
        db++;
    }
}
if (db == 0)
{
    Console.WriteLine("Nem adtak ki");
}
else 
{
    Console.WriteLine($"{db} könyvkiadás");
}

//3.feladat
Console.WriteLine("3.feladat: ");
List<int> kiadasok = new List<int>();
foreach (Konyv x in konyvecskek)
{
    kiadasok.Add(x.peldanySzam);
}
int max = kiadasok.Max();
db = 0;
for (int i = 0; i < kiadasok.Count; i++)
{
    if (kiadasok[i] == max)
    {
        db++;
    }

}
Console.WriteLine($"Legnagyobb példányszámban: {max}, előfordult {db} alkalommal.");

//4.feladat
Console.WriteLine("4.feladat: ");
foreach (Konyv x in konyvecskek)
{
    if (x.eredet == "kf" && x.peldanySzam > 40000)
    {
        Console.WriteLine($"{x.ev}/{x.negyedEv}. {x.leiras}");
    }
}

//5.feladat
List<int> evek = new List<int>();
List<int> magyarKiadas = new List<int>();
List<int> magyarPeldanyszam = new List<int>();
List<int> kulfoldiKiadas = new List<int>();
List<int> kulfoldiPeladanyszam = new List<int>();

foreach (Konyv x in konyvecskek)
{
    if (!evek.Contains(x.ev))
    {
        evek.Add(x.ev);
    }
}
for (int i = 0; i < evek.Count; i++)
{
    int magyar = 0;
    int magyarKi = 0;
    int kulfold = 0;
    int kulfoldKi = 0;
    foreach (Konyv x in konyvecskek)
    {
        if (x.ev == evek[i] && x.eredet == "ma")
        {
            magyar += 1;
            magyarKi += x.peldanySzam;
        }
        else if (x.ev == evek[i] && x.eredet == "kf")
        {
            kulfold++;
            kulfoldKi += x.peldanySzam;
        }
    }
    magyarKiadas.Add(magyar);
    magyarPeldanyszam.Add(magyarKi);
    kulfoldiKiadas.Add(kulfold);
    kulfoldiPeladanyszam.Add(kulfoldKi);
}

string tablazat = @"<table>
        <tr><th>Év</th><th>Magyar kiadás</th><th>Magyar példányszám</th><th>Külföldi kiadás</th><th>Külföldi példányszám</th></tr>
";

for (int i = 0; i < evek.Count; i++)
{
    tablazat += $"<tr><td>{evek[i]}</td><td>{magyarKiadas[i]}</td><td>{magyarPeldanyszam[i]}</td><td>{kulfoldiKiadas[i]}</td><td>{kulfoldiPeladanyszam[i]}</td></tr>\r\n ";
}
tablazat += "</table>";
File.WriteAllText("tabla.html",tablazat);

//6.feladat
Console.WriteLine("6.feladat: ");
Console.WriteLine("Legalább kétszer, nagyobb példányszámban újra kiadott könyvek: ");
List<string> leiras = new List<string>();
foreach (Konyv x in konyvecskek)
{
    leiras.Add(x.leiras);
}

for (int i = 0; i < leiras.Count; i++)
{
    db = 0;
    foreach (Konyv x in konyvecskek)
    {
        if (x.leiras == leiras[i])
        {
            db++; 
        }
    }
    db--;
    if (db >= 2)
    {
        Console.WriteLine(leiras[i]);
    }
}