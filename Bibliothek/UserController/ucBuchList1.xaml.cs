
using Bibliothek.Klassen;
using Bibliothek.UserControllers;
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
       
        public ucBuchList1()
        {
             InitializeComponent();
            var Buch_VM_List =new List<BuchVM>();

            using (DbCont _context=new DbCont())
            {
                Buchlist = _context.Buches.Include(b => b.Author).Include(b => b.Verlag).ToList();

                
                foreach (var buch in Buchlist)
                {
                    var vm = new BuchVM();
                    vm.Id= buch.Id;
                    vm.Name = buch.Name;
                    vm.Seite = buch.Seite;
                    vm.Erscheinungsjahr = buch.Erscheinungsjahr.Year;
                    vm.Author = buch.Author.Nachname;
                    vm.Verlag = buch.Verlag.Name;
                   
                    Buch_VM_List.Add(vm);   
                    
                }
            }    



            this.DataContext = Buch_VM_List; //Verbindet XAML zu Data
           // grid_buch.ItemsSource= Buchlist;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
            Add_Buch badd = new Add_Buch();
            
        }
    }
}
