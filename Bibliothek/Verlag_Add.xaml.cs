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
using System.Windows.Shapes;

namespace Bibliothek
{
    /// <summary>
    /// Interaktionslogik für Verlag_Add.xaml
    /// </summary>
    public partial class Verlag_Add : Window
    {
        Buch_Service service = new Buch_Service();
        public Verlag_Add()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var neuerVerlag = new Verlag()
            {
                Name = box_name_Verlag.Text,
                Email = box_email_verlag.Text,
                Ort = box_ort_verlag.Text
            };            
            service.CreateVerlag( neuerVerlag );
            Close();

        }

       
    }
}
