using System.Linq.Expressions;

Random szam =  new Random();
int fok = szam.Next(10, 40);
for (int k = 0; k < 7; k++)
{
    
    for (int i = 0; i < 24; i++)
    {
        int csok = szam.Next(0, 5);
        if (i <= 8 || i >= 20)
        {
            fok = fok - csok;
            if (fok < 10)
            {
                fok += csok;
            }

        }
        else
        {
            fok = fok + csok;
            if (fok >= 40)
            {
                fok -= csok;
            }
        }
        Console.WriteLine(fok);
        
    }
    Console.WriteLine("Nap vége");
}
