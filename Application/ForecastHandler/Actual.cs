using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using Application.Models;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.ForecastHandler
{
    public class Actual
    {
        public class Query : IRequest<WeatherForecastDto>
        {
            public string City { get; set; }
            public WeatherForecast WeatherForecast { get; set; }
        }

        public class Handler : IRequestHandler<Query, WeatherForecastDto>
        {
            private readonly WeatherForecastDbContext _context;
            private readonly IMapper _mapper;
            public Handler(WeatherForecastDbContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }
            public async Task<WeatherForecastDto> Handle(Query request, CancellationToken cancellationToken)
            {
                using HttpClient client = new();

                WeatherForecastDto weatherForecast = await client.GetFromJsonAsync<WeatherForecastDto>($"http://api.openweathermap.org/data/2.5/weather?q={request.City}&units=metric&appid=17d5e24a10f80fbe0ff096b025173ea4");

                var result = _mapper.Map<WeatherForecast>(weatherForecast);
                _context.WeatherForecast.Add(result);
                _context.SaveChanges();

                return weatherForecast;
            }
        }
    }
}