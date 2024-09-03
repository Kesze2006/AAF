using OOPGyak;

namespace oop
{
    class auto
    {
        public int kerekSzam = 4;
        void dudal()
        {
            Console.WriteLine("tüüüüüüüüüüüüütü");
        }
        private string _tulaj;
        public string tulajdonos
        {
            get
            {
                return _tulaj;
            }
            set
            {
                if (value == "Bence")
                {
                    Console.WriteLine("Nope!");
                }
                else
                {
                    _tulaj = value;
                }
                
            }
        }
    }

    internal class Progarm
    {

        static void Main()
        {
            auto kocsi = new auto();
            Console.WriteLine(kocsi.kerekSzam);
            kocsi.tulajdonos = "Gabi";
            Console.WriteLine(kocsi.tulajdonos);

            Laci laci = new Laci();
            laci.sug();
        }
    }
}