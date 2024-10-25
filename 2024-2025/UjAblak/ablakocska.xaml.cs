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

namespace UjAblak
{
    /// <summary>
    /// Interaction logic for ablakocska.xaml
    /// </summary>
    public partial class ablakocska : Window
    {
        MainWindow szulo;
        public ablakocska(MainWindow szulo)
        {
            this.szulo = szulo;
            InitializeComponent();
        }

        private void gombablak_Click(object sender, RoutedEventArgs e)
        {
            szulo.gomberedeti.Content = "Fasza";
            this.Close();
        }
    }
}
