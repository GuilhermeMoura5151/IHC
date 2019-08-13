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
    /// Interaction logic for ArCond.xaml
    /// </summary>
    public partial class ArCond : Page
    {
        Boolean i = false;
        public ArCond()
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

            if (s=="Turn ON")
            {
                mais.IsEnabled = true;
                menos.IsEnabled = true;
                mais.Opacity=100;
                menos.Opacity = 100;
                label2.Opacity = 100;
                simbolo.Opacity = 100;
                button2.Content = "Turn OFF";
            }
            
            if(s=="Turn OFF")
            {
                mais.IsEnabled = false;
                menos.IsEnabled = false;
                mais.Opacity = 0.5;
                menos.Opacity = 0.5;
                label2.Opacity = 0.5;
                simbolo.Opacity = 0.5;
                button2.Content = "Turn ON";

            }

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Home Homepage = new Home();
            this.NavigationService.Navigate(Homepage);
        }

        private void car_Click(object sender, RoutedEventArgs e)
        {
            Carro Carropage = new Carro();
            this.NavigationService.Navigate(Carropage);
        }

        private void fundo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Home Homepage = new Home();
            this.NavigationService.Navigate(Homepage);
        }

        private void cabeça_Click(object sender, RoutedEventArgs e)
        {

            if (i == false)
            {
                cima.Source = new BitmapImage(new Uri("imagens/greenball.png", UriKind.Relative));
                i = true;
            }
            else
            {
                cima.Source = new BitmapImage(new Uri("imagens/redball.png", UriKind.Relative));
                i = false;
            }
        }

        private void pes_Click(object sender, RoutedEventArgs e)
        {
            if (i == false)
            {
                baixo.Source = new BitmapImage(new Uri("imagens/greenball.png", UriKind.Relative));
                i = true;
            }
            else
            {
                baixo.Source = new BitmapImage(new Uri("imagens/redball.png", UriKind.Relative));
                i = false;
            }
        }

        private void ambos_Click(object sender, RoutedEventArgs e)
        {
            if (i == false)
            {
                todo.Source = new BitmapImage(new Uri("imagens/greenball.png", UriKind.Relative));
                i = true;
            }
            else
            { todo.Source = new BitmapImage(new Uri("imagens/redball.png", UriKind.Relative));
                i = false;
            }
        }

        private void phone_Click(object sender, RoutedEventArgs e)
        {
            Phone Phonepage = new Phone();
            this.NavigationService.Navigate(Phonepage);
        }

        private void music_Click(object sender, RoutedEventArgs e)
        {
            Music Musicpage = new Music();
            this.NavigationService.Navigate(Musicpage);
        }

        private void fan_Click(object sender, RoutedEventArgs e)
        {
            Home Homepage = new Home();
            this.NavigationService.Navigate(Homepage);
        }

        private void ac_Click(object sender, RoutedEventArgs e)
        {
            if (i == false)
            {
                acbola.Source = new BitmapImage(new Uri("imagens/greenball.png", UriKind.Relative));
                i = true;
            }
            else
            {
                acbola.Source = new BitmapImage(new Uri("imagens/redball.png", UriKind.Relative));
                i = false;
            }
        }
    }
}
