using viragAgyas;

List<adatok> viragok =  new List<adatok>();

string[] sorok = File.ReadAllLines("felajanlas.txt");
int agyasDB = int.Parse(sorok[0]);
for (int i = 1; i < sorok.Length; i++)
{
    viragok.Add(new adatok(sorok[i]));
}