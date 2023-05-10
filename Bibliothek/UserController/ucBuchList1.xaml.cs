

using Bibliothek.Services;
using Bibliothek.VMs;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
namespace Bibliothek.UserController
{
    /// <summary>
    /// Interaktionslogik für ucBuchList1.xaml
    /// </summary>
    public partial class ucBuchList1 : UserControl
    {
        public List<Buch> Buchlist;
        Buch_Service service=new Buch_Service();
       
        public ucBuchList1()
        {
            InitializeComponent();            
            DataContext = service.GetBuchVMs(); //Verbindet XAML zu Data           
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Buch_Add buch_add = new Buch_Add();
            buch_add.Closed += BuchAdd_Closed;
            buch_add.Show();                    
        }

        private void BuchAdd_Closed(object? sender, EventArgs e)
        {
            List<BuchVM> buchList = service.GetBuchVMs();//Aktualisiert gridtabelle nach der Erstellung des Buches
            grid_buch.ItemsSource = buchList;
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            var a = grid_buch.SelectedItem as BuchVM;
            service.DeleteBuch(a.Id);
            List<BuchVM> buchList = service.GetBuchVMs();//Aktualisiert gridtabelle nach der Löschung
            grid_buch.ItemsSource = buchList;            
        }

        private void grid_buch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
