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
using System.Media;

namespace ProjectoIHC
{
    /// <summary>
    /// Interaction logic for Music.xaml
    /// </summary>
    /// 
    public partial class Music : Page
    {
      
        MediaPlayer playsom = new MediaPlayer();
        Uri uri = new Uri("sons/Blackened.mp3", UriKind.Relative);
        
        public Music()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            button.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Visible;
            

            playsom.Open(uri);
            playsom.Play();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            button.Visibility = Visibility.Visible;
            button5.Visibility = Visibility.Hidden;

        
            playsom.Stop();
        }

        private void fechar_Click(object sender, RoutedEventArgs e)
        {
            Home Homepage = new Home();
            this.NavigationService.Navigate(Homepage);
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

        private void fundo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Home Homepage = new Home();
            this.NavigationService.Navigate(Homepage);
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            player.Source = new BitmapImage(new Uri("imagens/player2.png", UriKind.Relative));
        }

        private void TabItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            albuns.Visibility = Visibility.Visible;
        }

        private void comercial_Click(object sender, RoutedEventArgs e)
        {
           radio.Source = new BitmapImage(new Uri("imagens/radiocomer.png", UriKind.Relative));
            sintonia.Value = 97.4;
        }

        private void rfm_Click(object sender, RoutedEventArgs e)
        {
            radio.Source = new BitmapImage(new Uri("imagens/radiorfm.png", UriKind.Relative));
            sintonia.Value = 106.8;
        }



        private void TabItem_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            radioset.Visibility = Visibility.Visible;
            albuns.Visibility = Visibility.Hidden;
            musicas.Visibility = Visibility.Hidden;
        }

        private void TabItem_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            radioset.Visibility = Visibility.Hidden;
            albuns.Visibility = Visibility.Visible;
            musicas.Visibility = Visibility.Hidden;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            player.Source = new BitmapImage(new Uri("imagens/player2.png", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            player.Source = new BitmapImage(new Uri("imagens/player.png", UriKind.Relative));
        }

        private void TabItem_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            radioset.Visibility = Visibility.Hidden;
            albuns.Visibility = Visibility.Hidden;
            musicas.Visibility = Visibility.Visible;
        }

        private void car_Click(object sender, RoutedEventArgs e)
        {
            Carro Carropage = new Carro();
            this.NavigationService.Navigate(Carropage);
        }
    }
}
