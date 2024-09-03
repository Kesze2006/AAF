/*
 * Kérj be szavakat szavak legyenek ezeket szavanként írjuk bele egy fájlba
*/
string betuk = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm-";
string beSzo = "a";
string gyujto = "";
while (beSzo != "")
{
    bool joSzo = true;
    Console.Write("Kérek egy szót: ");
    beSzo = Console.ReadLine();
    for (int i = 0; i < beSzo.Length; i++)
    {
        if (betuk.IndexOf(beSzo[i]) == -1)
        {
            joSzo = false;
            Console.WriteLine("Nem jó szó!");
            break;
        }
    }
    if (joSzo)
    {
        gyujto += beSzo+ " ";

    }
}

string[] darabok = gyujto.Trim().Split(" ");
StreamWriter ir = new StreamWriter("szavak.txt"); 
for (int i = 0; i < darabok.Length; i++)
{
    ir.WriteLine(darabok[i]);
}
ir.Close();
File.WriteAllLines("szavak2.txt", darabok);