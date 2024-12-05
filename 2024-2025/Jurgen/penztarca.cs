using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurgen
{
    internal class penztarca
    {
        public int penz;
        public int hitel;
        internal penztarca(int penz, int hitel)
        {
            this.penz = penz;
            this.hitel = hitel;
        }

        public static penztarca operator -(penztarca talca, int penzKi)
        {
            int ujPenz = Convert.ToInt32(talca.penz) - penzKi;
            return new penztarca(talca.penz = ujPenz,talca.hitel);
        }

        public static penztarca operator +(penztarca tarca, int penzBe)
        {
            int ujPenz = Convert.ToInt32(tarca.penz) + penzBe;
            return new penztarca(tarca.penz = ujPenz, tarca.hitel);
        }

        public static penztarca operator -(penztarca elso, penztarca masodik)
        {
            return new penztarca(elso.penz,elso.hitel - masodik.hitel); 
        }

        public static penztarca operator +(int penz, penztarca masodik)
        {
            return new penztarca(penz + masodik.penz, masodik.hitel);
        }
        public static penztarca operator +(penztarca elso, penztarca masodik)
        {
            return new penztarca(elso.penz + masodik.penz, masodik.hitel);
        }
        public static penztarca operator -(int penz, penztarca talca)
        {
            return new penztarca(penz - talca.penz, talca.hitel);
        }




        //kezpenz + pénztarca; pénztarca + kezpenz; pénztárca +pénztárca 
        public override string ToString()
        {
            return Convert.ToString(penz)+"euro és a hitel: "+Convert.ToString(hitel);
        }
    }
}
