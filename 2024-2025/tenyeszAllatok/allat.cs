using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenyeszAllatok
{
    internal class allat
    {
        string nev;
        double suly;
        int ar;

        public allat(string nev, double suly, int ar)
        {
            this.nev = nev;
            this.suly = suly;
            this.ar = ar;
        }

        public override string ToString()
        {
            return $"{nev} {suly}kg {ar}FT";
        }
    }
}
