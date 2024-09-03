using System.Reflection;

StreamReader olvas = new StreamReader("adathalmaz.csv");
olvas.ReadLine();

List<int> perc = new List<int>();
List<double> homero1 = new List<double>();
List<double> homero2 = new List<double>();
List<double> homero3 = new List<double>();
List<double> homero4 = new List<double>();
List<int> darab = new List<int>();
while (!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    string[] adat = new string[6];
    adat = line.Split(";");
    perc.Add(Convert.ToInt32(adat[0]));
    homero1.Add(Convert.ToDouble(adat[1]));
    homero2.Add(Convert.ToDouble(adat[2]));
    homero3.Add(Convert.ToDouble(adat[3]));
    homero4.Add(Convert.ToDouble(adat[4]));
    darab.Add(Convert.ToInt32(adat[5]));

}
olvas.Close();
//2
int idopontok = perc.Count();
Console.WriteLine("2.feladat: {0} időpont adatai szerepelnek az adatok között.", idopontok);
Console.WriteLine();
//3
int atlag = darab[darab.Count-1]/24;
Console.WriteLine("3.feladat: A napi óránkénti átlag termelés {0} volt.",atlag);
Console.WriteLine();
//4
double ho1 = homero1.Min();
double ho2 = homero2.Min();
double ho3 = homero3.Min();
double ho4 = homero4.Min();
Console.WriteLine("4.feladat: Az első fázisban a legkissebb hőmérséklet {0} volt a második fázisban {1} volt a harmadikban {2} volt és a negyedikben {3} volt.", homero1.Min() ,homero2.Min() ,homero3.Min() ,homero4.Min());
Console.WriteLine();
//5
double max = homero1.Max();
int index = homero1.IndexOf(max);
Console.WriteLine("5.feladat: Az 1 es fázisnál {0}˙C volt a legmagasabb hőmérséklet {1} perckor.",max, perc[index]);
Console.WriteLine();
//6
/*
int darabok = 0;
int index2 = 0;
for (int i = 0; i < darab.Count(); i++)
{
    int db = 0;
    if (i > 0 && i < darab.Count() - 1)
    {
        db = darab[i]-darab[i-1];
        if (db > darabok)
        {
            darabok = db;
            index2 = i;
        }
    }
}
int  = 
Console.WriteLine(ora1);
*/
//7
Console.WriteLine("7.feladat: Az első fázis átlagos hőmérséklete {0:0.00} a másodiké {1:0.00} a harmadiké {2:0.00} a negyediké pedig {3:0.00}", homero1.Sum() / homero1.Count(), homero2.Sum() / homero2.Count(), homero3.Sum() / homero3.Count(), homero4.Sum() / homero4.Count());
Console.WriteLine();
//8
StreamWriter ir = new StreamWriter("termeles.csv");
int[] indexek = new int[24];
int j = 0;
for (int i = 0; i < perc.Count(); i++)
{ 
    if (perc[i] % 60 == 0)
    {
        indexek[j] = i;
        j++;
    }
}
j = 0;
double[] valamik = new double[24];
for (int i = 0; i < indexek.Length; i++)
{
    List<double> valami = new List<double>();
    valami.Add(homero1[indexek[i]]);
    valami.Add(homero2[indexek[i]]);
    valami.Add(homero3[indexek[i]]);
    valami.Add(homero4[indexek[i]]);
    valamik[j] = valami.Max();
}


ir.WriteLine("1;2333;");
for (int i = 1; i < indexek.Length-1; i++)
{
    ir.WriteLine(Convert.ToString((perc[indexek[i]] / 60))+";"+Convert.ToString(darab[indexek[i + 1]] - darab[indexek[i]]) + ";");
}
ir.WriteLine("24;2438;");
ir.Close();