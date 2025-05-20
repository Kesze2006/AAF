using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    internal class Fordito
    {
        public string szerzo;
        public string idezet;

        public Fordito(string szerzo, string idezet)
        {
            this.szerzo = szerzo;
            this.idezet = idezet;
        }

        public string Morze2Szöveg(string morzeKod,Kodolas betuk)
        {
            string[] vag = morzeKod.Split("   ");
            string[] rendesSzoveg = new string[vag.Length];
            for (int i = 0; i < vag.Length; i++)
            {
                
            }
        }
    }
}
