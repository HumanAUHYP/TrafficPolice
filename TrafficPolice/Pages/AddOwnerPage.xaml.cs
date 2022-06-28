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
    /// Interaction logic for AddOwnerPage.xaml
    /// </summary>
    public partial class AddOwnerPage : Page
    {
        public AddOwnerPage()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            Owner owner = new Owner();
            owner.Surname = tb_Surname.Text;
            owner.Name = tb_Name.Text;
            owner.Patronymic = tb_Pathroname.Text;
            owner.Place_of_Residence = tb_Place.Text;
            owner.Year_of_Birth = Convert.ToDateTime(tb_Birth.Text);
            owner.ImgOwner = "img/01.jpg";
            //owner.Gender = Convert.ToBoolean(tb_Gender.Text);
            if (tb_Gender.Text == "Мужчина")
            {
                owner.Gender = true;
            }
            else
            {
                owner.Gender = false;
            }
            BD_Connection.connection.Owner.Add(owner);
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
