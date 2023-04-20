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
    /// Interaktionslogik für ucVerlag.xaml
    /// </summary>
    public partial class ucVerlag : UserControl
    {
        public List<Verlag> Verlaglist;
        public ucVerlag()
        {
            InitializeComponent();
            var Verlag_VM_List = new List<VerlagVM>();
            using (DbCont _context = new DbCont())
            {
                
                Verlaglist = _context.Verlags.ToList();

                foreach (var verlag in Verlaglist)
                {
                    var vm = new VerlagVM();
                    vm.Name = verlag.Name;
                    vm.Ort = verlag.Ort;
                    vm.Email = verlag.Email;

                    Verlag_VM_List.Add(vm);

                }

            }
            this.DataContext = Verlag_VM_List;
        }
    }
}
