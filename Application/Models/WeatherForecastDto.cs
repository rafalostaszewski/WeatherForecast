using System.Collections.Generic;
using Domain;

namespace Application.Models
{
    public class WeatherForecastDto
    {
        public int id { get; set; }
        public CoordDto coord { get; set; }
        public List<WeatherDto> weather { get; set; }
        public string @base { get; set; }
        public MainDto main { get; set; }
        public RainDto rain { get; set; }
        public SnowDto snow { get; set; }
        public int visibility { get; set; }
        public WindDto wind { get; set; }
        public CloudsDto clouds { get; set; }
        public int dt { get; set; }
        public SysDto sys { get; set; }
        public int timezone { get; set; }
        public string name { get; set; }
    }
}