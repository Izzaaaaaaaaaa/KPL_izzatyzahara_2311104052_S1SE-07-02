using System;
using System.Collections.Generic;

namespace TPMod13_2311104052
{
    // Interface Observer
    public interface IObserver
    {
        void Update(int temperature);
    }

    // Subject (Observable)
    public class WeatherData
    {
        private List<IObserver> observers = new List<IObserver>();
        private int temperature;

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetTemperature(int value)
        {
            temperature = value;
            Notify();
        }

        private void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }

    // Concrete Observer
    public class TemperatureDisplay : IObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine($"[Display] Suhu sekarang: {temperature}°C");
        }
    }
}
