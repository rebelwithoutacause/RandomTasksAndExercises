using System;
using System.IO;
using System.Text.Json;

namespace DemoAPITesting
{
    class Program
    {
        static void Main(string[] args)
        {

            WeatherForecast forecast = new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = 30,
                Summary = "Hot summer days"
            };

            string weatherInfo = JsonSerializer.Serialize(forecast);
            Console.WriteLine("Serialized JSON:\n" + weatherInfo);

            string jsonString = File.ReadAllText("C:\\Users\\User\\Desktop\\data.json");

            WeatherForecast forecastFromJson = JsonSerializer.Deserialize<WeatherForecast>(jsonString);

            Console.WriteLine("\nDeserialized Object:");
            if (forecastFromJson != null)
            {
                Console.WriteLine($"Date: {forecastFromJson.Date}");
                Console.WriteLine($"TemperatureC: {forecastFromJson.TemperatureC}");
                Console.WriteLine($"Summary: {forecastFromJson.Summary}");
            }
            else
            {
                Console.WriteLine("Deserialization failed. Object is null.");
            }
        }
    }
}

