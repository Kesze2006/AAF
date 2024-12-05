
using Jurgen;

penztarca jurgenTalca = new penztarca(10000,15000000);
int hansi = 4550;
penztarca faruValaki = new penztarca(10000, 15);
penztarca lakodalmasCucc = new penztarca(10000, 0);
int lakodalomPenz = 5000;
penztarca komuves = new penztarca(150, 0);
int kezpenzKomuves = 450;
penztarca adossag = new penztarca(1500, 0);
int adossagPenz = 1500000000;

Console.Write("Kezdeti tálca: ");
Console.WriteLine(jurgenTalca);



Console.WriteLine(jurgenTalca - hansi);
Console.WriteLine(jurgenTalca - faruValaki);
Console.WriteLine(jurgenTalca + kezpenzKomuves);
Console.WriteLine(jurgenTalca + komuves);
Console.WriteLine(lakodalomPenz + lakodalmasCucc);
Console.WriteLine(adossagPenz - adossag);



