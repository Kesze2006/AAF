/*
 * Random szám ami a a kártya kulcsát adja meg majd ha a kártya értékének kiírása egy másik tömbe hogy ne tudja mégeygszer kihúzni
 * Kártya hozzá rendelése a játékos hoz és a kártya értékének megadása*/
//Panel
/*
string kezdes = "";
while (true)
{
    Console.Write("Kezdőthet a játék? (i/n) : ");
    kezdes = Console.ReadLine();
    if (kezdes == "i")
    {
        break;
    }
    else if (kezdes == "n")
    {
        break;
    }
    else {
        Console.WriteLine("Kis -i- vagy -n- az engedélyezett!");
    }
}
if (kezdes == "i")
{
    //jatek();
}
else
{
    Console.WriteLine("Viszlát!");
}
*/
//Panel vége
//Felület
Console.WriteLine();
Console.Write(" Osztó: kártya kártya");
Console.WriteLine();
Console.Write(" Játékos: kártya kártya");
Console.WriteLine();
bool kell = true;
while (kell)
{
    Console.Write("Kér lapot? i/n : ");
    string lap = Console.ReadLine();
    switch (lap)
    {
        case "i":
            {
                kell = false;
                break;
            }
        case "n":
            {
                kell= false;
                break;
            }
        default:
            {
                Console.WriteLine("Kis -i- vagy -n- az engedélyezett!");
                break;
            }
    }
}

