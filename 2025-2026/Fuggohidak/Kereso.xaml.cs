using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Fuggohidak
{
    /// <summary>
    /// Interaction logic for Kereso.xaml
    /// </summary>
    public partial class Kereso : Window
    {
        public Kereso()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow foAblak = new MainWindow();
            this.Close();
            foAblak.Show();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> orszagok = new List<string>();
            foreach (Fuggohid hid in Fuggohid.Olvas())
            {
                if (!orszagok.Contains(hid.orszag))
                {
                    orszagok.Add(hid.orszag);
                }
            }
            comboBox.ItemsSource = orszagok;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            hidak.Text = "";
            foreach (Fuggohid hid in Fuggohid.Olvas())
            {
                if (comboBox.Text == hid.orszag)
                {
                    if (hossz.IsChecked == true)
                    {
                        if (hid.hossza > 1000)
                        {
                            hidak.Text += hid.hidNeve + "\n";
                        }
                    }
                    else
                    {
                        hidak.Text += hid.hidNeve + "\n";
                    }
                }
            }
        }
    }
}
