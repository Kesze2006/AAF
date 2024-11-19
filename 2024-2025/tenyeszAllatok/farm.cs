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
        List<allat> tagok;

        public farm()
        {
            this.tagok = tagok ??  new List<allat>(tagok);
        }

        public static farm operator +(farm farm,allat a)
        {
            farm.tagok.Add(a);
            return farm;
        }
    }
}
