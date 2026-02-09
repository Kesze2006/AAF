using konyvek;

//1.feladat
List<konyv> konyvek =  new List<konyv>();
string[] file = File.ReadAllLines("kiadas.txt");

foreach (string line in file)
{
    string[] adatok = line.Split(';');
    konyv adat = new konyv(int.Parse(adatok[0]), int.Parse(adatok[1]), adatok[2], adatok[3], int.Parse(adatok[4]));
    konyvek.Add(adat);
}

//2.feladat
Console.WriteLine("2.feladat:");
Console.Write("Szerző: ");
string nev = Console.ReadLine();
int db = 0;
foreach (konyv konyv in konyvek)
{
    if (konyv.leiras.Split(":")[0].Contains(nev))
    {
        db++;
    }
}
if (db == 0)
{
    Console.WriteLine("Nem adtak ki!\n");
}
else
{
    Console.WriteLine("{0} könyvkiadás\n", db);
}

//3.feladat
Console.WriteLine("3.feladat");
int max = 0;
db = 0;
foreach (konyv konyv in konyvek)
{
    if (konyv.peldanyszam > max)
    {
        max = konyv.peldanyszam;
    }
}
foreach (konyv konyv in konyvek)
{
    if (konyv.peldanyszam == max)
    {
        db++;
    }
}
Console.WriteLine("Legnagyobb példányszám: {0}, előfordult {1} alkalommal\n",max,db);

//4.feladat
Console.WriteLine("4.feladat");
foreach (konyv konyv in konyvek)
{
    if (konyv.peldanyszam >= 40000 && konyv.eredet == "kf")
    {
        Console.WriteLine("{0}/{1}. {2}\n",konyv.kiadasEv,konyv.kiadasNegyedEv,konyv.leiras);
        break;
    }
}

//5.feladat
List<int> evek = new List<int>();
List<int> magyarKiadas = new List<int>();
List<int> magyarPeldanyszam = new List<int>();
List<int> kulfoldiKiadas = new List<int>();
List<int> kulfoldiPeladanyszam = new List<int>();

foreach (konyv x in konyvek)
{
    if (!evek.Contains(x.kiadasEv))
    {
        evek.Add(x.kiadasEv);
    }
}
for (int i = 0; i < evek.Count; i++)
{
    int magyar = 0;
    int magyarKi = 0;
    int kulfold = 0;
    int kulfoldKi = 0;
    foreach (konyv x in konyvek)
    {
        if (x.kiadasEv == evek[i] && x.eredet == "ma")
        {
            magyar += 1;
            magyarKi += x.peldanyszam;
        }
        else if (x.kiadasEv == evek[i] && x.eredet == "kf")
        {
            kulfold++;
            kulfoldKi += x.peldanyszam;
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
File.WriteAllText("tabla.html", tablazat);

//6.feladat
Console.WriteLine("6.feladat: ");
Console.WriteLine("Legalább kétszer, nagyobb példányszámban újra kiadott könyvek: ");
List<string> leiras = new List<string>();
foreach (konyv x in konyvek)
{
    leiras.Add(x.leiras);
}

for (int i = 0; i < leiras.Count; i++)
{
    db = 0;
    foreach (konyv x in konyvek)
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