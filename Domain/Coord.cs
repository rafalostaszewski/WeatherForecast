using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Coord
    {
        [Key]
        public int dbid { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }

        public int WeatherForecastId { get; set; }
        public virtual WeatherForecast WeatherForecast { get; set; }
    }
}