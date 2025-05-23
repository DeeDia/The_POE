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
using System.Windows.Shapes;

namespace The_POE
{
    /// <summary>
    /// Interaction logic for RentCheck.xaml
    /// </summary>
    public partial class RentCheck : Window
    {
        public RentCheck()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            double RentMoney = Convert.ToDouble(rent.Text);

            VehicleCheck vehicle = new VehicleCheck();
            vehicle.Show();

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
