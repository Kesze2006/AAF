using viragAgyas;

List<adatok> viragok =  new List<adatok>();

string[] sorok = File.ReadAllLines("felajanlas.txt");

int agyasDB = int.Parse(sorok[0]);
//1.feladat

for (int i = 0; i < sorok.Length; i++)
{
    viragok[i].sorSzam = i + 1;
}

viragok = sorok.Skip(1).Select(sor => new adatok(sor)).ToList();//skippeli az első elemet majd kiválasztja a sor adatait majd minden adatból csinál egy példányt amit egy listába rak

//2.feladat
Console.WriteLine("2. feladat: A felajánlások száma {0}",viragok.Count);

//3.feladat
Console.WriteLine("3. feladat: A bejárat mindkét oldalán ültetők: ");

Console.WriteLine(String.Join(", ", viragok.Where(e => e.kapuBentVan).Select(e => e.sorSzam)));

/*foreach (adatok v in viragok)
{
    if (v.kapuBentVan == true)
    {
        Console.WriteLine(v.sorSzam);
    }
}
*/