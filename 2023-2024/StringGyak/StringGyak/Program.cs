
string szoveg = "Helló Bence!";
for (int i = 0; i < szoveg.Length; i++)
{
    Console.WriteLine(szoveg[i]);
}
Console.WriteLine();
foreach (char s in szoveg)
{
    Console.WriteLine(s);
}
Console.WriteLine();
for (int i = 0; i < szoveg.Length; i++)
{
    Console.WriteLine(szoveg.Substring(i,1));
}
Console.WriteLine();
Console.WriteLine(szoveg.ToUpper());
Console.WriteLine();

string[] darab = szoveg.Split(" ");
Console.WriteLine(darab[0] +" "+darab[1].ToUpper());
Console.WriteLine();

Console.WriteLine(szoveg.Substring(0,szoveg.IndexOf(" "))+" "+szoveg.Substring(szoveg.IndexOf(" ")+1).ToUpper());