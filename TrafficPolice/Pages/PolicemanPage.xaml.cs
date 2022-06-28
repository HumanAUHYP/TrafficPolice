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
    /// Interaction logic for PolicemanPage.xaml
    /// </summary>
    public partial class PolicemanPage : Page
    {
        public static ObservableCollection<Traffic_Police_Officer> polices { get; set; }
        public PolicemanPage(Traffic_Police_Officer n)
        {
            InitializeComponent();
            tb_Surname.Text = n.Surname;
            tb_Name.Text = n.Name;
            tb_Pathroname.Text = n.Patronymic;
            tb_Position.Text = n.Position;
            tb_Rank.Text = n.Rank;
            img_Sotr.Source = new BitmapImage(new Uri(n.ImgPolice, UriKind.RelativeOrAbsolute));

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
