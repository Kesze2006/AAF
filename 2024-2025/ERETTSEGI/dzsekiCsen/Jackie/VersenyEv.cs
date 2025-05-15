using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackie
{
    internal class VersenyEv
    {
        public int ev;
        public int versenyDarab;
        public int nyert;
        public int dobogos;
        public int pole;
        public int legyorsabbKorokSzama;
        public int evtized;
        public VersenyEv(int ev, int versenyDarab, int nyert, int dobogos, int pole, int legyorsabbKorokSzama)
        {
            this.ev = ev;
            this.dobogos = dobogos;
            this.nyert = nyert;
            this.dobogos = pole;
            this.pole = pole;
            this.legyorsabbKorokSzama = legyorsabbKorokSzama;
            evtized = (this.ev - 1900) / 10;
            evtized *= 10;
        }

        
    }
}
