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
using System.Windows.Shapes;

namespace gyak241025
{
    /// <summary>
    /// Interaction logic for uj.xaml
    /// </summary>
    public partial class uj : Window
    {
        MainWindow szulo;
        Button gomb;
        public uj(Button sender, MainWindow szulo)
        {
            this.gomb = sender;
            this.szulo = szulo;
            InitializeComponent();
        }

        private void vissza_Click(object sender, RoutedEventArgs e)
        {
            gomb.Content = beker.Text;
            this.Close();
        }
    }
}
