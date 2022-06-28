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
    /// Interaction logic for PassPage.xaml
    /// </summary>
    public partial class PassPage : Page
    {
        public static ObservableCollection<Technical_Passport> passes { get; set; }
        public PassPage()
        {
            InitializeComponent();
            passes = new ObservableCollection<Technical_Passport>(BD_Connection.connection.Technical_Passport.ToList());

            var pass = new Technical_Passport();
            this.DataContext = this;
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewPassPage());
        }
    }
}
