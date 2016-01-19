using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay(weatherData);
            ForecastDisplay fd = new ForecastDisplay(weatherData);
            StatisticsDisplay sd = new StatisticsDisplay(weatherData);
            ThirdPartyDisplay tpd = new ThirdPartyDisplay(weatherData);
            weatherData.SetMeasurements(15, 75, 30);
            weatherData.SetMeasurements(18, 80, 31.2);
            weatherData.SetMeasurements(18, 75, 32.8);
            Console.ReadKey(true);
        }
    }
}
