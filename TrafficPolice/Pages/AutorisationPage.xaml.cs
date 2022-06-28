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
    /// Interaction logic for AutorisationPage.xaml
    /// </summary>
    public partial class AutorisationPage : Page
    {
        public static ObservableCollection<User> users { get; set; }
        public AutorisationPage()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, RoutedEventArgs e)
        {
            users = new ObservableCollection<User>(BD_Connection.connection.User.ToList());
            var z = users.Where(a => a.Login == txt_login.Text && a.Password == txt_password.Password).FirstOrDefault();
            if (z != null)
            {
                StartWindow glavnaya = new StartWindow();
                glavnaya.Show();
                App.Current.MainWindow.Close();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверный", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BTN_Reg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
