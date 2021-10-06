using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Clouds
    {
        [Key]
        public int dbid { get; set; }
        public int all { get; set; }

        public int WeatherForecastId { get; set; }
        public virtual WeatherForecast WeatherForecast { get; set; }
    }
}