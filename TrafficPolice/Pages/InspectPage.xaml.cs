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
    /// Interaction logic for InspectPage.xaml
    /// </summary>
    public partial class InspectPage : Page
    {
        public InspectPage()
        {
            InitializeComponent();
        }

        private void Police_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PolicePage());
        }

        private void Owner_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new OwnerPage());
        }

        private void Car_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new CarPage());
        }

        private void History_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new HistoryPage());
        }

        private void techInspect_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new TechInspectPage());
        }

        private void Pass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PassPage());
        }
    }
}
