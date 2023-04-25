using Bibliothek.VMs;
using Microsoft.EntityFrameworkCore;
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
    /// Interaktionslogik für ucAusleih.xaml
    /// </summary>hkhhjkk
    public partial class ucAusleih : UserControl
    {
        public List<Ausleih> Ausleihlist;
        public ucAusleih() 
        {            
            InitializeComponent();
             
            List<AusleihVM> Ausleih_VM_List= new List<AusleihVM>();

            using (DbCont _context = new DbCont())
            {
                Ausleihlist = _context.Ausleihs.Include(a=>a.Buch).Include(b=>b.Benutzer).ToList();

                foreach (var ausleih in Ausleihlist)
                {
                    var vm = new AusleihVM();
                    vm.Id= ausleih.Id;
                    vm.AusleihDatum = ausleih.AusleihDatum;
                    vm.RueckgabeDatum = ausleih.RückgabeDatum;
                    vm.BenutzerVorname = ausleih.Benutzer.VorName;
                    vm.BenutzerNachname= ausleih.Benutzer.Nachname;
                    vm.Titel = ausleih.Buch.Name; 
                    
                    Ausleih_VM_List.Add(vm);
                }
            }
           this.DataContext= Ausleih_VM_List;
        }
    }
}
