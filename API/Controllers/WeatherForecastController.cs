using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain;
using Persistence;
using MediatR;
using Application.Weather;

namespace API.Controllers
{
    public class WeatherForecastController : BaseApiController
    {
        [HttpGet("history")]
        public async Task<ActionResult<List<WeatherForecast>>> GetWeatherForacastHistory()
        {
            return await Mediator.Send(new History.Query());
        }
    }
}