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
    /// Interaction logic for AddPolicemanPage.xaml
    /// </summary>
    public partial class AddPolicemanPage : Page
    {
        public AddPolicemanPage()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            Traffic_Police_Officer officer = new Traffic_Police_Officer();
            officer.Surname = tb_Surname.Text;
            officer.Name = tb_Name.Text;
            officer.Patronymic = tb_Pathroname.Text;
            officer.Position = tb_Position.Text;
            officer.Rank = tb_Rank.Text;
            officer.ImgPolice = "img/3.jpg";
            BD_Connection.connection.Traffic_Police_Officer.Add(officer);
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
