namespace View
{
    public interface ITemperatureScale
    {

        string Name { get; }

        double ConvertToKelvin(double temp);
        double ConvertFromKelvin(double temp);
    }

    class KelvinTemperatureScale : ITemperatureScale
    {
        public string Name => throw new System.NotImplementedException();

        public double ConvertFromKelvin(double temp)
        {
            throw new System.NotImplementedException();
        }

        public double ConvertToKelvin(double temp)
        {
            throw new System.NotImplementedException();
        }
    }

    class FahrenheitTemperatureScale : ITemperatureScale
    {
        public string Name => throw new System.NotImplementedException();

        public double ConvertFromKelvin(double temp)
        {
            throw new System.NotImplementedException();
        }

        public double ConvertToKelvin(double temp)
        {
            throw new System.NotImplementedException();
        }
    }

    class CelsiusTemperatureScale : ITemperatureScale
    {
        public string Name => throw new System.NotImplementedException();

        public double ConvertFromKelvin(double temp)
        {
            throw new System.NotImplementedException();
        }

        public double ConvertToKelvin(double temp)
        {
            throw new System.NotImplementedException();
        }
    }
}