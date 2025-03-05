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

namespace aknaKereso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SizeToContent = SizeToContent.WidthAndHeight;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Button newBtn = new Button();
                    newBtn.Content = i.ToString();
                    newBtn.Name = "Button" + i.ToString();
                    newBtn.Height = 100;
                    newBtn.Width = 100;
                    newBtn.HorizontalAlignment = HorizontalAlignment.Left;
                    newBtn.VerticalAlignment = VerticalAlignment.Top;
                    grid.Children.Add(newBtn);
                }

                grid.Children.Remove(lajos);
            }
        }
    }
}