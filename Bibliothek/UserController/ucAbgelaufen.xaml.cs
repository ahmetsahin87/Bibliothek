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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bibliothek.UserController
{
    /// <summary>
    /// Interaktionslogik für ucAbgelaufen.xaml
    /// </summary>
    
    public partial class ucAbgelaufen : UserControl
    {
        public List<Abgelaufen> Abgelaufenlist;
        Buch_Service service = new Buch_Service();
        public ucAbgelaufen()
        {
            InitializeComponent();
            DataContext = service.GetAusleihVMs().Where(a=> a.RueckgabeDatum==null).ToList();
            
        }
    }
}
