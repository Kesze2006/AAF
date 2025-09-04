using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalapacsvetes
{
    internal class Sportolo
    {
        public int helyezes;
        public double eredmeny;
        public string nev;
        public string orszagKod;
        public string helyszin;
        public DateOnly datum;

        public Sportolo(int helyezes,double eredmeny,string nev, string orszagKod, string helyszin, DateOnly datum)
        {
            this.helyezes = helyezes;
            this.nev = nev;
            this.eredmeny = eredmeny;
            this.orszagKod = orszagKod;
            this.helyszin = helyszin;
            this.datum = datum;
        }
    }
}
