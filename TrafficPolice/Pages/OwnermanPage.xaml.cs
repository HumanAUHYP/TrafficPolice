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
    /// Interaction logic for OwnermanPage.xaml
    /// </summary>
    public partial class OwnermanPage : Page
    {
        public static ObservableCollection<Owner> owners { get; set; }
        public OwnermanPage(Owner n)
        {
            InitializeComponent();
            tb_Surname.Text = n.Surname;
            tb_Name.Text = n.Name;
            tb_Pathroname.Text = n.Patronymic;
            tb_Place.Text = n.Place_of_Residence;
            tb_Gender.DataContext = n.Gender;
            if (n.Gender == true)
            {
                tb_Gender.Text = "Мужчина";
            }
            else
            {
                tb_Gender.Text = "Женщина";
            }
            tb_Birth.Text = (Convert.ToString(n.Year_of_Birth).Split(' '))[0];

            img_Owner.Source = new BitmapImage(new Uri(n.ImgOwner, UriKind.RelativeOrAbsolute));
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

		private void btn_excel_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
