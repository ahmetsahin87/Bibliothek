
using Bibliothek.Klassen;
using Bibliothek.Services;
using Bibliothek.UserController;
using Bibliothek.VMs;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
namespace Bibliothek.UserController
{
    /// <summary>
    /// Interaktionslogik für ucBuchList1.xaml
    /// </summary>
    public partial class ucBuchList1 : UserControl
    {
        public List<Buch> Buchlist;
        //  public List<BuchVM> Buch_VM_List ;
        Buch_Service service=new Buch_Service();
       
        public ucBuchList1()
        {
             InitializeComponent();
            
            DataContext = service.GetBuchVMs(); //Verbindet XAML zu Data
           
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Buch_Add add = new Buch_Add();
            add.ShowDialog();
                    
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            var a = grid_buch.SelectedItem as BuchVM;
            service.DeleteBuch(a.Id);
            List<BuchVM> buchList = service.GetBuchVMs();//aktualsisert gridview nach der Löschung
            grid_buch.ItemsSource = buchList;
        }
    }
}
