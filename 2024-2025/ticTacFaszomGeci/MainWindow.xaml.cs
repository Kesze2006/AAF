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

namespace ticTacFaszomGeci
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

        public int katintas = 0;
        static void klik(Button gomb, int katt)
        {
            if (katt % 2 == 0)
            {
                gomb.Content = "X";
            }
            else
            {
                gomb.Content = "O";
            }
            gomb.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void elso_Click(object sender, RoutedEventArgs e)
        {
            klik(elso, katintas);
        }

        private void masodik_Click(object sender, RoutedEventArgs e)
        {
            klik(masodik, katintas);
        }
    }
}