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
    /// Interaction logic for Expenses.xaml
    /// </summary>
    public partial class Expenses : Window
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }
        public double ExpensesGiven() {

            double GroIncome = Convert.ToDouble(Tet01.Text);
            double TaxDad = Convert.ToDouble(Tet02.Text);
            double Groceries = Convert.ToDouble(Tet03.Text);
            double WatLigt = Convert.ToDouble(Tet04.Text);
            double Transport = Convert.ToDouble(Tet05.Text);
            double Cell = Convert.ToDouble(Tet06.Text);
            double Wifi = Convert.ToDouble(Tet07.Text);
            return GroIncome - (TaxDad + Groceries + WatLigt + Transport + Cell + Wifi);
        }
        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            PossessionItem possession = new PossessionItem();
            possession.NetIn.Text= ExpensesGiven().ToString();
            possession.ShowDialog();
          

        }
      
    }
}
