using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak241009
{
    interface Ihajo
    {
        void megfordul();
        void mozgas();
        void duda();
        void sullyed();
    }
    class Hajo : Ihajo
    {
        public void megfordul()
        {
            Console.WriteLine("A hajó forog");
        }
        public void mozgas()
        {
            
        }
        public void duda()
        {
            
        }
        public void sullyed()
        {
            
        }
        public int hossz = 15;
        public string nev = "SSBix";
        public int vizkiszoritas = 50;
    }

    class Vitorlas : Hajo
    {
        public string nev = "vitorlas";
    }

    class Csonak : Hajo
    {
        
    }
}
