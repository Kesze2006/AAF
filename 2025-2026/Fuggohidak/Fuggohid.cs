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
