using Bibliothek.Services;
using Repository.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

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
            DataContext = service.GetAusleihVMs().Where(a => a.RueckgabeDatum == null).ToList();

        }
    }
}
