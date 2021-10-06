using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain;
using Persistence;
using MediatR;
using Application.ForecastHandler;
using Application.Models;
using System;

namespace API.Controllers
{
    public class WeatherForecastController : BaseApiController
    {
        [HttpGet("actual")]
        public async Task<ActionResult<WeatherForecastDto>> GetWeatherForacastActual([FromQuery] String city)
        {
            return await Mediator.Send(new Actual.Query{City = city});
        }

        [HttpGet("history/all")]
        public async Task<ActionResult<List<WeatherForecastDto>>> GetWeatherForacastHistoryAll()
        {
            return await Mediator.Send(new History.Query());
        }

        [HttpGet("history/city")]
        public async Task<ActionResult<List<WeatherForecastDto>>> GetWeatherForacastHistoryCity([FromQuery] String city)
        {
            return await Mediator.Send(new HistoryCity.Query{City = city});
        }

        [HttpDelete("history/dbid")]
        public async Task<IActionResult> DeleteWeatherForacastHistoryId([FromQuery] int dbid)
        {
            return Ok(await Mediator.Send(new DeleteId.Query{DbId = dbid}));
        }

        [HttpDelete("history/city")]
        public async Task<IActionResult> DeleteWeatherForacastHistoryCity([FromQuery] String city)
        {
            return Ok(await Mediator.Send(new DeleteCity.Query{City = city}));
        }

        [HttpDelete("history/all")]
        public async Task<IActionResult> DetleteWeatherForacastHistoryAll()
        {
            return Ok(await Mediator.Send(new DeleteAll.Query()));
        }

        [HttpPost]
        public async Task<IActionResult> CreateForecast(WeatherForecast weatherForecast)
        {
            return Ok(await Mediator.Send(new Create.Command {WeatherForecast = weatherForecast}));
        }
    }
}