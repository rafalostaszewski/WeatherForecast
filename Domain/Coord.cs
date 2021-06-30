namespace Domain
{
    public class Coord
    {
        public int Id { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }

        public int WeatherForecastId { get; set; }
        public virtual WeatherForecast WeatherForecast { get; set; }
    }
}