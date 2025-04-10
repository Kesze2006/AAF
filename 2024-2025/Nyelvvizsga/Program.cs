﻿using Nyelvvizsga;

List<Nyelvadat> sikeres = new List<Nyelvadat>();
List<Nyelvadat> sikertelenek = new List<Nyelvadat>();

static List<Nyelvadat> fajlBe(string fajlNev)
{
    List<Nyelvadat> adatok = new List<Nyelvadat>();
    StreamReader olvas= new StreamReader(fajlNev);
    string elsoSor = olvas.ReadLine();
    string[] vag = elsoSor.Split(";");
    int[] evek = new int[vag.Length-1];
    for (int i = 1; i < vag.Length; i++)
    {
        evek[i-1] = int.Parse(vag[i]);
    }
    while (!olvas.EndOfStream)
    {
        adatok.Add(new Nyelvadat(olvas.ReadLine(),evek));
    }
    olvas.Close();
    return adatok;
}
fajlBe("sikeres.csv");