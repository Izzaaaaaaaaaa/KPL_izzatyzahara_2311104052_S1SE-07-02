using System;
using TPMod13_2311104052;

class Program
{
    static void Main(string[] args)
    {
        WeatherData weather = new WeatherData();
        TemperatureDisplay display = new TemperatureDisplay();

        weather.Attach(display);

        weather.SetTemperature(30);  // Output: [Display] Suhu sekarang: 30°C
        weather.SetTemperature(35);  // Output: [Display] Suhu sekarang: 35°C
    }
}
