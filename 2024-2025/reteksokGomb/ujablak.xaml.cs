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

namespace reteksokGomb
{
    /// <summary>
    /// Interaction logic for ujablak.xaml
    /// </summary>
    public partial class ujablak : Window
    {
        public ujablak()
        {
            InitializeComponent();
        }

        public int[] adarbok = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0, }; 


        public void Show(int gombSzam)
        {
            adarbok[gombSzam]++;
            this.Show();
        }

        private void csa_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
