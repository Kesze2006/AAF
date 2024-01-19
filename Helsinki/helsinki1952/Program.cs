using helsinki1952;

List<adatok> eredemenyek = new List<adatok>();

StreamReader olvas = new StreamReader("helsinki.txt");
while (!olvas.EndOfStream)
{
    string sor= olvas.ReadLine();
    eredemenyek.Add(new adatok(sor));
}
olvas.Close();

//3.feladat
Console.WriteLine("3.feladat");
Console.WriteLine("Valami ami {0} ",eredemenyek.Count());

//4.feladat
Console.WriteLine("4.feladat");
int[] ermekSzama = new int[7];

for (int i = 0; i < eredemenyek.Count(); i++)
{
    ermekSzama[eredemenyek[i].helyezes]++;
}
Console.WriteLine("Arany: {0}", ermekSzama[1]);
Console.WriteLine("Ezüst: {0}", ermekSzama[2]);
Console.WriteLine("Bronz: {0}", ermekSzama[3]);

Console.WriteLine(ermekSzama[1] + ermekSzama[2] + ermekSzama[3] + ermekSzama[4] + ermekSzama[5] + ermekSzama[6]);