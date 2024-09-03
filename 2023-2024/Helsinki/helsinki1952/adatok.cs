using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki1952
{
    internal class adatok
    {

        public int helyezes;
        public int fo;
        public string sportag;
        public string versenySzam;

        public adatok(string sor)
        {
            string[] vag = sor.Split(" ");
            helyezes = int.Parse(vag[0]);
            fo = int.Parse(vag[1]);
            sportag = vag[2];
            versenySzam = vag[3];
        }



    }
}
