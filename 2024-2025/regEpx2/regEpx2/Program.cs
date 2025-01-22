
using System.Linq.Expressions;
using System.Text.RegularExpressions;

string text = File.ReadAllText("generated_log_2024-12-11T11_21_39.997Z.txt");

Regex minta = new Regex(@"""(\w+) (\S+ \S+)"" (\d+ \d+) ");

//. bármi lehet
//* bármennyi számú karakter
//+ az adott karakter után ugyan olyan lesz
//$ utolsó illeszkedés
//^első illeszkedés
//"" ilyen felel meg => "-nek
//[^valami] kizárja azokat a karaktereket, mármint a szövegben nem lehetnek pl:""[^""]""-nem lehet " a "" között

var talalat = minta.Matches(text);
Console.WriteLine(talalat.Count);

Dictionary<string, int> stats = new Dictionary<string, int>();
foreach (Match elem in talalat)
{
    string matchValue = elem.Value;
    if (stats.ContainsKey(matchValue))
    {
        stats[matchValue]++;
    }
    else
    { 
        stats[matchValue] = 1; 
    }

}
foreach (var elem in stats)
{
    Console.WriteLine($"{elem.Key}, {elem.Value}");
}

