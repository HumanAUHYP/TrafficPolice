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
    /// Interaction logic for HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public static ObservableCollection<Inspection_History> historys { get; set; }
        public HistoryPage()
        {
            InitializeComponent();
            historys = new ObservableCollection<Inspection_History>(BD_Connection.connection.Inspection_History.ToList());

            var p = new Inspection_History();
            this.DataContext = this;
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var n = (sender as ListView).SelectedItem as Inspection_History;
            NavigationService.Navigate(new OneHistoryPage(n));
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddHistoryPage());
        }
    }

}
