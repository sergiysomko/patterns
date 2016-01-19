using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ForecastDisplay:Observer,DisplayElement
    {
        //protected double Temperature;
        //protected double Humidity;
        //protected double Pressure;
        protected Subject WeatherData;
        public ForecastDisplay(Subject weatherData)
        {
            this.WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }
        public void Update(double t, double h, double p)
        {
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Forecast: maybe sun, or rain");
        }
        
    }
}
