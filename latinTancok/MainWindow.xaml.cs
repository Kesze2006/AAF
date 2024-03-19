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
    }
}
