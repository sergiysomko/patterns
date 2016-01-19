using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ThirdPartyDisplay:Observer,DisplayElement
    {
        protected double Pressure;
        protected Subject WeatherData;
        public ThirdPartyDisplay(Subject weatherData)
        {
            this.WeatherData = weatherData;
            this.WeatherData.RegisterObserver(this);
        }
        public void Update(double t, double h, double p)
        {
            this.Pressure = p;
            this.Display();
        }
        public void Display()
        {
            Console.WriteLine("Pressure: "+this.Pressure);
        }
        
    }
}
