using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Wind
    {
        [Key]
        public int dbid { get; set; }
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }

        public int WeatherForecastId { get; set; }
        public virtual WeatherForecast WeatherForecast { get; set; }
    }
}