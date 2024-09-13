using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak0913
{
    internal class kutya
    {
        public string nev;

        public void ugat()
        {
            Console.WriteLine("wauawuauwauwuauwuauwauwua");
        }

        private float _suly;
        public float suly
        {
            
            get
            {
                return _suly;
            }
            set
            {
                _suly = Math.Abs(value);
            }
        }

        public kutya(string nev)
        {
            Console.WriteLine("kész a kutya");
            this.nev = nev;

        }

        public override string ToString()
        {
            return "Kutya vagy!";
        }

        public static string ezMiEz()
        {
            return "Ez egy kutya ";
        }
    }
}
