using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoapp
{
    internal class Auto
    {
        public int sorszam;
        public string marka;
        public string modell;
        public int gyartasiEv;
        public string szin;
        public int eladottDB;
        public int atlagosEladasiAr;

        //3.feladat
        public Auto(string[] sor)
        {

                this.sorszam = int.Parse(sor[0]);
                this.marka = sor[1];
                this.modell = sor[2];
                this.gyartasiEv = int.Parse(sor[3]);
                this.szin = sor[4];
                this.eladottDB = int.Parse(sor[5]);
                this.atlagosEladasiAr = int.Parse(sor[6]);
        }

        //4.feladat
        public static List<Auto> Vag()
        {
            var list = new List<Auto>();
            StreamReader olvas = new StreamReader("autok.csv");
            olvas.ReadLine();
            while (!olvas.EndOfStream)
            {
                string line = olvas.ReadLine();
                string[] sor = line.Split(";");
                list.Add(new Auto(sor));
            }
            return list;
        }
    }
}
