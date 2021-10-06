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
    public class DeleteId
    {
        public class Query : IRequest
        {
            public int DbId { get; set; }
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
                    .FindAsync(request.DbId);

                _context.WeatherForecast.Remove(weatherForecast);
                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}