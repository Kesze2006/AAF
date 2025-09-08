using autoapp;

List<Auto> autok = Auto.Vag();

//5.feladat
Console.Write("5.feladat: ");
Console.WriteLine("{0} autó található a listában",autok.Count);

//6.feladat
Console.Write("6.feladat: ");
int összDB = 0;
foreach (Auto auto in autok)
{
    összDB += auto.eladottDB;
}
Console.WriteLine("Az autók esetében az átlagosan eladottdarabszám {0}", Math.Round((double)összDB / autok.Count,1));

//7.feladat
Console.Write("7.feladat: ");
Console.WriteLine("Az elmúlt 5 évebn gyártott autók: ");
foreach (Auto auto in autok)
{
    if (auto.gyartasiEv >= 2024 - 5)
    {
        Console.WriteLine("\t - {0} {1}: {2}", auto.marka, auto.modell, auto.gyartasiEv);
    }
}

//8.feladat
Console.Write("8.feladat: ");
Console.WriteLine("Legsikeresebb márkák listája az eladott darabszám alapján: ");

Dictionary<string,int> sikeresAutok = new Dictionary<string,int>();
foreach (Auto auto in autok)
{
    
}