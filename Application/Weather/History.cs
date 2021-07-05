using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Weather
{
    public class History
    {
        public class Query : IRequest<List<WeatherForecast>> {}

        public class Handler : IRequestHandler<Query, List<WeatherForecast>>
        {
            private readonly WeatherForecastDbContext _context;
            public Handler(WeatherForecastDbContext context)
            {
                _context = context;
            }

            public async Task<List<WeatherForecast>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.WeatherForecast.ToListAsync();
            }
        }
    }
}