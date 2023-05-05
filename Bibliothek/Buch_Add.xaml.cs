using Bibliothek.Klassen;
using Bibliothek.UserController;
using Bibliothek.VMs;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace Bibliothek
{
    /// <summary>
    /// Interaktionslogik für Buch_Add.xaml
    /// </summary>
    public partial class Buch_Add : Window
    {

        public Buch_Add()
        {
            InitializeComponent();
            using (DbCont _context = new DbCont())
            {
                menuAuthor.DataContext = _context.Author.ToList();
                menuVerlag.DataContext = _context.Verlags.ToList();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedAuthor = menuAuthor.SelectionBoxItem as Author;
            var selectedVerlag = menuVerlag.SelectionBoxItem as Verlag;
            var neuesBuch = new Buch()
            {
                Name = box_titel.Text,
                Seite = Int32.Parse(box_seite.Text),
                Erscheinungsjahr = (DateTime)dateEJ.SelectedDate,
                AuthorId =  selectedAuthor.Id,
                VerlagId =  selectedVerlag.Id
            };

            using (DbCont _context = new DbCont())
            {
                _context.Buches.Add(neuesBuch);
                _context.SaveChanges();
                 var main = new MainWindow();
                 this.Close();
                 main.Show();

            }
        }

       
       

    }
}
