using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viragAgyas
{
    internal class adatok
    {
        public int kezd;
        public int veg;
        public string szin;
        public int sorSzam;

        public adatok(string sor)
        {
            string[] adatok = sor.Split(' ');
            kezd = int.Parse(adatok[0]);
            veg = int.Parse(adatok[1]);
            szin = adatok[2];
        }

        public bool kapuBentVan
        {
            get { return veg > kezd; }

        }
    }
}
