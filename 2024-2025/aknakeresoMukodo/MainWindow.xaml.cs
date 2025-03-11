using System.Runtime.CompilerServices;
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

namespace aknakeresoMukodo
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        int sor = 10;
        int oszlop = 10;
        int aknaDB = 0;
        Button[,] gombok;



        private void SirTuszo_Click(object sender, RoutedEventArgs e)
        {
            Button[,] gombok = new Button[sor, oszlop];
            grid.Children.Remove(SirTuszo);
            for (int i = 0; i < sor; i++)
            {
                for (int k = 0; k < oszlop; k++)
                {
                    Button g = new Button();
                    g.VerticalAlignment = VerticalAlignment.Top;
                    g.HorizontalAlignment = HorizontalAlignment.Left;
                    g.Height = 25;
                    g.Width = 25;
                    g.Margin = new Thickness(i * 25, k*25, 0, 0);
                    g.Click += kattinats;
                    grid.Children.Add(g);
                    gombok[k,i] = g;
                }
            }
            this.SizeToContent = SizeToContent.WidthAndHeight;
            aknaLerak();
        }
        int[] akanHely;
        void aknaLerak()
        {
            akanHely
        }

        private void kattinats(object sender, RoutedEventArgs e)
        {
            
        }
    }
}