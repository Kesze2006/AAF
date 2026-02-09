using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    internal class konyv
    {
        public int kiadasEv;
        public int kiadasNegyedEv;
        public string eredet;
        public string leiras;
        public int peldanyszam;

        public konyv(int kiadasEv, int kiadasNegyedEv, string eredet, string leiras, int peldanyszam)
        {
            this.kiadasEv = kiadasEv;
            this.eredet = eredet;
            this.leiras = leiras;
            this.kiadasNegyedEv = kiadasNegyedEv;
            this.peldanyszam = peldanyszam;
        }

    }
}
