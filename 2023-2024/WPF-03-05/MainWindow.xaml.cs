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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_03_05
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textblock.Text = textbox.Text.ToUpper();
            textbox.Focus();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textblock.Text = textbox.Text;
            if (sakk.IsChecked == true)
            {
                textblock.Text = textbox.Text.ToUpper();
            }
            string[] tomb = textbox.Text.Split(" ");
            doboz.ItemsSource = tomb;
        }

        private void sakk_Unchecked(object sender, RoutedEventArgs e)
        {
            textblock.Text = textbox.Text;
            textbox.Focus();
        }

        private void doboz_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string vissza = "";
            for(int i = 0; i < doboz.Items.Count; i++)
            {
                if (doboz.SelectedIndex != i)
                {
                    vissza += doboz.Items[i]+" ".TrimEnd();
                }
            }

            textbox.Text = vissza;
        }
    }
}
