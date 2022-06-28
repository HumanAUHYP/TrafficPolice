using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TrafficPolice
{
    /// <summary>
    /// Interaction logic for OneInspectPage.xaml
    /// </summary>
    public partial class OneInspectPage : Page
    {
        public static ObservableCollection<Tech_inspect_car> inspects { get; set; }
        public OneInspectPage(Tech_inspect_car n)
        {
            InitializeComponent();
            tb_ID_inspect.Text = Convert.ToString(n.ID_inspect);
            tb_ID_Car.Text = Convert.ToString(n.ID_Car);
            tb_ID_Owner.Text = Convert.ToString(n.ID_Owner);
            tb_ID_History.Text = Convert.ToString(n.ID_History);
            tb_ID_Officer.Text = Convert.ToString(n.ID_Officer);
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
