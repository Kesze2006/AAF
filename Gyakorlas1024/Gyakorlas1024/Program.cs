Console.Write("Kérek egy szót: ");
string szo = Console.ReadLine();
int index = 0;
string jok = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm-";
bool fel = false;
bool fel2 = false;
while (fel == false)
{
    for (int i = 0; i < szo.Length; i++)
    {
        index = jok.IndexOf(szo.ToLower()[i]);
        if (index == -1)
        {
            fel2 = true;
        }
        else { 
        }
    }
    if (fel2 == true)
    {
        Console.WriteLine("Nem szó!");
        fel = true;
        break;
    }
    else {
        Console.WriteLine("Szó!");
        fel = true;
        break;
    }
}
string forditott = "";
for (int i = szo.Length-1; i >= 0; i--)
{
    forditott += szo[i];
}
Console.WriteLine(forditott);
string forditott2 = "";
for (int  i = 0; i < szo.Length; i+=2)
{
    forditott2 += szo.Substring(szo.Length-1-1-i,2);
}
Console.WriteLine(forditott2);
/*
HF Meik betűből hány darab van?
 */