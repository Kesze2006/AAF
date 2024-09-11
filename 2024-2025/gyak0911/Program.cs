StreamReader olvas = new StreamReader("fajl.txt");
StreamWriter ir = new StreamWriter("jofajl.txt");
while (!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    if (line[0] == ' ')
    {
        ir.WriteLine(line.Remove(0,1));
    }
}
ir.Close();
olvas.Close();

static List<string> beolvas(string fajl)
{
    List<string> mondatok = new List<string>();
    StreamReader olvas = new StreamReader(fajl);
    while (!olvas.EndOfStream)
    {
        mondatok.Add(olvas.ReadLine());
    }
    olvas.Close();
    return mondatok;
}

static List<string> feladat(List<string> mondatok)
{
    List<string> joszavak = new List<string>();
    Random random = new Random();
    for (int i = 0; i < mondatok.Count; i++)
    {
        List<string> szavak = new List<string>();
        string sor = mondatok[i];
        szavak = sor.Split(" ").ToList();
        joszavak.Add(szavak[random.Next(0,szavak.Count-1)]);
    }

    return joszavak;
}

List<string> strings = feladat(beolvas("jofajl.txt"));
for (int i = 0; strings.Count > i; i++)
{
    Console.WriteLine(strings[i]);
}




