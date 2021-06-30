namespace Domain
{
    public class Sys
    {
        public int Id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }

        public int WeatherForecastId { get; set; }
        public virtual WeatherForecast WeatherForecast { get; set; }
    }
}