using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
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
    /// Interaction logic for PolicePage.xaml
    /// </summary>
    public partial class PolicePage : Page
    {
        public static ObservableCollection<Traffic_Police_Officer> polices { get; set; }
        public PolicePage()
        {
            InitializeComponent();
            polices = new ObservableCollection<Traffic_Police_Officer>(BD_Connection.connection.Traffic_Police_Officer.ToList());

            var p = new Traffic_Police_Officer();
            this.DataContext = this;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var n = (sender as ListView).SelectedItem as Traffic_Police_Officer;
            NavigationService.Navigate(new PolicemanPage(n));
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPolicemanPage());
        }
    }
}
