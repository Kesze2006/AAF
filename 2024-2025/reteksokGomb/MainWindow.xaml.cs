﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace reteksokGomb
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
        ujablak ablakocska = new ujablak();
        private void gomb_Click(object sender, RoutedEventArgs e)
        {
            ablakocska.Show(0);
            gomb.Content = ablakocska.adarbok[0];
        }
    }
}