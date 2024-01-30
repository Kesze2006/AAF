using fogado;

List<adatok> foglalasok = new List<adatok>();

StreamReader olvas = new StreamReader("fogado.txt");

while (!olvas.EndOfStream)
{
    
    string sor = olvas.ReadLine();
    foglalasok.Add(new adatok(sor));    

}
olvas.Close();

//2.feladat
Console.WriteLine("2.feladat:");
Console.WriteLine("{0} darab foglalás volt",foglalasok.Count());

Console.WriteLine();
//3.feldat
Console.WriteLine("3.feladat:");
Console.Write("Kérem az egyik tanár nevét: ");
string nev = Console.ReadLine();

int darab = 0;
for (int i = 0; i < foglalasok.Count(); i++)
{
    if (nev == foglalasok[i].nev)
    {
        darab++;
    }
}
if (darab == 0)
{
    Console.WriteLine("Az adott néven nincs időpont foglalás: {0}", nev);
}
else
{
    Console.WriteLine("{0} darab foglalás volt {1} néven",darab, nev);
}
Console.WriteLine();

//4.feladat
Console.WriteLine("4.feladat:");
Console.WriteLine("Adjon meg egy érvényes időpontot(pl. 17:40): ");
string idopont = Console.ReadLine();
List<string> nevek = new List<string>();

for (int i = 0; i < foglalasok.Count(); i++)
{
    if (idopont == foglalasok[i].idopont)
    {
        nevek.Add(foglalasok[i].nev);
    }
}

nevek.Sort();

for (int i = 0; i < nevek.Count(); i++)
{
    Console.WriteLine(nevek[i]);
}

File.WriteAllLines(idopont.Replace(":", "")+".txt",nevek);
Console.WriteLine();
//5.feldat
adatok min = foglalasok[0];
for (int i = 0; i < foglalasok.Count(); i++)
{
    if (foglalasok[i].foglalas < min.foglalas)
    {
        min = foglalasok[i];
    }
}
Console.WriteLine("5.feldat:");
Console.WriteLine(min);