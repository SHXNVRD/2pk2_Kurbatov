using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace pz_25
{
    public partial class MainWindow : Window
    {
        double firstNumber, result;
        string operation;

        public MainWindow() 
        {
            InitializeComponent();

        }

        //private void NegativeButtonClick(object sender, RoutedEventArgs e)
        //{
        //    if (double.TryParse(resultLabel.Content.ToString(), out firstNumber))
        //    {
        //        firstNumber = firstNumber * -1;
        //        textBoxResult = firstNumber.ToString();
        //    }
        //}

        //private void DeleteButtonClick(object sender, RoutedEventArgs e)
        //{
        //    if (resultLabel.Content.ToString() != "")
        //        resultLabel.Content = resultLabel.Content = "";
        //}

        private void PointButtonClick(object sender, RoutedEventArgs e)
        {
            //if (!resultLabel.Content.ToString().Contains("."))
            //    resultLabel.Content = $"{resultLabel.Content}.";
        }

        private void CButtonClick(object sender, RoutedEventArgs e)
        {
            if (textBoxResult.ToString() != "")
                textBoxResult.Text = "";
        }

        private void EqualButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void OperationButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void NegativeButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {

        }

        //private void EqualButtonClick(object sender, RoutedEventArgs e)
        //{
        //    double secondNumber;

        //    if (double.TryParse(resultLabel.Content.ToString(), out secondNumber))
        //    {
        //        switch (operation)
        //        {
        //            case "+":
        //                result = firstNumber + secondNumber;
        //                break;
        //            case "-":
        //                result = firstNumber - secondNumber;
        //                break;
        //            case "*":
        //                result = firstNumber * secondNumber;
        //                break;
        //            case "/":
        //                if (secondNumber != 0)
        //                    result = firstNumber / secondNumber;
        //                else
        //                    MessageBox.Show("Делить на ноль нельзя!(Вообще можно, но не в этом случае)", "неверная операция", MessageBoxButton.OK, MessageBoxImage.Error);
        //                break;
        //            case "%":
        //                operation = "%";
        //                result = firstNumber / 100 * secondNumber;
        //                break;
        //            case "^":
        //                operation = "^";
        //                result = Math.Pow(firstNumber, secondNumber);
        //                break;
        //            default:
        //                break;
        //        }

        //        resultLabel.Content = result.ToString();
        //    }
        //}

        private void NumberButtonClick(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            textBoxResult.Text += str;
        }
    }
}
