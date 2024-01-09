using oop2;

ember e1 = new ember("Szakács", "Árpád");

Console.WriteLine(e1.teljesNev);

ember e2 = new ember("Nagy", "Árpi");

Console.WriteLine(e2.teljesNev);

udvariasEmber ue1 = new udvariasEmber("Horváth", "Húgó");

Console.WriteLine(ue1.teljesNev);

ue1.koszonNevvel(e1);
ue1.koszones(e1);

diak d1 = new diak("Tálas","Miklós",12);
diak d2 = new diak("Verbulecc", "Bálint", 19);


d1.iskola();
d2.iskola();

d1.koszonNevvel(ue1);

d1.koszon(d2);