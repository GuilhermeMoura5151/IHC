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
    /// Interaction logic for PhoneCall.xaml
    /// </summary>
    public partial class PhoneCall : Page
    {
        public PhoneCall()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Phone PhonePage = new Phone();
            this.NavigationService.Navigate(PhonePage);
        }


    }
}
