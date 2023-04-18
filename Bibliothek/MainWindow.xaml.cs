using Bibliothek.Klassen;
using Bibliothek.UserController;
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

namespace Bibliothek
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

        private void btn_Schliessen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       



        private void windowload(object sender, RoutedEventArgs e)
        {
            UC_Call.UC_Add(Inhalt, new ucBuchList1());
        }

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState= WindowState.Minimized;
        }

        private void btn_maximize_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState==WindowState.Normal)
            this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }
        private void btn_Katalog_click(object sender, RoutedEventArgs e)
        {
            UC_Call.UC_Add(Inhalt, new ucBuchList1());
        }

        private void menubtn_Benutzer_Click(object sender, RoutedEventArgs e)
        {
            UC_Call.UC_Add(Inhalt, new ucBenutzer());
        }

        private void menubtn_Ausleih_Click(object sender, RoutedEventArgs e)
        {
            UC_Call.UC_Add(Inhalt, new ucAusleih());
        }

        private void menubtn_Abgelaufen_Click(object sender, RoutedEventArgs e)
        {
            UC_Call.UC_Add(Inhalt, new ucAbgelaufen());
        }

        private void menubtn_Verlag_Click(object sender, RoutedEventArgs e)
        {
            UC_Call.UC_Add(Inhalt, new ucVerlag());
        }

        private void menubtn_Author_Click(object sender, RoutedEventArgs e)
        {
            UC_Call.UC_Add(Inhalt, new ucAuthor());
        }
    }
}
