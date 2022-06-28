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
    /// Interaction logic for AddHistoryPage.xaml
    /// </summary>
    public partial class AddHistoryPage : Page
    {
        public AddHistoryPage()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            Inspection_History history = new Inspection_History();
            history.Date_of_Passage = Convert.ToDateTime(tb_Date.Text);
            history.Result = tb_Result.Text;
            BD_Connection.connection.Inspection_History.Add(history);
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
