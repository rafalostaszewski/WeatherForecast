using System.Collections.Generic;

namespace Domain
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        public virtual Coord Coord { get; set; }
        public virtual List<Weather> Weather { get; set; }
        public string @Base { get; set; }
        public virtual Main Main { get; set; }
        public virtual Rain Rain { get; set; }
        public virtual Snow Snow { get; set; }
        public int Visibility { get; set; }
        public virtual Wind Wind { get; set; }
        public virtual Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public virtual Sys Sys { get; set; }
        public int Timezone { get; set; }
        public string Name { get; set; }
    }
}