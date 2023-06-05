using Bibliothek.Services;
using Repository.Models;
using System;
using System.Windows;

namespace Bibliothek
{
    /// <summary>
    /// Interaktionslogik für AusleihAdd.xaml
    /// </summary>
    public partial class AusleihAdd : Window
    {
        Buch_Service service = new Buch_Service();
        public AusleihAdd()
        {
            InitializeComponent();
            menuBenutzer.DataContext = service.GetBenutzerList();
            menuBuch.DataContext = service.GetBuchList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedBuch = menuBuch.SelectionBoxItem as Buch;
            var selectedBenutzer = menuBenutzer.SelectionBoxItem as Benutzer;
            var neuAusleih = new Ausleih()
            {
                AusleihDatum = (DateTime)dateEJ.SelectedDate,
                BuchId = selectedBuch.Id,
                BenutzerId = selectedBenutzer.Id
            };
            service.CreateAusleih(neuAusleih);
            Close();
        }


    }
}
