/*
Console.Write("Kérek egy számot: ");
int szam = Convert.ToInt32(Console.ReadLine());
int[] nagy = new int[szam];
string[] szoveg = new string[szam];
for (int i = 0; i < szam; i++)
{
    Console.Write("Kérem a szöveget: ");
    string elso = Console.ReadLine();
    szoveg[i] = elso;
    nagy[i] = elso.Length;
}
string max = "";
int maxIndex = 0;
for (int i = 0; i < szoveg.Length; i++)
{
    if (szoveg[i].Length > max.Length)
    {
        max = szoveg[i];
        maxIndex = i;
    }
}

maxIndex = 0;
for (int i = 0; i < szoveg.Length; i++)
{
    if (szoveg[i].Length > szoveg[maxIndex].Length)
    {
        maxIndex = i;
    }
}
Console.WriteLine(szoveg[maxIndex]);
*/
/*
string[] szavak = new string[] { "alma", "körte", "narancs", "mandula", "ananász", "banán", };

string[] rovid = new string[szavak.Length];
string[] hosszu = new string[szavak.Length];

int jelzo1 = 0;
int jelzo2 = 0;
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length <= 5)
    {
        rovid[jelzo1] = szavak[i];
        jelzo1++;
    }
    else {
        hosszu[jelzo2] = szavak[i];
        jelzo2++;
    }
}
for (int i = 0; i < rovid.Length; i++)
{
    Console.WriteLine(rovid[i]);
}
for (int i = 0; i < hosszu.Length; i++)
{
    Console.WriteLine(hosszu[i]);
}
*/
int[] tomb =  new int[1000];
for (int i = 0; i < tomb.Length; i++)
{
    Random rand = new Random();
    tomb[i] = rand.Next(100,1000);
}
for (int i = 0; i < tomb.Length; i++)
{
    Console.WriteLine(tomb[i]);
}
Console.WriteLine();
Console.WriteLine(tomb.Length);
