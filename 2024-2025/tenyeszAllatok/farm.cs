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
            List<allat> temp = new List<allat>(cs1.allatok);

            if (!temp.Contains(a1))
            {
                temp.Add(a1);
            }

            farm tempCsorda = new farm();
            tempCsorda.allatok = temp;

            return new farm(tempCsorda);
        }

        public static farm operator -(farm cs1, allat a1)
        {
            List<allat> temp = new List<allat>(cs1.allatok);
            
            temp.Remove(a1);

            farm tempCsorda = new farm();
            tempCsorda.allatok = temp;

            return new farm(tempCsorda);
        }










        public void kiir()
        {
            for (int i = 0; i < allatok.Count; i++)
            {
                Console.WriteLine(allatok[i]);
            }
        }

    }
}
