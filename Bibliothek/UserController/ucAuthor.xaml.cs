using Bibliothek.Services;
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
        Buch_Service service = new Buch_Service();
        public ucAuthor()
        {
            InitializeComponent();                
            DataContext = service.GetAuthorVMs();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Author_Add author_Add = new Author_Add();
            author_Add.Closed += AuthorAdd_Closed;
            author_Add.Show();  
        }

        private void AuthorAdd_Closed(object? sender, EventArgs e)
        {
            List<AuthorVM> authorVMs = service.GetAuthorVMs();
            grid_Author.ItemsSource= authorVMs;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = grid_Author.SelectedItem as AuthorVM;
            service.DeleteAuthor(a.Id);
            List<AuthorVM> authorList = service.GetAuthorVMs();//Aktualisiert gridtabelle nach der Löschung
            grid_Author.ItemsSource = authorList;
        }
    }
}
