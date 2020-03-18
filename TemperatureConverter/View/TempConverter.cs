using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface ITemperatureScale
    {
        string Name { get; }

        double ConvertToKelvin(double temperature);
        double ConvertFromKelvin(double temperature);

        

    }

    class KelvinTemperatureScale : ITemperatureScale
    {
        public string Name => "Kelvin";

        public double ConvertFromKelvin(double temperature)
        {
            return temperature;
        }

        public double ConvertToKelvin(double temperature)
        {
            return temperature;
        }
    }

    class CelsiusTemperatureScale : ITemperatureScale
    {
        public string Name => "Kelvin"

        public double ConvertFromKelvin(double temperature)
        {
            return temperature - 273.15;
        }

        public double ConvertToKelvin(double temperature)
        {
            return temperature + 273.15;
        }
    }

    class FahrenheitTemperatureScale : ITemperatureScale
    {
        public string Name => "Fahrenheit";

        public double ConvertFromKelvin(double temperature)
        {
            return temperature * 1.8 - 459.67;
        }

        public double ConvertToKelvin(double temperature)
        {
            return (temperature + 549.67) / 1.8;
        }
    }
}
