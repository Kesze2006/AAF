using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objEk
{
    internal class objdef
    {
        public string nev;
        public int suly;

        public objdef(string nev, int suly)
        {
            this.nev = nev;
            this.suly = suly;
        }
        public objdef(string nev) { this.nev = nev;
            suly = 0;
        }

        public objdef()
        {
            nev = "";
            suly = 0;
        }
        public static objdef operator +(objdef a,objdef b)
        {
            return new objdef(a.nev+b.nev);
        }

        public override string ToString()
        {
            return nev;
        }
    }
}
