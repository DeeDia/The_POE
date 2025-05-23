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
    /// Interaction logic for PropCheck.xaml
    /// </summary>
    public partial class PropCheck : Window
    {
        public PropCheck()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double totDeposit = Convert.ToDouble(box02.Text);
            
              
        }
        public abstract class Expensses
        {
            public double purchasePrice { get; set; }
            public double totDeposit { get; set; }
            public double interestRate { get; set; }
            public double monthPayment { get; set; }

            public abstract double Calculations();
            public abstract double Approval(double GroIncome);

        }
        public class HouseProperty : Expensses
        {
            public override double Calculations()
            {
                //getting the monthly payment that will be done by the buyer
                //inte../100
                double monthPay = ((purchasePrice * (1 + (Math.Round((interestRate / 100), 3) * (monthPayment) / 12))) / monthPayment);
                return monthPay;

            }
            public override double Approval(double netIn)
            {
                //getting the 1/3 of the gross monthly
                double sum = netIn / 3;
                return sum;
            }

        }
         class Rental
    {
        public double rentalMonth { get; set; }
       
    }



        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            double purchasePrice = Convert.ToDouble(box01.Text);
            double totDeposit = Convert.ToDouble(box02.Text);
            double interestRate = Convert.ToDouble(box03.Text);
            double monthPayment = Convert.ToDouble(box04.Text);

            // purchasePrice * (1 + (Math.Round((interestRate / 100), 3) * (monthPayment) / 12)) / monthPayment;

            //getting the 1/3 of the gross monthly
            double sum = NetIn / 3;
            return sum;

            MessageBox.Show("***********************************************\n" +
                                      "STANDALONE COMMAND-LINE (Home Loan) \n" +
                                      "***********************************************\n" +
                                      "PURCHASE PRICE :" + purchasePrice + "\n" +
                                      "TOTAL DEPOSIT :" + totDeposit + "\n" +
                                      "INTEREST RATE :" + interestRate + "\n" +
                                      "MONTHLY PAYMENT :" + monthPayment + "\n" +
                                      "***********************************************\n");
            PossessionItem possession = new PossessionItem();
            possession.NetIn.Text = ExpensesGiven().ToString();
            possession.ShowDialog();

            if (monthPayment >= NetIn)
            {
                MessageBox.Show("Home Loan is not approved");

            }
            else
            {
                MessageBox.Show("You qualify for a Home Loan property !!");
            }


        }

            private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            //System.Environment.Exit(0);
            Expenses ep= new Expenses();
            ep.Tet01.Text = 20.ToString();
            ep.ShowDialog();
        }
    }
}
