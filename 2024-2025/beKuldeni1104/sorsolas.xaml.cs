using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace beKuldeni1104
{
    /// <summary>
    /// Interaction logic for sorsolas.xaml
    /// </summary>
    public partial class sorsolas : Window
    {
        MainWindow szulo;
        public sorsolas(MainWindow szulo)
        {
            this.szulo = szulo;
            InitializeComponent();
        }

        List<int> sorsoltszamok = new List<int>();
        int szamokhelye = 1;
        private void ablak_Activated(object sender, EventArgs e)
        {
            if (szamokhelye <= 5)
            {
                szamokhelye++;
                Random Szam = new Random();
                int sorsoltSzam = Szam.Next(0, 90);
                for (int i = 1; i < sorsoltszamok.Count(); i++)
                {
                    while (sorsoltSzam != sorsoltszamok[i])
                    {
                        sorsoltSzam = Szam.Next();
                    }
                    sorsoltszamok.Append(sorsoltSzam);
                }
                szulo.szamok.Text += sorsoltSzam.ToString()+" ";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
