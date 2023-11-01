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

namespace infinitesima
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Generate 5 unique random numbers between 1 and 59
            Random random = new Random();
            var numbers = Enumerable.Range(1, 59).OrderBy(x => random.Next()).Take(5).OrderBy(x => x).ToList();

            // Generate a bonus number
            int bonusNumber = random.Next(1, 60);

            // Display the numbers in the TextBlock
            ResultText.Text = $"Lottery Numbers: {string.Join(", ", numbers)}, Bonus Number: {bonusNumber}";
            ResultText.Foreground = Brushes.Black;
        }
    }
}
