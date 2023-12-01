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
    string[] sorok = File.ReadAllLines("adathalmaz.csv");

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
