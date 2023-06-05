using Bibliothek.Klassen;
using Bibliothek.Services;
using Bibliothek.VMs;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Bibliothek.UserController
{
    /// <summary>
    /// Interaktionslogik für ucAusleih.xaml
    /// </summary>hkhhjkk
    public partial class ucAusleih : UserControl
    {

        Buch_Service service = new Buch_Service();
        public ucAusleih()
        {
            InitializeComponent();
            DataContext = service.GetAusleihVMs();
        }

        private void button_ausleih_Click(object sender, RoutedEventArgs e)
        {
            AusleihAdd ausleih_add = new AusleihAdd();
            ausleih_add.Closed += Ausleih_Closed;
            ausleih_add.Show();
        }


        private void button_rueckgabe_Click(object sender, RoutedEventArgs e)
        {
            AusleihVM ausleih = (AusleihVM)grid_ausleih.SelectedItem;
            Rueckgabe rueckgabe = new Rueckgabe(ausleih);
            rueckgabe.Closed += Ausleih_Closed;
            rueckgabe.Show();

        }


        private void Ausleih_Closed(object? sender, EventArgs e)
        {
           
           grid_ausleih.ItemsSource = service.GetAusleihVMs();//Aktualisiert gridtabelle nach der Erstellung des Ausleihes
            //MainWindow mainWindow= new MainWindow();
            //UC_Call.UC_Add(mainWindow.Inhalt, new ucAusleih());
        }


       
    }
}
