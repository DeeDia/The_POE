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
    /// Interaction logic for PossessionItem.xaml
    /// </summary>
    public partial class PossessionItem : Window
    {
        public PossessionItem()
        {
            InitializeComponent();
        }

        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            

        }
        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (Accomodation.IsChecked  == true)
            {
                RentCheck Accom = new RentCheck();
                Accom.ShowDialog();
                this.Hide();

            }
            else if (House.IsChecked == true)
            {
                PropCheck house = new PropCheck();
                house.Show();
                this.Hide();

            }
            else if (Vehicle.IsChecked == true)
            {
                VehicleCheck vehicle = new VehicleCheck();
                vehicle.Show();
                this.Hide();

            }

            //PropCheck expecWind = new PropCheck();
            //expecWind.Show();
        }

            private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
