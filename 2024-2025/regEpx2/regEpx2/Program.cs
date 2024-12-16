
using System.Linq.Expressions;
using System.Text.RegularExpressions;

string text = File.ReadAllText("generated_log_2024-12-11T11_21_39.997Z.txt");

Regex minta = new Regex(@"""([^""]+)""\s*$""", RegexOptions.Multiline);

//. bármi lehet
//* bármennyi számú karakter
//+ az adott karakter után ugyan olyan lesz
//$ utolsó illeszkedés
//^első illeszkedés
//"" ilyen felel meg => "-nek
//[^valami] kizárja azokat a karaktereket, mármint a szövegben nem lehetnek pl:""[^""]""-nem lehet " a "" között

var talalat = minta.Matches(text);
Console.WriteLine(talalat.Count);
foreach (Match elem in talalat)
{
    Console.WriteLine(elem);
}