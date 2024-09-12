static int feladat1(int min, int max)
{
    int szam = 0;

        while (true)
        {
        try
        {
            Console.Write("Kérek egy számot {0} és {1} között: ", Convert.ToString(min), Convert.ToString(max));
            szam = Convert.ToInt32(Console.ReadLine());
            if (szam >= min && szam <= max)
            {
                break;
            }
        }
        catch { }

        }

    
    return szam;
}

//int feladat1szam = feladat1(4,78);

static List<string> feladat2(int hossz , int dbszo)
{
    List<string> magan = ["a", "á", "e", "é", "i", "í", "o", "ó", "ö", "ő", "u", "ú", "ü", "ű"];
    List<string> massal = ["b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "r", "s", "t", "v", "z"];
    Random random = new Random();
    List<string> szavak = new List<string>();
    
    for (int j = 0; j < dbszo; j++)
    {
        string szo = "";
        if (random.Next(0, 2) == 1)
        {
            for (int i = 0; i < hossz; i++)
            {
                if (szo.Length % 2 == 0)
                {
                    szo += magan[random.Next(0, magan.Count)];
                }
                else
                {
                    szo += massal[random.Next(0, massal.Count)];
                }
            }
        }
        else
        {
            for (int i = 0; i < hossz; i++)
            {
                if (szo.Length % 2 == 0)
                {

                    szo += massal[random.Next(0, massal.Count)];
                }
                else
                {
                    szo += magan[random.Next(0, magan.Count)];
                }
            }
        }
        szavak.Add(szo);
    }
    return szavak;
}
List<string> szavak = feladat2(feladat1(5,12),200);

static void iras(List<string> szavak)
{
    StreamWriter iras = new StreamWriter("fajl.txt");
    for (int i = 0; i < szavak.Count; i++)
    {
        iras.WriteLine(szavak[i]);
    }
    iras.Close();
}
iras(szavak);