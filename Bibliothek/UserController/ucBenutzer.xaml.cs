using Bibliothek.Services;
using Bibliothek.VMs;
using Repository.Models;
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

namespace Bibliothek.UserController
{
    /// <summary>
    /// Interaktionslogik für ucBenutzer.xaml
    /// </summary>
    /// 
    public partial class ucBenutzer : UserControl
    {
        Buch_Service service = new Buch_Service();
        public ucBenutzer()
        {
            InitializeComponent();
            DataContext= service.GetBenutzerVMs(); //Verbindet XAML zu Data

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Benutzer_Add nutzer_add = new Benutzer_Add();
            nutzer_add.Closed += BenutzerAdd_Closed;
            nutzer_add.Show();
        }

        private void BenutzerAdd_Closed(object? sender, EventArgs e)
        {
            List<BenutzerVM> benutzerlist = service.GetBenutzerVMs();
            grid_Benutzer.ItemsSource = benutzerlist;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = grid_Benutzer.SelectedItem as BenutzerVM;
            service.DeleteBenutzer(a.Id);
            List<BenutzerVM> nutzerList = service.GetBenutzerVMs();//Aktualisiert gridtabelle nach der Löschung
            grid_Benutzer.ItemsSource = nutzerList;
        }
    }
}
