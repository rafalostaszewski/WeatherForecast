using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class WeatherForecastDbContext : DbContext
    {
        public WeatherForecastDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Clouds> Clouds { get; set; }
        public DbSet<Coord> Coord { get; set; }
        public DbSet<Main> Main { get; set; }
        public DbSet<Weather> Weather { get; set; }
        public DbSet<Rain> Rain { get; set; }
        public DbSet<Snow> Snow { get; set; }
        public DbSet<Wind> Wind { get; set; }
        public DbSet<Sys> Sys { get; set; }
        public DbSet<WeatherForecast> WeatherForecast { get; set; }

    }
}