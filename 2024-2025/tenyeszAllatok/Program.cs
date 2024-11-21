using tenyeszAllatok;

allat tehen = new allat("Tehén", 12,5000);
allat kutya = new allat("Vizsla", 14, 150000);
allat tyuk = new allat("Kakas", 6.5, 1400);

farm csoport1 = new farm();
farm csoport2 = new farm(tehen);
farm csoport3 = new farm(csoport2);
Console.WriteLine(csoport2.allatok.Count);

farm csoport4 = csoport2 + kutya;

csoport4 = csoport4 + tyuk;


//Console.WriteLine(csoport4.allatok.Count);
csoport4.kiir();
Console.WriteLine();
csoport4 = csoport4 - kutya;
csoport4.kiir();



