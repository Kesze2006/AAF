List<int> szamok = new List<int>();
Random r = new Random();
for (int i = 0; i < 500; i++)
{
    szamok.Add(r.Next(10000, 100000));
}
StreamWriter iro = new StreamWriter("szamok.csv");
for (int i = 0; i < szamok.Count; i++)
{
    iro.WriteLine(szamok[i]);
}
iro.Close();

int paros(List<int> szamLista)
{
    int db = 0;
    for (int i = 0; i < szamLista.Count; i++)
    {
        if (szamLista[i] % 2 == 0)
        {
            db++;
        }
    }
    return db;
}
paros(szamok);

int[] darabok=new int[10];
for (int i = 0; i < szamok.Count; i++)
{
    darabok[szamok[i]/10000]++;
    iro = new StreamWriter(szamok[i] / 10000 + ".csv",true);

    iro.WriteLine(szamok[i]);

    iro.Close();
}

List<string>[] szamLista = new List<string>[10];
for (int i = 0; i < szamLista.Length; i++)
{
    szamLista[i] = new List<string>();
}
for (int i = 0; i < szamok.Count; i++)
{
    szamLista[darabok[szamok[i] / 10000]].Add(szamok[i].ToString());
}





