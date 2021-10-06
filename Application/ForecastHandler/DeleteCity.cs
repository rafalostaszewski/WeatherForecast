using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.ForecastHandler
{
    public class DeleteCity
    {
        public class Query : IRequest
        {
            public string City { get; set; }
        }
        public class Handler : IRequestHandler<Query>
        {
            private readonly WeatherForecastDbContext _context;
            public Handler(WeatherForecastDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Query request, CancellationToken cancellationToken)
            {
                var weatherForecast = await _context
                    .WeatherForecast
                    .Where(w => w.Name == request.City)
                    .ToListAsync();

                _context.WeatherForecast.RemoveRange(weatherForecast);
                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}