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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFgyak_02._23
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
        

        private void gomb_Click(object sender, RoutedEventArgs e)
        {
            string nev = Nev.Text;
            string szhely = szHely.Text;
            string kor = Eletkor.Text;

            if (nev == "" || szhely == "" || kor == "")
            {
                MessageBox.Show("Na na, mind az összes kell!");
            }
            else
            {
                Kijelzo.Items.Add(nev + ", " + szhely + ", " + kor);

                Nev.Text = "";
                szHely.Text = "";
                Eletkor.Text = "";
            }
        }

        private void Kijelzo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
