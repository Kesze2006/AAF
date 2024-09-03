using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class udvariasEmber:ember
    {

        public udvariasEmber(string vNev, string kNev):base(vNev, kNev)
        {
            
        }
        public void koszones()
        {
            Console.WriteLine("Szia Uram!");
        }

        public void koszones(ember e)
        {
            Console.WriteLine("Szia {0} Uram!",e.teljesNev);
        }


        public void koszonNevvel(ember e)
        {
            Console.WriteLine("Szia {0} Uram {1} vagyok!", teljesNev,e.keresztNev);
        }
    }
}
