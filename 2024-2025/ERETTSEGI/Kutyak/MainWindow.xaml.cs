using System.IO;
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


namespace Kutyak
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
        List<KutyaNev> kutyaNevek = new List<KutyaNev>();
        List<KutyaFajat> kutyaFajtak = new List<KutyaFajat>();
        List<Kutya> kutyak = new List<Kutya>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("KutyaNevek.csv");
            for (int i = 1; i < sorok.Length; i++)
            {
                string[] vag = sorok[i].Split(";");
                kutyaNevek.Add(new KutyaNev(Convert.ToInt32(vag[0]), vag[1]));
            }

            sorok = File.ReadAllLines("KutyaFajtak.csv");
            for (int i = 1; i < sorok.Length; i++)
            {
                string[] vag = sorok[i].Split(";");
                kutyaFajtak.Add(new KutyaFajat(Convert.ToInt32(vag[0]), vag[1], vag[2]));
            }

            sorok = File.ReadAllLines("Kutyak.csv");
            for (int i = 1; i < sorok.Length; i++)
            {
                string[] vag = sorok[i].Split(";");
                kutyak.Add(new Kutya(int.Parse(vag[0]), int.Parse(vag[1]), int.Parse(vag[2]), int.Parse(vag[3]), DateOnly.Parse(vag[4]), kutyaFajtak.Where(x => x.id == int.Parse(vag[1])).First(),kutyaNevek.Where(x => x.id == int.Parse(vag[2])).First()));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _3Display.Content = Convert.ToString(kutyaNevek.Last().id);
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            List<int> korok = new List<int>();
            korok = kutyak.Select(x => x.eletkor).ToList();
            _6Display.Content =  Math.Round(korok.Average(),2);
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            List<int> korok = new List<int>();
            korok = kutyak.Select(x => x.eletkor).ToList();
            int maxKor = korok.Max();
            Kutya idosKutya = kutyak.Where(x => x.eletkor == maxKor).First();
            _7Display.Content = idosKutya.nev.nev+", "+idosKutya.fajta.nev;
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            var azNap = kutyak.Where(x => x.datum == DateOnly.FromDateTime((DateTime)picker.SelectedDate)).ToList();
            _8ListaDisplay.ItemsSource = azNap.Select(x => x.nev.nev);
        }
    }
}