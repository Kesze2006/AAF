using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    internal class olvas
    {
        public int ora;
        public int perc;
        public int azonosito;
        public string irany;

        public olvas(string sor)
        {
            string[] adatok = sor.Split(" ");
            ora = Convert.ToInt32(adatok[0]);
            perc = Convert.ToInt32(adatok[1]);
            azonosito = Convert.ToInt32(adatok[2]);
            irany = adatok[3];

        }
    }
}
