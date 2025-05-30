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
using static System.Net.Mime.MediaTypeNames;

namespace aknakereso_papaval
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
        int sor = 10;
        int oszlop = 10;
        int aknaDarab = 10;
        Button[,] gombok;

        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            gombok = new Button[sor, oszlop];
            for (int k = 0; k < sor; k++)
            {

                for (int i = 0; i < oszlop; i++)
                {

                    Button g = new Button();
                    g.VerticalAlignment = VerticalAlignment.Top;
                    g.HorizontalAlignment = HorizontalAlignment.Left;
                    g.Width = 25;
                    g.Height = 25;
                    g.Click += kattintas;
                    g.Margin = new Thickness(i * 25, k * 25, 0, 0);
                    racs.Children.Add(g);
                    gombok[k, i] = g;
                }
            }
            racs.Children.Remove(startGomb);
            this.SizeToContent = SizeToContent.WidthAndHeight;
            aknalerak();

        }
        int[,] aknaHely;
        Random rand = new Random();
        void aknalerak()
        {
            aknaHely = new int[sor, oszlop];


            for (int k = 0; k < aknaDarab; k++)
            {
                int randomSor = rand.Next(sor);
                int randomOszlop = rand.Next(oszlop);
                if (aknaHely[randomSor, randomOszlop] == 10)
                {
                    k--;
                }
                else
                {
                    aknaHely[randomSor, randomOszlop] = 10;
                }

            }

            for (int k = 0; k < aknaHely.GetLength(0); k++)
            {
                for (int i = 0; i < aknaHely.GetLength(1); i++)
                {
                    if (aknaHely[k, i] != 10)
                    {
                        aknaHely[k, i] = aknaSzamol(k, i);
                    }
                }
            }
            
        }
        void aknaMutat()
        {
            for (int k = 0; k < aknaHely.GetLength(0); k++)
            {
                for (int i = 0; i < aknaHely.GetLength(1); i++)
                {
                    gombok[k, i].Content = aknaHely[k, i];
                }
            }
        }
        int aknaSzamol(int sor, int oszlop)
        {
            int db = 0;
            if (sor - 1 >= 0 && oszlop - 1 >= 0 && aknaHely[sor - 1, oszlop - 1] == 10){db++;}
            if (sor - 1 >= 0 && oszlop>= 0 && aknaHely[sor - 1, oszlop] == 10) { db++; }
            if (sor - 1 >= 0 && oszlop + 1 < this.oszlop && aknaHely[sor - 1, oszlop + 1] == 10) { db++; }

            if (sor >= 0 && oszlop - 1 >= 0 && aknaHely[sor , oszlop - 1] == 10) { db++; }
            if (sor  >= 0 && oszlop + 1 < this.oszlop && aknaHely[sor, oszlop + 1] == 10) { db++; }

            if (sor + 1 < this.sor && oszlop - 1 >= 0 && aknaHely[sor + 1, oszlop - 1] == 10) { db++; }
            if (sor + 1 < this.sor && oszlop >= 0 && aknaHely[sor + 1, oszlop] == 10) { db++; }
            if (sor + 1 < this.sor && oszlop + 1 < this.oszlop && aknaHely[sor + 1, oszlop + 1] == 10) { db++; }

            return db;
        }

        void helyEllenoriz(int sor, int oszlop)
        {
            if (aknaHely[sor, oszlop] == 10)
            {
                Image akna = new Image();

                BitmapImage lajos = new BitmapImage();
                lajos.BeginInit();
                lajos.UriSource = new Uri("smiley_stackpanel.PNG", UriKind.Relative);
                lajos.EndInit();
                akna.Stretch = Stretch.Fill;
            }
        }




        private void kattintas(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            for (int i = 0; i < gombok.GetLength(0); i++)
            {
                for (int j = 0; j < gombok.GetLength(1); j++)
                {
                    if (gombok[i, j] == button)
                    {
                        gombok[i, j].Content = aknaHely[i, j];

                        helyEllenoriz(i, j);
                        i = gombok.GetLength(0);
                        j = gombok.GetLength(1);
                    }
                }
            }
        }
    }
}