using operatorredef;

Pont p1 = new Pont(1, 1);
Pont p2 = new Pont(2, 3);
Console.WriteLine(p1 + p2);
Console.WriteLine(p1 + 10);
Console.WriteLine(10 + p2);

Console.WriteLine(p1 - p2);
Console.WriteLine(p1 - 10);
Console.WriteLine(10 - p2);

Console.WriteLine(p1 * p2);
Console.WriteLine(p1 * 10);
Console.WriteLine(10 * p2);

Console.WriteLine(p1 / p2);
Console.WriteLine(p1 / 10);
Console.WriteLine(10 / p2);

Console.WriteLine(p2++);
Console.WriteLine(++p2);

Console.WriteLine(p2--);
Console.WriteLine(--p2);


Console.WriteLine(p1.Equals(new Pont(1,1)));
Console.WriteLine(p1!=p2);
Console.WriteLine(p1 == new Pont(1,1));
Console.WriteLine(p1.Equals(null));