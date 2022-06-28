using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
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

namespace TrafficPolice
{
    /// <summary>
    /// Interaction logic for TechInspectPage.xaml
    /// </summary>
    public partial class TechInspectPage : Page
    {
        public static ObservableCollection<Tech_inspect_car> inspects { get; set; }
        public TechInspectPage()
        {
            InitializeComponent();
            inspects = new ObservableCollection<Tech_inspect_car>(BD_Connection.connection.Tech_inspect_car.ToList());

            var i = new Tech_inspect_car();
            this.DataContext = this;
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var n = (sender as ListView).SelectedItem as Tech_inspect_car;
            NavigationService.Navigate(new OneInspectPage(n));
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddInspectPage());
        }
    }
}
