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

namespace Fuggohidak
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
        List<Fuggohid> hidak = Fuggohid.Olvas();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Fuggohid hid in hidak)
            {
                listaBox.Items.Add(hid.hidNeve);
            }
        }

        private void listaBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Fuggohid hid in hidak)
            {
                if (listaBox.SelectedIndex == hid.helyezes-1)
                {
                    hely.Text = hid.foldrajziHely;
                    hossz.Text = hid.hossza.ToString();
                    orszag.Text = hid.orszag;
                    ev.Text = hid.atadasEve.ToString();
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            int db = 0;
            foreach (Fuggohid hid in hidak)
            {
                if (hid.atadasEve < 2000)
                {
                    db++;
                }
            }
            darabSzam.Text = db.ToString();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            int db = 0;
            foreach (Fuggohid hid in hidak)
            {
                if (hid.atadasEve >= 2000)
                {
                    db++;
                }
            }
            darabSzam.Text = db.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Kereso ujablak = new Kereso();
            this.Hide();
            ujablak.Show();
        }
    }
}