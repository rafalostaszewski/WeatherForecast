using System.Collections.Generic;
using System.Linq;
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
    public class HistoryCity
    {
        public class Query : IRequest<List<WeatherForecastDto>>
        {
            public string City { get; set; }
        }
        public class Handler : IRequestHandler<Query, List<WeatherForecastDto>>
        {
            private readonly WeatherForecastDbContext _context;
            private readonly IMapper _mapper;
            public Handler(WeatherForecastDbContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<List<WeatherForecastDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var weatherForecast = await _context
                    .WeatherForecast
                    .Where(w => w.Name == request.City)
                    .Include(w => w.Clouds)
                    .Include(w => w.Coord)
                    .Include(w => w.Main)
                    .Include(w => w.Rain)
                    .Include(w => w.Snow)
                    .Include(w => w.Sys)
                    .Include(w => w.Weather)
                    .Include(w => w.Wind)
                    .ToListAsync();

                var result = _mapper.Map<List<WeatherForecastDto>>(weatherForecast);

                return result;
            }
        }
    }
}