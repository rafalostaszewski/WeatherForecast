using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Weather
    {
        [Key]
        public int Dbid { get; set; }
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }

        public int WeatherForecastId { get; set; }
        public virtual WeatherForecast WeatherForecast { get; set; }
    }
}