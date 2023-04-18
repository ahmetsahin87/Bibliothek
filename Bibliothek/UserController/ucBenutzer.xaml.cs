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
    /// Interaktionslogik für ucBenutzer.xaml
    /// </summary>
    public partial class ucBenutzer : UserControl
    {
        public List<Benutzer> Benutzerlist;
        public ucBenutzer()
        {
            InitializeComponent();
            using (DbCont _context = new DbCont())
            {
                Benutzerlist = _context.Benutzer.ToList();
            }
            grid_Benutzer.ItemsSource = Benutzerlist;
        }
    }
}
