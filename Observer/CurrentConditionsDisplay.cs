using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class CurrentConditionsDisplay:Observer,DisplayElement
    {
        protected double Temperature;
        protected double Humidity;
        protected Subject WeatherData;
        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }
        public void Update(double t, double h, double p)
        {
            this.Temperature = t;
            this.Humidity = h;
            this.Display();
        }
        public void Display()
        {
            Console.WriteLine("Current conditions: "+
                this.Temperature+"C degrees and "
                +this.Humidity+"% humidity"
                );
        }
    }
}
