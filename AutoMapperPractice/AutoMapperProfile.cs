using AutoMapper;
using AutoMapperPractice.DTOs;
using AutoMapperPractice.Models;

namespace AutoMapperPractice
{
    // Need to make a AutoMapper Profile for AutoMapper to work properly.
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Mapping from source to Destination. In this case, mapping from SuperHero to SuperHeroDto.
            CreateMap<SuperHero, SuperHeroDto>();
            CreateMap<SuperHeroDto, SuperHero>();
        }
    }
}
