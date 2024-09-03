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

namespace GUI_02._20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool betoltott = false;

        public MainWindow()
        {
            InitializeComponent();

            this.betoltott = true;
        }

        double[] ertekek = new double[4] { 1, 1, 1, 1 };

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott)
            {
                ertekek[0] = folso.Value;

                BalF.Opacity = (1 - ertekek[0]) * ertekek[1];
                JobbF.Opacity = ertekek[0] * ertekek[3];
            }
        }

        private void bal_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott)
            {
                ertekek[1] = bal.Value;

                BalF.Opacity = (1 - ertekek[0]) * ertekek[1];
                BalL.Opacity = (1 - ertekek[1]) * ertekek[2];
            }

        }

        private void also_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott)
            {
                ertekek[2] = also.Value;

                JobbL.Opacity = (1-ertekek[1]) * ertekek[2];
                BalL.Opacity = (1 - ertekek[2]) * ertekek[3];
                
            }

        }

        private void jobb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            if (betoltott)
            {
                ertekek[3] = also.Value;
                ertekek[3] = ((Slider)sender).Value;

                JobbF.Opacity = (1 - ertekek[2]) * ertekek[3];
                JobbL.Opacity = (1 - ertekek[3]) * ertekek[0];

            }
        }
    }
}
