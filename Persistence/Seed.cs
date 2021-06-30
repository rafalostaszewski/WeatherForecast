using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(WeatherForecastDbContext context)
        {
            if (context.WeatherForecast.Any()) return;

            var weatherForecast = new List<WeatherForecast>
            {
                new WeatherForecast
                {
                    Coord = new Coord()
                    {
                        lon = 22.3647D,
                        lat = 53.8282D,
                    },
                    Weather = new List<Weather>()
                    {
                        new Weather()
                        {
                            id = 23,
                            main = "Clouds",
                            description = "few clouds",
                            icon = "02d"
                        },
                    },
                    @Base = "stations",
                    Main = new Main()
                    {
                        temp = 21,
                        feels_like = 30,
                        temp_min = 12,
                        temp_max = 23,
                        pressure = 234,
                        humidity =43,
                        sea_level = 23,
                        grnd_level = 53,
                    },
                    Visibility = 50,
                    Wind = new Wind()
                    {
                        speed = 1233,
                        deg = 32,
                        gust = 123,
                    },
                    Rain = new Rain()
                    {
                        h1 = 50,
                    },
                    Snow = new Snow()
                    {
                        h1 = 50,
                    },
                    Clouds = new Clouds()
                    {
                        all = 80,
                    },
                    Dt = 1617632101,
                    Sys = new Sys()
                    {
                        country = "PL",
                        sunrise = 1233,
                        sunset = 423,
                    },
                    Timezone = 7200,
                    Name = "Krakow",
                },
                new WeatherForecast
                {
                    Coord = new Coord()
                    {
                        lon = 22.3647D,
                        lat = 53.8282D,
                    },
                    Weather = new List<Weather>()
                    {
                        new Weather()
                        {
                            id = 23,
                            main = "Clouds",
                            description = "few clouds",
                            icon = "02d"
                        },
                    },
                    @Base = "stations",
                    Main = new Main()
                    {
                        temp = 21,
                        feels_like = 30,
                        temp_min = 12,
                        temp_max = 23,
                        pressure = 234,
                        humidity =43,
                        sea_level = 23,
                        grnd_level = 53,
                    },
                    Visibility = 50,
                    Wind = new Wind()
                    {
                        speed = 1233,
                        deg = 32,
                        gust = 123,
                    },
                    Rain = new Rain()
                    {
                        h1 = 50,
                    },
                    Snow = new Snow()
                    {
                        h1 = 50,
                    },
                    Clouds = new Clouds()
                    {
                        all = 80,
                    },
                    Dt = 1617632101,
                    Sys = new Sys()
                    {
                        country = "PL",
                        sunrise = 1233,
                        sunset = 423,
                    },
                    Timezone = 7200,
                    Name = "London",
                },
                new WeatherForecast
                {
                    Coord = new Coord()
                    {
                        lon = 22.3647D,
                        lat = 53.8282D,
                    },
                    Weather = new List<Weather>()
                    {
                        new Weather()
                        {
                            id = 23,
                            main = "Clouds",
                            description = "few clouds",
                            icon = "02d"
                        },
                    },
                    @Base = "stations",
                    Main = new Main()
                    {
                        temp = 21,
                        feels_like = 30,
                        temp_min = 12,
                        temp_max = 23,
                        pressure = 234,
                        humidity =43,
                        sea_level = 23,
                        grnd_level = 53,
                    },
                    Visibility = 50,
                    Wind = new Wind()
                    {
                        speed = 1233,
                        deg = 32,
                        gust = 123,
                    },
                    Rain = new Rain()
                    {
                        h1 = 50,
                    },
                    Snow = new Snow()
                    {
                        h1 = 50,
                    },
                    Clouds = new Clouds()
                    {
                        all = 80,
                    },
                    Dt = 1617632101,
                    Sys = new Sys()
                    {
                        country = "PL",
                        sunrise = 1233,
                        sunset = 423,
                    },
                    Timezone = 7200,
                    Name = "Warsaw",
                },
            };

            await context.WeatherForecast.AddRangeAsync(weatherForecast);
            await context.SaveChangesAsync();
        }
    }
}