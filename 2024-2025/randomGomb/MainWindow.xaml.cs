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

namespace randomGomb
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

        private void randomGomb_MouseMove(object sender, MouseEventArgs e)
        {
            Random szam = new Random();
            double x = szam.NextDouble();
            double y = szam.NextDouble();
            randomGomb.Margin =new Thickness(x,y,0,0);
        }
    }
}