using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tenyeszAllatok
{
    internal class farm
    {
        public List<allat> allatok = new List<allat>();
        public farm(){    }

        public farm(allat allatka)
        {
            allatok.Add(allatka);
        }

        public farm(farm a)
        {
            this.allatok.AddRange(a.allatok);
        }

        public static farm operator +(farm cs1, allat a1)
        {
            for (int i = 0; i < cs1.allatok.Count; i++)
            {
                if (cs1.allatok[i] == a1){ return new farm(cs1); }
            }
            cs1.allatok.Add(a1);
            return new farm(cs1);

        }
    }
}
