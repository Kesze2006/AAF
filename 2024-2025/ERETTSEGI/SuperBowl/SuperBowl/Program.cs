
using SuperBowl;

StreamReader olvas = new StreamReader("SuperBowl.txt");

olvas.ReadLine();
int sorszam = 0;
while (!olvas.EndOfStream && sorszam <= 100)
{
    sorszam++;
    string line = olvas.ReadLine();
    string[] adatok = line.Split(";");
}