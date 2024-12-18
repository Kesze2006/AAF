﻿namespace gyak241014
{
    internal class JatekosLovese
    {
        public List<string> nevek = new List<string>();
        public List<double> xkordi = new List<double>();
        public List<double> ykordi = new List<double>();
        public List<int> sorszam = new List<int>();
        public JatekosLovese()
        {
            StreamReader olvas = new StreamReader("lovesek.txt");
            int i = 0;
            while (!olvas.EndOfStream)
            {
                i++;
                string line = olvas.ReadLine();
                nevek.Add(line.Split(";")[0]);
                xkordi.Add(Convert.ToDouble(line.Split(";")[1]));
                ykordi.Add(Convert.ToDouble(line.Split(";")[2]));
                sorszam.Add(i);
            }
        }
    }
}
