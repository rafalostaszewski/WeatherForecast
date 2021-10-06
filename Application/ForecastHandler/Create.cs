using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.ForecastHandler
{
    public class Create
    {
        public class Command : IRequest
        {
            public WeatherForecast WeatherForecast { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly WeatherForecastDbContext _context;
            public Handler(WeatherForecastDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.WeatherForecast.Add(request.WeatherForecast);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}