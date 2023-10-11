Console.Write("Hány sor legyen?");
int sor = Convert.ToInt32(Console.ReadLine());

Console.Write("Hány oszlop legyen?");
int oszlop = Convert.ToInt32(Console.ReadLine());

string[,] tabla= new string[sor,oszlop];
for(int i = 0; i <tabla.GetLength(0); i++)
{
    for(int k = 0; k< tabla.GetLength(1); k++)
    {
        tabla[i, k] += "";
        for (int m = 0; m < (i + 1); m++)
        {
            tabla[i, k] += "a";
        }
        for (int m = 0; m < (k + 1); m++) 
        {
            tabla[i, k] += "b";
        }
    }
}
for (int i = 0; i < tabla.GetLength(0); i++)
{
    for (int k = 0; k < tabla.GetLength(1); k++)
    {
        Console.Write("{0} ",tabla[i, k]);
    }
    Console.WriteLine();
}
foreach (string szo in tabla)
{
    int szam = 0;
    if (szam < 3)
    {
        Console.Write(szo + " ");
        szam++;
    }
    else {
        Console.Write(szo + " ");
        Console.WriteLine();
    }
}