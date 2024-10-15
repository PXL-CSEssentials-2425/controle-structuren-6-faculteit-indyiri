using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H3Oef6Faculteit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            numberTextBox.Text = "1";
            numberTextBox.Focus();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int number;
            int factorial = 1;
            string inputNumber = numberTextBox.Text;

            bool isInputNumberValid = int.TryParse(inputNumber, out number);

            if (isInputNumberValid )
            {
                for ( int x = 1; x <= number; x++)
                {
                    factorial *= x;
                }
                resultTextBox.Text = $"{factorial}";
            }
            else if (isInputNumberValid == false)
            {
                resultTextBox.Text = "Geef een geldig geheel getal in";
            }
        }
    }
}