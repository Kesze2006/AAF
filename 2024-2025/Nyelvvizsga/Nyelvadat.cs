using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    internal class Nyelvadat
    {
        public string nyelv;
        public List<Evadat> vizsgak;
        public Nyelvadat(string sor, int[] evSzamok) 
        {
            string[] vag = sor.Split(";");
            nyelv = vag[0];
            this(Nyelvadat)
        }
        public Nyelvadat(string nyelv, int[] adatok, int[] evSzamok)
        {
            this.nyelv = nyelv;
            for (int i = 0; i < adatok.Length; i++)
            {
                this.vizsgak.Add(new Evadat(evSzamok[i],adatok[i]));
            }
        }
    }
}
