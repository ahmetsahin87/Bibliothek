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
            using (DbCont _context = new DbCont())
            {
                Authorlist = _context.Author.ToList();
            }
            grid_Author.ItemsSource = Authorlist;
        }
    }
}
