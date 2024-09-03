List<int> percek = new List<int>();
List<double> ho1 = new List<double>();
List<double> ho2 = new List<double>();
List<double> ho3 = new List<double>();
List<double> ho4 = new List<double>();
List<int> darab = new List<int>();
void betolt()
{
    StreamReader olvas = new StreamReader("adathalmaz.csv");
    olvas.ReadLine();

    string[] adat = new string[6]; 
    while (!olvas.EndOfStream)
    {
        string sor = olvas.ReadLine();
        adat = sor.Split(";");
        percek.Add(Convert.ToInt32(adat[0]));
        ho1.Add(Convert.ToDouble(adat[1]));
        ho2.Add(Convert.ToDouble(adat[2]));
        ho3.Add(Convert.ToDouble(adat[3]));
        ho4.Add(Convert.ToDouble(adat[4]));
        darab.Add(Convert.ToInt32(adat[5]));
    }
    olvas.Close();
}
void betolt2()
{
    string[] sorok = File.ReadAllLines("adathalmaz.csv");

    for (int i = 1; i < sorok.Length; i++)
    {
        string[] adat = sorok[i].Split(";");
        percek.Add(Convert.ToInt32(adat[0]));
        ho1.Add(Convert.ToDouble(adat[1]));
        ho2.Add(Convert.ToDouble(adat[2]));
        ho3.Add(Convert.ToDouble(adat[3]));
        ho4.Add(Convert.ToDouble(adat[4]));
        darab.Add(Convert.ToInt32(adat[5]));
    }
}
void betolt3()
{
    string[] sorok = File.ReadAllLines("adathalmaz.csv").ToList().Skip(1).ToArray();

    foreach(string sor in sorok)
    {
        string[] adat = sor.Split(";");
        percek.Add(Convert.ToInt32(adat[0]));
        ho1.Add(Convert.ToDouble(adat[1]));
        ho2.Add(Convert.ToDouble(adat[2]));
        ho3.Add(Convert.ToDouble(adat[3]));
        ho4.Add(Convert.ToDouble(adat[4]));
        darab.Add(Convert.ToInt32(adat[5]));
    }
}

betolt3();
Console.WriteLine("2. feladat\n Ennyi adatsor van {0}.",darab.Count);

Console.WriteLine("3. feladat\n Átlagos napi termelés {0} db/óra.", darab[darab.Count - 1] / 24);

Console.WriteLine("4. feladat\n Min1 {0}\n Min2 {1}\n Min3 {2}\n Min4 {3}",ho1.Min(),ho2.Min(),ho3.Min(),ho4.Min());

double maximum = 0;
int maxIndex = 0;
for (int i = 0; i < ho1.Count; i++)
{
    if (ho1[i] > maximum)
    {
        maximum = ho1[i];
        maxIndex= i;
    }
}

Console.WriteLine("5. feladat\n {0} fok, {1} perc", maximum, percek[maxIndex]);

List<int> darab5perc = new List<int>();
darab5perc.Add(darab[0]);
for (int i = 0; i < darab.Count - 1; i++)
{
    
}