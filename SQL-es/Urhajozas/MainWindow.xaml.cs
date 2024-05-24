using System;
using System.Collections.Generic;
using System.IO;
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
using MySqlConnector;

namespace Urhajozas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string kapcsolat = "Server=localhost;User ID=root;Password=;Database=";

            using var adatbazis = new MySqlConnection(kapcsolat);
            adatbazis.Open();

            string jo = "drop database urhajozas";
            using var kell = new MySqlCommand(jo, adatbazis);
            kell.ExecuteNonQuery();
            try
            {
                string letrehoz = "CREATE DATABASE IF NOT EXISTS urhajozas DEFAULT CHARACTER set=utf8 COLLATE=utf8_hungarian_ci";
                using var kod1 = new MySqlCommand(letrehoz, adatbazis);
                kod1.ExecuteNonQuery();
    

                List<string> queries = new List<string>();
                queries.Add("USE urhajozas");
                queries.Add("CREATE TABLE `kuldetes` ( `id` int(11) NOT NULL, `megnevezes` varchar(100)  NOT NULL,  `kezdet` date NOT NULL, `veg` date NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;");
                queries.Add("CREATE TABLE `repules` (`urhajosid` int(11) NOT NULL,`kuldetesid` int(11) NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;");
                queries.Add("CREATE TABLE `urhajos` (`id` int(11) NOT NULL,`nev` varchar(100)  NOT NULL,`orszag` varchar(100)  NOT NULL,`nem` varchar(100)  NOT NULL,`szulev` int(11) NOT NULL,`urido` varchar(100)  NOT NULL) ENGINE=InnoDB DEFAULT CHARSET=utf8;");
                queries.Add("ALTER TABLE `repules`ADD PRIMARY KEY (`urhajosid`,`kuldetesid`);");
                queries.Add("ALTER TABLE `urhajos`ADD PRIMARY KEY (`id`);");
                queries.Add("COMMIT;");
                

                for (int i = 0; i < queries.Count; i++)
                {
                    letrehoz = queries[i];
                    using var kod = new MySqlCommand(letrehoz, adatbazis);
                    kod.ExecuteNonQuery();
                }
                StreamReader olvas = new StreamReader("adatok.sql");
                string parancs = olvas.ReadToEnd();
                olvas.Close();

                new MySqlCommand(parancs, adatbazis).ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
