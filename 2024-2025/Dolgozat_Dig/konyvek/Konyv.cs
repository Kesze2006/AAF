using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    internal class Konyv
    {
        public int ev;
        public int negyedEv;
        public string eredet;
        public string leiras;
        public int peldanySzam;


        public Konyv(int ev, int negyedEv, string eredet, string leiras, int peladnySzam)
        {
            this.ev = ev;
            this.negyedEv = negyedEv;

            this.leiras = leiras;
            this.eredet = eredet;
            this.peldanySzam = peladnySzam;
        }
    }
}
