using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace fejvagyiras
{
    internal class adatok
    {
        public string dobas;
        public int db;
        public adatok(string dobas)
        {
            this.dobas = dobas;
            db = 1;
        }
    }
}
