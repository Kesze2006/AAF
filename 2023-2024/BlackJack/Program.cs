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
*/
//Kártya kérése, fügvény? 
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
    else
    {
        Console.WriteLine("Kis -i- vagy -n- az engedélyezett!");
    }
}
while (true)
{
    if (kezdes == "i")
    {
        Dictionary<int, string> olap = new Dictionary<int, string>();
        string[] lapok = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        char[] symbol = new char[] { '♠', '♣', '♦', '♥' };
        int f = 1;
        for (int i = 0; i < lapok.Length; i++)
        {
            for (int j = 0; j < symbol.Length; j++)
            {

                olap.Add(f, lapok[i] + symbol[j]);
                f += 1;
            }
        }
        /*
        foreach (var i in olap)
        {
            Console.Write(i.Key + " ");
            Console.WriteLine(i.Value);
        }
        string[] random = new string[52];
        */
        Random rand = new Random();
        int test = 0;
        int[] kiLapok = new int[4];

        for (int i = 0; i < 4; i++)
        {
            test = rand.Next(0, 53);
            for (int j = 0; j < kiLapok.Length; j++)
            {
                if (test == kiLapok[i])
                {
                    test = rand.Next(0, 53);
                }
                else
                {
                    kiLapok[i] = test;
                }
            }
        }
        string[] ertek = new string[4];
        for (int i = 0; i < kiLapok.Length; i++)
        {
            foreach (var kartya in olap)
            {
                if (kartya.Key == kiLapok[i])
                {
                    ertek[i] = kartya.Value;
                }
            }
        }
        string jatekos1 = ertek[0];
        string jatekos2 = ertek[1];
        string oszto1 = ertek[2];
        string oszto2 = ertek[3];
        Console.WriteLine();
        Console.Write(" Osztó: {0} *", oszto1);
        Console.WriteLine();
        Console.Write(" Játékos: {0} {1}", jatekos1, jatekos2);
        Console.WriteLine();
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
                        kell = false;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Kis -i- vagy -n- az engedélyezett!");
                        break;
                    }
            }
        }

    }
    else
    {
        Console.WriteLine("Viszlát!");
        break;
    }
    //Panel vége
    //Felület
}



