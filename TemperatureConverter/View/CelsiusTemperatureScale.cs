using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class CelsiusTemperatureScale : ITemperatureScale
    {
        public string Name => "Celsius";

        public double ConvertFromKelvin(double temperature)
        {
            var celsius = temperature - 273.15;
            return celsius;
        }

        public double ConvertToKelvin(double temperature)
        {
            var kelvin = temperature + 273.15;
            return kelvin;
        }
    }
}
