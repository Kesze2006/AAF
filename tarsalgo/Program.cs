using tarsalgo;

List<olvas> adatok = new List<olvas>();

StreamReader beolvas = new StreamReader("ajto.txt");

while (!beolvas.EndOfStream)
{
    string sor = beolvas.ReadLine();

    adatok.Add(new olvas(sor));
}

beolvas.Close();
//2.feldat
Console.WriteLine("2.feldat: ");
List<int> index = new List<int>();
for (int i = 0; i < adatok.Count; i++)
{
    if (Convert.ToString(adatok[i].irany) == "be")
    {
        Console.WriteLine("Az első belépő: "+adatok[i].azonosito);
        break;
    }
}
for (int i = 0; i < adatok.Count; i++)
{
    if (adatok[i].irany == "ki")
    {
        index.Add(adatok[i].azonosito);
    }
}
Console.WriteLine("Az utólsó kilépő: "+index[index.Count-1]);

//3.feldat
int[] szamok = new int[100];
for (int i = 1; i < 101; i++)
{
    int bejarasok = 0;
    for (int j = 0; j < adatok.Count; j++)
    {
        if (i == adatok[j].azonosito)
        {
            bejarasok++;
        }
    }
    Console.WriteLine(bejarasok);
    szamok[i-1] = bejarasok;
}
StreamWriter ir = new StreamWriter("athaladas.txt");

for (int i = 0; i < szamok.Length; i++)
{
    ir.WriteLine("Azonasító: {0} Bejárás: {1}", i + 1, szamok[i]);
}
ir.Close();

//4.feldat
Console.WriteLine();
Console.WriteLine("4.feldat: ");
List<int> negy = new List<int>();
for (int i = 0; i < adatok.Count; i++)
{
    if (adatok[i].ora == adatok[adatok.Count - 1].ora)
    {
        negy.Add(adatok[i].azonosito);
    }
}
for (int i = 0; i < negy.Count; i++)
{
    Console.WriteLine(negy[i]);
}
//5.feladat
int[] orak = new int[5];
for (int i = 9; i < 14; i++)
{
    for (int j = 0; j < adatok.Count; j++)
    {

    }
}