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

namespace ProjectoIHC
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        

        public Home()
        {
            InitializeComponent();
            googlemaps.Navigate("https://www.google.com/maps");
        }

        private void car_Click(object sender, RoutedEventArgs e)
        {
            Carro CarroPage = new Carro();
            this.NavigationService.Navigate(CarroPage);
        }

        private void fan_Click(object sender, RoutedEventArgs e)
        {
            ArCond ACPage = new ArCond();
            this.NavigationService.Navigate(ACPage);
        }

        private void phone_Click(object sender, RoutedEventArgs e)
        {
            Phone PhonePage = new Phone();
            this.NavigationService.Navigate(PhonePage);
        }

        private void music_Click(object sender, RoutedEventArgs e)
        {
            Music MusicPage = new Music();
            this.NavigationService.Navigate(MusicPage);
        }
    }
}
