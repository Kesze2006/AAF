
using fejvagyiras;

List<adatok> dobasok = new List<adatok>();

StreamReader olvas = new StreamReader("kiserlet.txt");
while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    if (dobasok[-1].dobas == sor)
    {
        dobasok[dobasok.Count - 1].db++;
    }
}
olvas.Close();