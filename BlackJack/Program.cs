/*
 * Random szám ami a a kártya kulcsát adja meg majd ha a kártya értékének kiírása egy másik tömbe hogy ne tudja mégeygszer kihúzni
 * Kártya hozzá rendelése a játékos hoz és a kártya értékének megadása*/
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
        Console.WriteLine("Kis i vagy n betű!");
    }
}

