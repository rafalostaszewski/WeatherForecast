namespace Domain
{
    public class Rain
    {
        public int Id { get; set; }
        public int h1 { get; set; }
        public int h3 { get; set; }

        public int WeatherForecastId { get; set; }
        public virtual WeatherForecast WeatherForecast { get; set; }
    }
}