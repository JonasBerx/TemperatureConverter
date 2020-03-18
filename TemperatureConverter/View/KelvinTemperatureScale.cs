using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
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
}
