string szoveg = "";
bool vizsga = false;
while (vizsga != true)
{
    Console.Write("Kérek egy több szóból álló szöveget amely szóközzel van elválasztva: ");
    szoveg = Console.ReadLine();
    string [] kell = new string[szoveg.Length];
    kell = szoveg.Split(" ");
    string[] tomb = new string[kell.Length];;
   
    if (kell.Length <= 1)
    {
        Console.WriteLine("Rövid vagy nem szóközzel van elválasztva!");
        Console.WriteLine();
        continue;
    }
    else {
        for (int i = 0; i < kell.Length; i++)
        {
            string valtozo = "";
            string elso = "";
            string jo = "";
            valtozo = kell[i];
            elso = valtozo[0].ToString().ToUpper();
            jo = valtozo.Remove(0, 1);
            valtozo = elso + jo;
            tomb[i] = valtozo;
        }
        for (int i = 0; i < tomb.Length; i++)
        {
            Console.Write(tomb[i]+" ");
        }
        Console.WriteLine();
        vizsga = true;
    }
}


