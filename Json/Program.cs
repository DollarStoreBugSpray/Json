using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Text.Json;

namespace SerializeBasic
{
    // <wf>
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }
    // </wf>

    public class Program
    {
        public static void Main()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            var phoenixForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2022-03-22"),
                TemperatureCelsius = 28,
                Summary = "Warm"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);

            Console.WriteLine(jsonString);

            string phoenixeString = JsonSerializer.Serialize(phoenixForecast);

            Console.WriteLine(phoenixeString);

            WeatherForecast w = JsonSerializer.Deserialize<WeatherForecast>(phoenixeString);
            WriteLine(w.Summary);

            ReadKey();
        }

    }

}
// output:
//{"Date":"2019-08-01T00:00:00-07:00","TemperatureCelsius":25,"Summary":"Hot"}
// </all>
