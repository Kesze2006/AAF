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

namespace szorzasGyak
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
            int elsoSzam = int.Parse(szam1.Text);
            int masodikSzam = int.Parse(szam2.Text);
            Label df = new Label();
            df.Content = elsoSzam + masodikSzam;
            panel.Children.Add(df);
        }
    }
}