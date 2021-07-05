using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain;
using Persistence;
using MediatR;
using Application.ForecastHandler;
using Application.Models;

namespace API.Controllers
{
    public class WeatherForecastController : BaseApiController
    {
        [HttpGet("history")]
        public async Task<ActionResult<List<WeatherForecastDto>>> GetWeatherForacastHistory()
        {
            return await Mediator.Send(new History.Query());
        }

        [HttpPost]
        public async Task<IActionResult> CreateForecast(WeatherForecast weatherForecast)
        {
            return Ok(await Mediator.Send(new Create.Command {WeatherForecast = weatherForecast}));
        }
    }
}