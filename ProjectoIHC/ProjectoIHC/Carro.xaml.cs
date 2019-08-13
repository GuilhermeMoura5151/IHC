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
    /// Interaction logic for Carro.xaml
    /// </summary>
    public partial class Carro : Page
    {
        public Carro()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string s = label2.Content.ToString();
            int i = Convert.ToInt32(s);
            i = i + 1;
            label2.Content = i.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string s = label2.Content.ToString();
            int i = Convert.ToInt32(s);
            i = i - 1;
            label2.Content = i.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string s = button2.Content.ToString();

            if (s == "Turn ON")
            {
                mais.IsEnabled = true;
                menos.IsEnabled = true;
                mais.Opacity = 100;
                menos.Opacity = 100;
                label2.Opacity = 100;
                velocidade.Opacity = 100;
                button2.Content = "Turn OFF";
            }

            if (s == "Turn OFF")
            {
                mais.IsEnabled = false;
                menos.IsEnabled = false;
                mais.Opacity = 0.5;
                menos.Opacity = 0.5;
                label2.Opacity = 0.5;
                velocidade.Opacity = 0.5;
                button2.Content = "Turn ON";

            }
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

        private void fechar_Click(object sender, RoutedEventArgs e)
        {
            Home HomePage = new Home();
            this.NavigationService.Navigate(HomePage);
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Tablier TablierPage = new Tablier();
            this.NavigationService.Navigate(TablierPage);
        }

        private void music_Click(object sender, RoutedEventArgs e)
        {
            Music MusicPage = new Music();
            this.NavigationService.Navigate(MusicPage);
        }

        private void car_Click(object sender, RoutedEventArgs e)
        {
            Home HomePage = new Home();
            this.NavigationService.Navigate(HomePage);
        }

        private void fundo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Home HomePage = new Home();
            this.NavigationService.Navigate(HomePage);
        }
    }
}
