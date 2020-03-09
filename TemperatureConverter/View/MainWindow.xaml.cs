using System;
using System.Collections.Generic;
using System.Globalization;
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

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            var cels = double.Parse(celsiusTextBox.Text);


            var fahr = (cels * 9 / 5) + 32;
            var kelv = cels + 273.15;

            fahrenheitTextBox.Text = fahr.ToString();
            kelvinTextBox.Text = kelv.ToString();
            
            
        }
        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            var fahr = double.Parse(fahrenheitTextBox.Text);
            var cels = (fahr - 32) * 5 / 9;
            var kelv = (fahr + 459.67) * 5 / 9;

            celsiusTextBox.Text = cels.ToString();
            kelvinTextBox.Text = kelv.ToString();
        }
        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            var kelv = double.Parse(kelvinTextBox.Text);
            var cels = kelv - 273.15;
            var fahr = (kelv - 273.15) * 9 / 5 + 32;

            celsiusTextBox.Text = cels.ToString();
            fahrenheitTextBox.Text = fahr.ToString();
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var value = sliderValue.Value; //In kelvin scale


            
            var fahr = (value - 273.15) * 9 / 5 + 32;
            
            fahrenheitTextBox.Text = fahr.ToString();
        }

        public class CelsiusConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                var kelvin = (double)value;
                var celsius = kelvin - 273.15;

                
                return celsius.ToString();

            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                var celsius = double.Parse((string)value);
                var kelvin = celsius + 273.15;

                return kelvin;
            }
        }

    }
    
}
