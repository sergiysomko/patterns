using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class StatisticsDisplay : Observer, DisplayElement
    {
        protected double Temperature;
        protected Subject WeatherData;
        public StatisticsDisplay(Subject weatherData)
        {
            this.WeatherData = weatherData;
            this.WeatherData.RegisterObserver(this);
        }
        public void Update(double t, double h, double p)
        {
            this.Temperature = t;
            this.Display();
        }
        public void Display()
        {
            Console.WriteLine("Avg/Min/Max: "+this.Temperature+"C");
        }
    }
}
