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
    /// Interaction logic for VehicleCheck.xaml
    /// </summary>
    public partial class VehicleCheck : Window
    {
        public VehicleCheck()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            GraphView graph = new GraphView();
            graph.Show();

        }
    }
}
