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

namespace TrafficPolice
{
    /// <summary>
    /// Interaction logic for AddCarPage.xaml
    /// </summary>
    public partial class AddCarPage : Page
    {
        public AddCarPage()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            Car car = new Car();
            car.Technical_passport_number = Convert.ToInt32(tb_Pass.Text);
            car.License_plate = tb_License_plate.Text;
            car.Engine_number = tb_Engine_number.Text;
            car.Colour = tb_Colour.Text;
            car.Car_brand = tb_Car_brand.Text;
            car.Image = "img/2.jpg";
            BD_Connection.connection.Car.Add(car);
            BD_Connection.connection.SaveChanges();
            MessageBox.Show("Сохранение прошло успешно");
            NavigationService.GoBack();

        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
