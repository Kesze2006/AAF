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






