using Bibliothek.Services;
using Repository.Models;
using System.Windows;


namespace Bibliothek
{
    /// <summary>
    /// Interaktionslogik für Author_Add.xaml
    /// </summary>
    /// 
    public partial class Author_Add : Window
    {
        Buch_Service service = new Buch_Service();
        public Author_Add()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var neuerAuthor = new Author()
            {
                VorName = box_vorname.Text,
                Nachname = box_nachname.Text
            };
            service.CreateAuthor(neuerAuthor);
            Close();
        }
    }
}
