using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class FahrenheitTemperatureScale : ITemperatureScale
    {
        public string Name => "Fahrenheit";

        public double ConvertFromKelvin(double temperature)
        {
            var fahrenheit = temperature * 1.8 - 459.67;
            return fahrenheit;
        }

        public double ConvertToKelvin(double temperature)
        {
            var kelvin = (temperature + 459.67) / 1.8;
            return kelvin;

        }
    }
}
