using AutoMapper;
using CoffeeShopOrder.Application.DTO;
using CoffeeShopOrder.Domain.Entities;

namespace CoffeeShopOrder.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
