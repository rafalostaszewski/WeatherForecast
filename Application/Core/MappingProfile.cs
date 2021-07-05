using Application.Models;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Clouds, CloudsDto>();
            CreateMap<Coord, CoordDto>();
            CreateMap<Main, MainDto>();
            CreateMap<Rain, RainDto>();
            CreateMap<Snow, SnowDto>();
            CreateMap<Sys, SysDto>();
            CreateMap<Weather, WeatherDto>();
            CreateMap<Wind, WindDto>();
            CreateMap<WeatherForecast, WeatherForecastDto>();

            CreateMap<CloudsDto, Clouds>();
            CreateMap<CoordDto, Coord>();
            CreateMap<MainDto, Main>();
            CreateMap<RainDto, Rain>();
            CreateMap<SnowDto, Snow>();
            CreateMap<SysDto, Sys>();
            CreateMap<WeatherDto, Weather>();
            CreateMap<WindDto, Wind>();
            CreateMap<WeatherForecastDto, WeatherForecast>();
        }
    }
}