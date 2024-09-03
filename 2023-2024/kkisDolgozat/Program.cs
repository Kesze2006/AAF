//1
List<int> szamok = new List<int>();
for (int i = 0; i < 500; i++)
{
    Random szam = new Random();
    szamok.Add(szam.Next(10000,100000));
}
StreamWriter ir = new StreamWriter("szamok.csv");
for (int i = 0; i < szamok.Count; i++)
{
    ir.WriteLine(szamok[i]);
}
ir.Close();

//2
int paroszamok = 0;
int paros(List<int> adatok,int paroszamok)
{
    for (int i = 0; i < adatok.Count; i++)
    {
        if (adatok[i] % 2 == 0)
        {
            paroszamok++;
        }
    }
    return paroszamok;
}
Console.WriteLine("{0} páros szám van benne.",paros(szamok, paroszamok));
Console.WriteLine();
//3
int parat = 0;
int paratlan(List<int> adatok,int valami)
{
    for (int i = 0; i < adatok.Count; i++)
    {
        if (adatok[i] % 2 == 0)
        {
            adatok.RemoveAt(i);
        }
    }
    valami = adatok.Sum();
    return valami;
}
Console.WriteLine("{0} ennyi a páratlan számok összege.", paratlan(szamok,parat));
Console.WriteLine();
//4
int elsofele = 0;
int masodikfele = 0;
for (int i = 0; i < szamok.Count/2; i++)
{
    elsofele+= szamok[i];
}
for (int i = szamok.Count/2;i < szamok.Count;i++)
{
    masodikfele += szamok[i];
}
if (elsofele > masodikfele)
{
    Console.WriteLine("A lista első felének az összege nagyobb.");
}
else {
    Console.WriteLine("A lista második felének az összege nagyobb.");
}
Console.WriteLine();
//5
int haromJegyu = 0;
for (int i = 0; i < szamok.Count; i++)
{
    string szam = Convert.ToString(szamok[i]);
    for (int j = 0; j < szam.Length; j++)
    {
        if (szam[0] == '3')
        {
            haromJegyu++;
        }
    }
}
Console.WriteLine("{0} szám van az adatok között ami 3-mal kezdődik.",haromJegyu);
Console.WriteLine();
//6
int[] szamjegyek = new int[9];
for (int i = 0; i < szamok.Count; i++)
{
    string szam = Convert.ToString(szamok[i]);
    for (int j = 0; j < szam.Length; j++)
    {
        switch (szam[0])
        {
            case '1':
                szamjegyek[0]++;
                break;
            case '2':
                szamjegyek[1]++;
                break;
            case '3':
                szamjegyek[2]++;
                break;
            case '4':
                szamjegyek[3]++;
                break;
            case '5':
                szamjegyek[4]++;
                break;
            case '6':
                szamjegyek[5]++;
                break;
            case '7':
                szamjegyek[6]++;
                break;
            case '8':
                szamjegyek[7]++;
                break;
            case '9':
                szamjegyek[8]++;
                break;
        }
    }
}
Console.WriteLine("{0} 1-essel kezdődő {1} 2-essel kezdődő {2} 3-massal kezdődő {3} 4-essel kezdődő {4} 5-össel kezdődő {5} 6-ossal kezdődő {6} 7-essel kezdődő {7} 8-assal kezdődő {8} 9-essel kezdődő szám van",
    szamjegyek[0], szamjegyek[1], szamjegyek[2], szamjegyek[3], szamjegyek[4], szamjegyek[5], szamjegyek[6], szamjegyek[7], szamjegyek[8]);
for (int i = 0; i < szamjegyek.Length;i++)
{
    StreamWriter iro  = new StreamWriter(Convert.ToString(i)+".csv");
    iro.WriteLine(szamjegyek[i]);
    iro.Close();
}
for (int i = 0; i < szamok.Count; i++)
{
    string szam = Convert.ToString(szamok[i]);
    for (int j = 1; j < szam.Length+1; j++)
    {
        if (szam[0] == Convert.ToChar(i))
        {
            StreamWriter iro2 = new StreamWriter(Convert.ToString(i - 1) + ".csv");
            iro2.WriteLine(szam);
        }
    }
}

