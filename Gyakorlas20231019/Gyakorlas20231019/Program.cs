int[] tombKeszit(int darab, int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    for (int i = 0; i < tomb.Length; i++)
    {
        Random rand = new Random();
        tomb[i] = rand.Next(legkisebb, legnagyobb + 1);
    }
    return tomb;
}
int[] szamok = tombKeszit(100,1000,9999);
void szakasz2(int[] szamok)
{
    for (int i = 0; i < szamok.Length-2; i++)
    {
        Console.WriteLine("{0}, {1}, {2}", i,i+1,i + 2);
        Console.WriteLine("{0}, {1}, {2}", szamok[i], szamok[i + 1], szamok[i+2]);
    }
}
szakasz2(szamok);