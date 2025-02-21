using tanciskola;

List<tanc> tancok = new List<tanc>();
StreamReader olvas= new StreamReader("tancrend.txt");

int k = 0;
List<string> temp = new List<string>();
while (!olvas.EndOfStream)
{
    
    k++;
    string line = olvas.ReadLine();
    temp.Add(line);
    if (k % 3 == 0)
    {
        tancok.Add(new tanc(temp[0], temp[1], temp[2]));
        temp.Clear();
    }
}
olvas.Close();


//2.feladat
Console.WriteLine("2.feladat");
var elso = tancok.First().tancNeve;
var utolso = tancok.Last().tancNeve;
Console.WriteLine($"Az első bemutatott tánc a(z) {elso} volt az utólsó pedig a(z) {utolso}.");
Console.WriteLine("----");


//3.feladat
Console.WriteLine("3.feladat");
var tanoltSamba = tancok.Where(tanc => tanc.tancNeve == "samba").ToList().Count;
Console.WriteLine($"Sambát {tanoltSamba} pár táncolt.");
Console.WriteLine("----");


//4.feladat
Console.WriteLine("4.feladat");
var vilmaTancai = tancok.Where(tanc => tanc.lanyNeve == "Vilma").Select(tanc=> tanc.tancNeve).ToList();
Console.WriteLine($"Vilam a következő táncokban táncolt: {String.Join(", ",vilmaTancai)} ");
Console.WriteLine("----");


//5.feladat
Console.WriteLine("5.feladat");
Console.Write("Adja meg a tánc nevét: ");
string bekertTanc = Console.ReadLine();
var vilmaParja = tancok.Where(tanc => tanc.lanyNeve == "Vilma" && tanc.tancNeve == bekertTanc).Select(tanc => tanc.fiuNeve).ToList();
if (vilmaParja.Count > 0)
{
    Console.WriteLine($"A {bekertTanc} bemutatóján Vilma párja {String.Join(" ",vilmaParja)} volt.");
}
else
{
    Console.WriteLine($"Vilma nem táncolt {bekertTanc}-t");
}
Console.WriteLine("----");


//6.feladat
//Console.WriteLine("6.feladat");
var lanyok = tancok.Select(tanc=> tanc.lanyNeve).ToHashSet();
var fiuk = tancok.Select(tanc => tanc.fiuNeve).ToHashSet();
StreamWriter ir = new StreamWriter("szereplok.txt");
ir.WriteLine("Lányok: "+String.Join(", ", lanyok));
ir.WriteLine("Fiúk: " + String.Join(", ", fiuk));
ir.Close();


//7.feladat
Console.WriteLine("7.feladat");
var lanyokCsoport = tancok.GroupBy(tanc => tanc.lanyNeve).Select(tanc=> new {lanyNeve = tanc.Key, darab = tanc.Count()});
int max = lanyokCsoport.Select(x => x.darab).Max();
var lanyLegtobb = lanyokCsoport.Where(x=> x.darab == max).Select(x=>x.lanyNeve);

var fiuCsoport = tancok.GroupBy(tanc => tanc.fiuNeve).Select(tanc => new { fiuNeve = tanc.Key, darab = tanc.Count() });
int max2 = fiuCsoport.Select(x => x.darab).Max();
var fiuLegtobb = fiuCsoport.Where(x => x.darab == max2).Select(x => x.fiuNeve);

Console.WriteLine($"A legöbbet táncoló lányok: {String.Join(", ", lanyLegtobb)}");
Console.WriteLine($"A legöbbet táncoló fiúk: {String.Join(", ", fiuLegtobb)}");
Console.WriteLine("----");