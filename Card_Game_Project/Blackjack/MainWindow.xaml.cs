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

namespace Blackjack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnHit.IsEnabled = false;
            btnStay.IsEnabled = false;

            
        }

        private void btnDeal_Click(object sender, RoutedEventArgs e)
        {
            btnHit.IsEnabled = true;
            btnStay.IsEnabled = true;
            btnDeal.IsEnabled = false;
        }

        private void btnHit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStay_Click(object sender, RoutedEventArgs e)
        {
            btnHit.IsEnabled = false;
            btnStay.IsEnabled = false;
            btnDeal.IsEnabled = true;
        }
    }
}
