using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggohidak
{
    internal class Fuggohid
    {
        public int helyezes;
        public string hidNeve;
        public string foldrajziHely;
        public string orszag;
        public int hossza;
        public int atadasEve;
        public Fuggohid(string[] sor)
        {
            this.helyezes = int.Parse(sor[0]);
            this.hidNeve = sor[1];
            this.foldrajziHely = sor[2];
            this.orszag = sor[3];
            this.hossza = int.Parse(sor[4]);
            this.atadasEve = int.Parse(sor[5]);
        }

        public static List<Fuggohid> Olvas()
        {
            List<Fuggohid> list = new List<Fuggohid>();
            StreamReader olvaso = new StreamReader("fuggohidak.csv");
            olvaso.ReadLine();
            while (!olvaso.EndOfStream)
            {
                string line = olvaso.ReadLine();
                string[] sor = line.Split("\t");
                list.Add(new Fuggohid(sor));
            }
            return list;
        }
    }
}
