using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

namespace Bastyak
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mezo(0,0,"martin");
            mezo(2, 6, "alma");
            
        }

        private void mezo(int sor, int oszlop, string tartalom)
        {
            Label cimke = new Label();
            cimke.Content = tartalom;
            cimke.BorderBrush = Brushes.SlateBlue;
            cimke.BorderThickness = new Thickness(1);
            cimke.Background = Brushes.AliceBlue;
            cimke.Height = tabla.Height/8;
            cimke.Width = tabla.Width/8;
            cimke.Margin = new Thickness(cimke.Width*oszlop, cimke.Height*sor, 0, 0);
            cimke.HorizontalAlignment = HorizontalAlignment.Left;
            cimke.VerticalAlignment = VerticalAlignment.Top;
            tabla.Background = Brushes.LightGreen;
            tabla.Children.Add(cimke);
        }
    }
}
