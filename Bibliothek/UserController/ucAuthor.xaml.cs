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
    /// Interaktionslogik für ucAuthor.xaml
    /// </summary>
    public partial class ucAuthor : UserControl
    {
        public List<Author> Authorlist;

        public ucAuthor()
        {
            InitializeComponent();
           
            var Author_VM_list = new List<AuthorVM>();
            using (DbCont _context = new DbCont())
            {
                Authorlist = _context.Author.ToList();
                
                foreach (Author author in Authorlist)
                {
                    var vm = new AuthorVM();

                    vm.Id = author.Id;
                    vm.Nachname = author.Nachname;
                    vm.Vorname = author.VorName;

                    Author_VM_list.Add(vm);                   
                }
            }
            this.DataContext = Author_VM_list;
        }
    }
}
