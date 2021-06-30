namespace Domain
{
    public class Clouds
    {
        public int Id { get; set; }
        public int all { get; set; }

        public int WeatherForecastId { get; set; }
        public virtual WeatherForecast WeatherForecast { get; set; }
    }
}