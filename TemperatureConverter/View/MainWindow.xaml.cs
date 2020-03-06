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

namespace View
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

        private void ConvertToCelcius(object sender, RoutedEventArgs e)
        {
            var fahr = double.Parse(textBox.Text);


            var cels = (fahr - 32) * 5 / 9;

            Console.Write(cels);
            textBox.Text =cels.ToString();
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            var cels = double.Parse(textBox.Text);


            var fahr = (cels * 9) / 5 + 32;

            Console.Write(fahr);
            textBox.Text = fahr.ToString();
        }
    }
}
