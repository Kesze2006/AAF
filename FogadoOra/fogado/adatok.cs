using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace fogado
{
    internal class adatok
    {
        public string nev;
        public string idopont;
        public DateTime foglalas;

        public adatok(string sor)
        {

            string[] adatok = sor.Split(" ");
            nev = adatok[0]+" "+adatok[1];
            idopont = adatok[2];
            foglalas = Convert.ToDateTime(adatok[3].Replace("-", " "));
        }

        public override string ToString()
        {
            return String.Format("Tanár neve: {0}\r\nFoglalt időpont: {1}\r\nFoglalás ideje: {2}",nev,idopont,foglalas);
        }

    }
}
