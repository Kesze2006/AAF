int[] tombKeszit(int darab,int legkisebb, int legnagyobb)
{
    int[] tomb= new int[darab];
    for(int i =0; i < tomb.Length; i++)
    {
        Random rand = new Random();
        tomb[i] = rand.Next(legkisebb,legnagyobb+1);
    }
    return tomb;
}
int[] szamok = tombKeszit(1000,100,999);
/*
int paros = 0;
int paratlan = 0;
for (int i = 0; i < szamok.Length; i++)
{
    
    int valtozo = szamok[i] % 2;
    if (valtozo == 0)
    {
        paros++;
    }
    else { 
        paratlan++;
    }
    
    if (szamok[i] % 2 == 0)
    {
        paros++;
    }
    else {
        paratlan++;
    }
}
bool van = false;
for (int i = 1; i < szamok.Length + 1; i++)
{
    if (szamok[i] == szamok[i - 1])
    {
        van = true;
        Console.WriteLine("Egyenlő: {0} és {1}, {2} = {3}");
    }
}
if (van == true)
{
    Console.WriteLine("Van egyenlő szomszédos eleme!");
}
else {
    Console.WriteLine("Nincs egyenlő szomszédos eleme!");
}

int[] zsamok = new int[szamok.Length];

for (int i = 0; i < szamok.Length-1; i++)
{
    if (szamok[i] < szamok[i + 1])
    {
        zsamok[i] = szamok[i];
    }
}

for (int i = 0; i < zsamok.Length; i++)
{
    Console.WriteLine(zsamok[i]);
}
*/
void szakasz2(int[] szamok)
{
    int kezd = 0;
    int veg = 0;
    int maxKezd = 0;
    int maxVeg = 0;
    for (int i = 1; i < szamok.Length; i++)
    {
        if (szamok[i - 1] < szamok[i])
        {

        }
        else {
            veg = i - 1;
            if (veg - kezd + 1 > maxVeg - maxKezd + 1)
            {
                maxVeg = veg;
                maxKezd = kezd;
            }
            kezd = i;

        }
    }
    for (int i = maxKezd; i < maxVeg+1; i++)
    {
        Console.Write("{0}, ",szamok[i]);
    }
    Console.WriteLine();
}
void szakasz3(int[] szamok)
{
    int kezd = 0;
    int veg = 0;
    int maxKezd = 0;
    int maxVeg = 0;
    for (int i = 1; i < szamok.Length; i++)
    {
        if (szamok[i - 1] >= szamok[i])
        {

        }
        else
        {
            veg = i - 1;
            if (veg - kezd + 1 > maxVeg - maxKezd + 1)
            {
                maxVeg = veg;
                maxKezd = kezd;
            }
            kezd = i;

        }
    }
    for (int i = maxKezd; i < maxVeg + 1; i++)
    {
        Console.Write("{0}, ", szamok[i]);
    }
    Console.WriteLine();
}
szakasz2(szamok);
szakasz3(szamok);