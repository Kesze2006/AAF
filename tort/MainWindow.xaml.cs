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

namespace tort
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


        private int lnko(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else if (a < b)
            {
                return lnko(a, b - a);
            }
            else if (a > b)
            {
                return lnko(a - b, b);
            }
            return 1;
        }

        private void szbekero_TextChanged(object sender, TextChangedEventArgs e)
        {
            int szamlalo = 0;
            try
            {
                szamlalo = Convert.ToInt32(szbekero.Text);
            }
            catch
            {
            }
            int nevezo = 0;
            try
            {
                nevezo = Convert.ToInt32(nbekero.Text);
            }
            catch
            {
            }


            if (nevezo != 0 && szamlalo % nevezo == 0)
            {
                kiir.Text = "" + szamlalo + "/" + nevezo;
            }
            else if (nevezo != 0 && szamlalo % nevezo != 0)
            {
                kiir.Text = "Nem egész!";
            }
            else
            {
                kiir.Text = "Nullával való osztás";
            }
            textblock1.Text = szamlalo.ToString();
            textblock2.Text = nevezo.ToString();

            if (nevezo != 0 && szamlalo != 0)
            {
                int oszto = lnko(szamlalo, nevezo);

                textblock3.Text = (szamlalo / oszto).ToString();
                textblock4.Text = (nevezo / oszto).ToString();
                _4_fel.IsEnabled = true;
            }
            else
            {
                _4_fel.IsEnabled = false;
            }
        }

        private void szbekero1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int szamlalo = 0;
            try
            {
                szamlalo = Convert.ToInt32(szbekero1.Text);
            }
            catch
            {
            }
            int nevezo = 0;
            try
            {
                nevezo = Convert.ToInt32(nbekero1.Text);
            }
            catch
            {
            }
            textblock5.Text = szamlalo.ToString();
            textblock6.Text = nevezo.ToString();
        }
    }
}
