using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
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

namespace TrafficPolice
{
    /// <summary>
    /// Interaction logic for OneHistoryPage.xaml
    /// </summary>
    public partial class OneHistoryPage : Page
    {
        public static ObservableCollection<Inspection_History> historys { get; set; }
        public OneHistoryPage(Inspection_History n)
        {
            InitializeComponent();
            tb_ID_History.Text = Convert.ToString(n.ID_History);
            tb_Date.Text = (Convert.ToString(n.Date_of_Passage).Split(' '))[0];
            tb_Result.Text = n.Result;

        }
        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_red_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
