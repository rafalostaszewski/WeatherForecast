using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain;
using Persistence;

namespace API.Controllers
{
    public class WeatherForecastController : BaseApiController
    {
        private readonly WeatherForecastDbContext _context;
        public WeatherForecastController(WeatherForecastDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<WeatherForecast>>> GetWeatherForacast()
        {
            return await _context.WeatherForecast.ToListAsync();
        }
    }
}