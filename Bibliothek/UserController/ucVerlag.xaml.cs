using Bibliothek.Services;
using Bibliothek.VMs;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace Bibliothek.UserController
{
    /// <summary>
    /// Interaktionslogik für ucVerlag.xaml
    /// </summary>
    public partial class ucVerlag : UserControl
    {
        Buch_Service service = new Buch_Service();

        public ucVerlag()
        {
            InitializeComponent();
            DataContext = service.GetVerlagVMs();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Verlag_Add verlag_Add = new Verlag_Add();
            verlag_Add.Closed += Verlag_Add_Closed;
            verlag_Add.Show();
        }

        private void Verlag_Add_Closed(object? sender, EventArgs e)
        {
           List<VerlagVM> verlaglist = service.GetVerlagVMs();
            grid_verlag.ItemsSource = verlaglist; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = grid_verlag.SelectedItem as VerlagVM;
            service.DeleteVerlag(a.Id);
            List<VerlagVM> verlaglist = service.GetVerlagVMs();
            grid_verlag.ItemsSource = verlaglist;
        }
    }
}
