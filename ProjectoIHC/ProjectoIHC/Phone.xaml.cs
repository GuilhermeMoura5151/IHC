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
    /// Interaction logic for Phone.xaml
    /// </summary>
    public partial class Phone : Page
    {
        public Phone()
        {
            InitializeComponent();
        }

        private void fan_Click(object sender, RoutedEventArgs e)
        {
            ArCond ACPage = new ArCond();
            this.NavigationService.Navigate(ACPage);
        }

        private void fechar_Click(object sender, RoutedEventArgs e)
        {
            Home HomePage = new Home();
            this.NavigationService.Navigate(HomePage);
        }

        private void ListBoxItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            textBox.Text = list1.Content.ToString();
        }

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void asterisco_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "*";
        }

        private void num0_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void cardinal_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "#";
        }

        private void music_Click(object sender, RoutedEventArgs e)
        {
            Music MusicPage = new Music();
            this.NavigationService.Navigate(MusicPage);
        }


        private void fundo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Home HomePage = new Home();
            this.NavigationService.Navigate(HomePage);
        }

        private void ListBoxItem_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            textBox.Text = list2.Content.ToString();
        }

        private void ligar_Click(object sender, RoutedEventArgs e)
        {
            PhoneCall CallPage = new PhoneCall();
            if (textBox.Text!=null) this.NavigationService.Navigate(CallPage);
        }

        private void car_Click(object sender, RoutedEventArgs e)
        {
            Carro Carropage = new Carro();
            this.NavigationService.Navigate(Carropage);
        }
    }
}
