using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HF_02._19
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

        private void Gomb_Click(object sender, RoutedEventArgs e)
        {
            if (kepBalFent.Visibility == Visibility.Visible && kepBalLent.Visibility == Visibility.Visible && kepJobbFent.Visibility == Visibility.Visible && kepJobbLent.Visibility == Visibility.Visible)
            {
                kepBalFent.Visibility = Visibility.Hidden;
                kepBalLent.Visibility = Visibility.Hidden;
                kepJobbFent.Visibility = Visibility.Hidden;
                kepJobbLent.Visibility = Visibility.Hidden;
            }
            else
            {
                kepBalFent.Visibility = Visibility.Visible;
                kepBalLent.Visibility = Visibility.Visible;
                kepJobbFent.Visibility = Visibility.Visible;
                kepJobbLent.Visibility = Visibility.Visible;
            }
        }

        private void balFent_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kepBalFent.Opacity = balFent.Value;
        }

        private void balLent_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kepBalLent.Opacity = balLent.Value;
        }

        private void jobbLent_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kepJobbLent.Opacity = jobbLent.Value;
        }

        private void jobbFent_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kepJobbFent.Opacity = jobbFent.Value;
        }
    }
}