using AutoMapper;
using BreweryAPI.Entities;
using BreweryAPI.DTOs;

namespace BreweryAPI.Profiles
{
    public class BreweryProfile : Profile
    {
        public BreweryProfile()
        {
            CreateMap<Brewery, BreweryDto>();
            CreateMap<BreweryDto, Brewery>();
        }
    }
}
