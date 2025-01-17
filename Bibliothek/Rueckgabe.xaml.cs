using Bibliothek.Services;
using Bibliothek.VMs;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace Bibliothek
{
    /// <summary>
    /// Interaktionslogik für Rueckgabe.xaml
    /// </summary>
    public partial class Rueckgabe : Window
    {

        Buch_Service service = new Buch_Service();
        AusleihVM AusleihVM { get; set; }
        public Rueckgabe(AusleihVM ausleihVM)
        {
            InitializeComponent();
            DataContext = ausleihVM;
            AusleihVM = ausleihVM;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var ausleih = service.GetAusleih(AusleihVM.Id);
            ausleih.RueckgabeDatum = (DateTime)dateEJ.SelectedDate;
            service.RueckgabeAusleih(ausleih);
            service.GetAusleihVMs();

            Close();
        }
    }
}
