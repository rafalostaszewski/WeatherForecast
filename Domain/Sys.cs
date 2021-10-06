using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Sys
    {
        [Key]
        public int dbid { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }

        public int WeatherForecastId { get; set; }
        public virtual WeatherForecast WeatherForecast { get; set; }
    }
}