using Bibliothek.Services;
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
using System.Windows.Shapes;

namespace Bibliothek
{
    /// <summary>
    /// Interaktionslogik für Benutzer_Add.xaml
    /// </summary>
    /// 
    public partial class Benutzer_Add : Window
    {
        Buch_Service service = new Buch_Service();
        public Benutzer_Add()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var neuerNutzer = new Benutzer()
            {
                VorName = box_vorname.Text,
                Nachname = box_nachname.Text,
                Geburtsdatum = (DateTime)dateEJ.SelectedDate
                
            };
            service.CreateBenutzer(neuerNutzer);
            Close();

        }
    }
}
