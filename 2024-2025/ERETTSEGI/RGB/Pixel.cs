using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    internal class Pixel
    {
        public int x, y;
        public Szin rgb;

        public Pixel(int x, int y, Szin rgb)
        {
            this.x = x;
            this.y = y;
            this.rgb = rgb;
        }
        static bool randomFugvenyMertNemTudokMarFigyelni(int sor, int elteres)
        {
            //az aktuális elem rgb tulajdonságának a b érétke és a következő elem rgb b értéke között a különbség nagyobb e mint az eltérés
            return true;
        }
    }
}
