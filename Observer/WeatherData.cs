using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class WeatherData:Subject
    {
        private double Temperature;
        private double Humidity;
        private double Pressure;
        protected List<Observer> Observers;
        public WeatherData()
        {
            this.Observers = new List<Observer>();
        }
        public void RegisterObserver(Observer o)
        {
            this.Observers.Add(o);
        }
        public void RemoveObserver(Observer o)
        {
            int index = this.Observers.IndexOf(o);
            if (index >= 0)
                this.Observers.RemoveAt(index);
        }
        public void NotifyObserver()
        {
            for (int i = 0; i < Observers.Count; i++)
            {
                Observer o = Observers[i];
                o.Update(this.Temperature, this.Humidity, this.Pressure);
                
            }
        }
        public void MeasurementsChanged()
        {
            this.NotifyObserver();  
        }
        public void SetMeasurements(double t, double h, double p)
        {
            this.Temperature = t;
            this.Humidity = h;
            this.Pressure = p;
            this.MeasurementsChanged();            
        }

        public double GetTemperature()
        {
            return Temperature;
        }
        public double GetHumidity()
        {
            return Humidity;
        }
        public double GetPressure()
        {
            return Pressure;    
        }
    }
}
