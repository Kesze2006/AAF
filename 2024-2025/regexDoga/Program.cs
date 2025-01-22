using System.Text.RegularExpressions;

string fajl = File.ReadAllText("generated_log_2024-12-16T09_53_52.397Z.txt");

Regex elso = new Regex(@"POST .+\d{3} (\d+) ");
Regex masodik = new Regex(@"DELETE");
Regex haramadik = new Regex(@"https://www\.(\S+)\.com");
Regex negyedik = new Regex(@"""(\S+) (\S+) .+ (\d{3}) (\d+) ""-""");
Regex otodik = new Regex(@" ([A-Z][a-z]+/\S+ [A-Z][a-z]+/\S+)""");

var talalat1 = elso.Matches(fajl);
var talalat2 = masodik.Matches(fajl);
var talalat3 = haramadik.Matches(fajl);
var talalat4 = negyedik.Matches(fajl);
var talalat5 = otodik.Matches(fajl);


StreamWriter ir = new StreamWriter("noreferer.log");
foreach (Match match in talalat4)
{
    string szoveg = $"{match.Groups[1]}\t{match.Groups[2]}\t{match.Groups[3]}";

    ir.WriteLine(szoveg);
}
ir.Close();

int adatMeny = 0;
foreach (Match match in talalat1)
{
    adatMeny += Convert.ToInt32(match.Groups[1].Value);
}
Console.WriteLine($"A POST adatok mennyisége: {adatMeny}");
Console.WriteLine($"A törlések száma: {talalat2.Count()}");


Dictionary <string, int> adatok = new Dictionary<string, int>();
foreach (Match elem in talalat3)
{
    string egyezik = elem.Groups[1].Value;
   
    if (adatok.ContainsKey(egyezik))
    {
        adatok[egyezik]++;
    }
    else
    {
        adatok[egyezik] = 1;
    }
    
}
List<int> elofordulas = new List<int>();
foreach (var elem in adatok)
{
    elofordulas.Add(elem.Value);
}
int legtobb = elofordulas.Max();
string oladNeve = "";
foreach (var elem in adatok)
{
    if (elem.Value == legtobb)
    {
        oladNeve = elem.Key;
    }
}
Console.WriteLine($"A legtöbbet látogatott oldal {oladNeve} volt {legtobb} alkalommal");

Dictionary<string, int> adatok2 = new Dictionary<string, int>();
foreach (Match elem in talalat5)
{
    string egyezik = elem.Groups[1].Value;

    if (adatok2.ContainsKey(egyezik))
    {
        adatok2[egyezik]++;
    }
    else
    {
        adatok2[egyezik] = 1;
    }
}
foreach(var elem in adatok2)
{
    Console.WriteLine($"{elem.Key}: {elem.Value}");
}