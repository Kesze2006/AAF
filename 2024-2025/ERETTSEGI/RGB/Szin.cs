﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    internal class Szin
    {
        public byte r;
        public byte g;
        public byte b;

        public Szin(int red, int green, int blue)
        {
            r = (byte)red;
            g = (byte)green;
            b = (byte)blue;
        }
        public override string ToString()
        {
            return $"RGB({r},{g},{b})";
        }

        public int osszge()
        {
            return r + b + g;
        }

        public bool vilagos()
        {
            return r + b + g > 600;
        }
    }
}
