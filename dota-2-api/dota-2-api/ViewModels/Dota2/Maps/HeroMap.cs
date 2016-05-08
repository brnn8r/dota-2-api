using AutoMapper;
using dota_2_api.Models.Dota2.Interfaces;

namespace dota_2_api.ViewModels.Dota2.Maps
{
    public class HeroMap : Profile
    {
        protected override void Configure()
        {
            CreateMap<IHero, HeroDto>().ReverseMap();
        }
    }
}