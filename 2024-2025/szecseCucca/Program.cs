StreamReader olvas = new StreamReader("szazalek.txt");

List<int> szazalekok = new List<int>();

while (!olvas.EndOfStream)
{
    szazalekok.Add(Convert.ToInt32(olvas.ReadLine()));
}

static Dictionary<int,int> jegy(List<int> lista)
{
    Dictionary<int,int> valami = new Dictionary<int,int>();

    for (int i = 0; i < lista.Count; i++)
    {
        if (lista[i] <= 39) { jegy = 1; }
        else if (lista[i] >= 40 || lista[i] <= 54) { jegy = 2; }
        else if (lista[i] >= 55 || lista[i] <= 69) { jegy = 3; }
        else if (lista[i] >= 70 || lista[i] <= 84) { jegy = 4; }
        else { jegy = 5; }
    }

    return valami;
}

