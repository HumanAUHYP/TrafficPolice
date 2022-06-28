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
    /// Interaction logic for AddInspectPage.xaml
    /// </summary>
    public partial class AddInspectPage : Page
    {
        public AddInspectPage()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            Tech_inspect_car tech_Inspect_ = new Tech_inspect_car();
            tech_Inspect_.ID_Car = Convert.ToInt32(tb_ID_Car.Text);
            tech_Inspect_.ID_Owner = Convert.ToInt32(tb_ID_Owner.Text);
            tech_Inspect_.ID_History = Convert.ToInt32(tb_ID_History.Text);
            tech_Inspect_.ID_Officer = Convert.ToInt32(tb_ID_Officer.Text);
            BD_Connection.connection.Tech_inspect_car.Add(tech_Inspect_);
            BD_Connection.connection.SaveChanges();
            MessageBox.Show("Сохранение прошло успешно");
            NavigationService.GoBack();

        }
    }
}
