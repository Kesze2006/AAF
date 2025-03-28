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

namespace Szinuszgorbe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //1.kordinata rendszer
    //2.kör(vekony)
    //3.fekete pont
    //4.sugar
    //5.magassag(piros)
    //6.szinusz görbe
    //7.korív(nagy)
    //8.körív(kicsi)
    //9.adattábla(szög egyebek)
    //sine curve and the unit circle
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void vaszon_Loaded(object sender, RoutedEventArgs e)
        {
            origoX = r * 1.1;
            origoY = Height / 2;


            kordinataRajzol();
            for (int i = 0; i < 360; i += 10)
            {
                kor(i);
                sugar(i);
            }
            
        }
        int r = 100;
        double origoY = 0;
        double origoX = 0;
        void kordinataRajzol()
        {
            Line xTengely = new Line();
            xTengely.Stroke = Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = Height / 2;
            xTengely.X2 = Width;
            xTengely.Y2 = Height / 2;
            


            Line yTengely = new Line();
            yTengely.Stroke = Brushes.Black;
            yTengely.X1 = r * 1.1;
            yTengely.Y1 = 0;
            yTengely.X2 = r * 1.1;
            yTengely.Y2 = Height;
            

            vaszon.Children.Add(xTengely);
            vaszon.Children.Add(yTengely);

            for (int i = 0; i < 5; i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = i*90 + yTengely.X1;
                vonalka.Y1 = Height / 2 - 5;
                vonalka.X2 = i * 90 + yTengely.X1;
                vonalka.Y2 = Height/ 2 + 5;
                vaszon.Children.Add(vonalka);
            }

            for (int i = 0;i < 5;i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = yTengely.X1 -5 ;
                vonalka.Y1 = i*90+(xTengely.Y1 - 180);
                vonalka.X2 = yTengely.X1 + 5;
                vonalka.Y2 = i*90 + (xTengely.Y1 - 180);
                vaszon.Children.Add(vonalka);
            }
        }
        int korX = 0;
        int korY = 0;
        void kor(int x)
        {
            Ellipse kor = new Ellipse();
            kor.Stroke = Brushes.Blue;
            kor.Height = 2 * r;
            kor.Width = 2 * r;
            kor.Margin = new Thickness(x - r +origoX-r, origoY-r,0,0);

            korX = Convert.ToInt32(x - r + origoX);
            korY = Convert.ToInt32(origoY);
            vaszon.Children.Add(kor);
        }

        void sugar(int x)
        {
            Line sugar = new Line();
            sugar.Stroke = Brushes.Black;
            sugar.StrokeThickness = 5;
            sugar.X1 = korX;
            sugar.Y1 = korY;
            sugar.X2 = x+ origoX;
            sugar.Y2 = Math.Sin(x/180.0*Math.PI)*r+origoY;

            vaszon.Children.Add(sugar);
        }
    }
}