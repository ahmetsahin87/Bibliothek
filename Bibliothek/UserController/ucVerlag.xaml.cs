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
            using (DbCont _context = new DbCont())
            {
                Verlaglist = _context.Verlags.ToList();
            }
            grid_verlag.ItemsSource = Verlaglist;
        }
    }
}
