List<string> szavak = new List<string>();

szavak.Add("Benc-e?");
szavak.Add("Ver Bulecz?");
szavak.Add("Vörös Bor");

for (int i = 0; i < szavak.Count; i++)
{
    Console.WriteLine(szavak[i]);
}
Console.WriteLine();
foreach (string s in szavak)
{
    Console.WriteLine(s);
}
Console.WriteLine();

Console.WriteLine(szavak.Contains("Bence"));
Console.WriteLine(szavak.IndexOf("Bence"));
Console.WriteLine();
Console.WriteLine(szavak.Contains("Vörös Bor"));
Console.WriteLine(szavak.IndexOf("Vörös Bor"));
Console.WriteLine();


Dictionary<string,int> p =  new Dictionary<string,int>();
p.Add("Laci",3);
p.Add("Bence",0);
Console.WriteLine(p.Count());

p["Tomi"] = 4;
Console.WriteLine(p.Count());

try
{
    p.Add("Bence", 10);
}
catch
{
    p["Bence"]--;
}
p.Remove("Bence");
Console.WriteLine(p.Count());

foreach (var s in p)
{ 
    Console.WriteLine(s.Key+" "+s.Value);
}