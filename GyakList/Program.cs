List<int> szamok = new List<int>();

Random rand = new Random();

int darab = rand.Next(10000,100000);

for (int i = 0; i < darab; i++) 
{
    szamok.Add(rand.Next(10,100));
}

Console.WriteLine("{0} szám van benne",szamok.Count);

Dictionary<int,int> stat = new Dictionary<int,int>();

for (int i = 0; i < szamok.Count; i++)
{
    
}
