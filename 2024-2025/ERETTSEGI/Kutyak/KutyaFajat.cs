using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class KutyaFajat
    {
        public int id;
        public string nev;
        public string eredetiNev;

        public KutyaFajat(int id, string nev, string erederiNev)
        {
            this.id = id;
            this.nev = nev;
            this.eredetiNev = erederiNev;
        }
    }
}
