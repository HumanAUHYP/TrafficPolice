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
    /// Interaction logic for OneCarPage.xaml
    /// </summary>
    public partial class OneCarPage : Page
    {
        public static ObservableCollection<Car> cars { get; set; }
        public OneCarPage(Car n)
        {
            InitializeComponent();
            tb_License_plate.Text = n.License_plate;
            tb_Engine_number.Text = n.Engine_number;
            tb_Colour.Text = n.Colour;
            tb_Car_brand.Text = n.Car_brand;
            img_Car.Source = new BitmapImage(new Uri(n.Image, UriKind.RelativeOrAbsolute));
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
