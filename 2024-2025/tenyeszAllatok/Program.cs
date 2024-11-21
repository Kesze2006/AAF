using tenyeszAllatok;

allat tehen = new allat("Tehén", 12,5000);

farm csoport1 = new farm();
farm csoport2 = new farm(tehen);
farm csoport3 = new farm(csoport2);
Console.WriteLine(csoport2.allatok.Count);

farm csoport4= csoport2 + tehen;

Console.WriteLine(csoport4.allatok.Count);