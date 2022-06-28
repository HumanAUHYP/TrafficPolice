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
    /// Interaction logic for NewPassPage.xaml
    /// </summary>
    public partial class NewPassPage : Page
    {
        public NewPassPage()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            Technical_Passport technical_Passport = new Technical_Passport();
            technical_Passport.Technical_passport_number = Convert.ToInt32(tb_NumPass.Text);
            technical_Passport.ID_Owner = Convert.ToInt32(tb_ID_Owner.Text);
            BD_Connection.connection.Technical_Passport.Add(technical_Passport);
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
