// 1. Fájl beolvasása
using System.Text.RegularExpressions;

string text = File.ReadAllText("generated_log_2024-12-11T11_21_39.997Z.txt");

// 2. Regex minta
Regex minta = new Regex(@"""(\w+) (\S+ \S+)"" (\d+ \d+)");

// 3. Találatok összegyűjtése
var talalat = minta.Matches(text);
Console.WriteLine($"Total Matches: {talalat.Count}");

// 4. Dictionary létrehozása a számláláshoz
Dictionary<string, int> stats = new Dictionary<string, int>();

// 5. Találatok számlálása
foreach (Match elem in talalat)
{
    string matchValue = elem.Groups[1].Value; // Regex találat szövegew

    // Ellenőrizzük, hogy szerepel-e már a Dictionary-ben
    if (stats.ContainsKey(matchValue))
    {
        stats[matchValue]++; // Növeljük az előfordulások számát
    }
    else
    {
        stats[matchValue] = 1; // Első előfordulás esetén értéke 1 lesz
    }
}

// 6. Találatok és duplikátumok kiíratása
Console.WriteLine("\nTalálatok előfordulásai:");
foreach (var elem in stats)
{
    Console.WriteLine($"\"{elem.Key}\": {elem.Value} times");
}