using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace latinTancok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Par> tancok = new List<Par>();

        private void Ablak_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader olvas = new StreamReader("tancrend.txt");

            while (!olvas.EndOfStream)
            {
                string[] sorok = new string[3];
                for (int i = 0; i < sorok.Length; i++)
                {
                    sorok[i] = olvas.ReadLine();
                }
                tancok.Add(new Par(sorok[0], sorok[1], sorok[2]));

            }
            olvas.Close();

            List<string> tancNevek = new List<string>();

            for (int i = 0; i < tancok.Count; i++)
            {
                if (!tancNevek.Contains(tancok[i].tanc))
                {
                    tancNevek.Add(tancok[i].tanc);
                }
            }
            listbox.ItemsSource = tancNevek;
            listbox2.ItemsSource = tancNevek;
        }

        private void Gomb_Click(object sender, RoutedEventArgs e)
        {
            string szoveg = "Első tánc: " + tancok[0].tanc + " az utolsó tánc: " + tancok[tancok.Count-1].tanc;
            textblock.Text = szoveg;
        }

        private void gomb2_Click(object sender, RoutedEventArgs e)
        {
            textblock2.Text = "A sambat "+ tancSzamol("samba")+" pár táncolta!";
        }
        private int tancSzamol(string tancnev)
        {
            int db = 0;
            for (int i = 0; i < tancok.Count; i++)
            {
                if (tancok[i].tanc == tancnev)
                {
                    db++;
                }
            }
            return db;
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            valami.Content = tancSzamol(lb.SelectedItem.ToString());
        }

        private void listbox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            string partner = "Ilyet nem táncolt";
            for (int i = 0; i < tancok.Count; i++)
            {
                if (tancok[i].lany == "Vilma")
                {
                    if (tancok[i].tanc == lb.SelectedItem.ToString())
                    {
                        partner = tancok[i].fiu;
                    }
                }
            }
            valamivil.Content = partner;
        }

        private void _6gomb_Click(object sender, RoutedEventArgs e)
        {
            HashSet<string> lanyok = new HashSet<string>();
            HashSet<string> fiuk = new HashSet<string>();

            for (int i = 0; i < tancok.Count; i++)
            {
                lanyok.Add(tancok[i].lany);
                fiuk.Add(tancok[i].fiu);
            }

            StreamWriter ir = new StreamWriter("szereplok.txt");
            ir.WriteLine("Lányok: {0}",string.Join(", ",lanyok));
            ir.WriteLine("Fiúk: " + string.Join(", ",fiuk));
            ir.Close();

            StreamWriter ir2 = new StreamWriter("valmiXaml.xml");
            ir2.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            ir2.WriteLine("<tancosok>");
            ir2.WriteLine("\t<fiuk>");
            ir2.WriteLine("\t\t<nev>{0}</nev>", string.Join("</nev>\n\t\t<nev>",fiuk));
            ir2.WriteLine("\t</fiuk>");
            ir2.WriteLine("\t<lányok>");
            ir2.WriteLine("\t\t<nev>{0}</nev>", string.Join("</nev>\n\t\t<nev>", lanyok));
            ir2.WriteLine("\t</lányok>");
            ir2.WriteLine("</tancosok>");
            ir2.Close();
        }

        private void _7gomb_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string,int> statFiuk = new Dictionary<string,int>();
            Dictionary<string, int> statLanyok = new Dictionary<string, int>();

            for (int i = 0; i < tancok.Count; i++)
            {
                if (statFiuk.ContainsKey(tancok[i].fiu))
                {
                    statFiuk[tancok[i].fiu]++;
                }
                else
                {
                    statFiuk.Add(tancok[i].fiu, 1);
                }
                if (statFiuk.ContainsKey(tancok[i].lany))
                {
                    statFiuk[tancok[i].lany]++;
                }
                else
                {
                    statFiuk.Add(tancok[i].lany, 1);
                }
            }
        }
    }
}
