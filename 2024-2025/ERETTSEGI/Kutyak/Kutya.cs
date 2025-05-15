using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class Kutya
    {
        public int id;
        public int fajtaId;
        public int nevId;
        public int eletkor;
        public DateOnly datum;
        public KutyaFajat fajta;
        public KutyaNev nev;
        public Kutya(int id, int fajtaId, int nevId, int eletkor, DateOnly datum, KutyaFajat fajta, KutyaNev nev)
        {
            this.id = id;
            this.fajtaId = fajtaId;
            this.nevId = nevId;
            this.eletkor = eletkor;
            this.datum = datum;
            this.fajta = fajta;
            this.nev = nev;
        }
    }
}
