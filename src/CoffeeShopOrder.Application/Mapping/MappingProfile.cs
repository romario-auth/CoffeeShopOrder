using AutoMapper;
using CoffeeShopOrder.Application.Models.DTO;
using CoffeeShopOrder.Application.Models.Requests;
using CoffeeShopOrder.Application.Models.Responses;
using CoffeeShopOrder.Domain.Entities;

namespace CoffeeShopOrder.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.UserId, src => src.MapFrom(item => item.Id));
            
            CreateMap<User, UserCreateRequest>().ReverseMap();
            
            CreateMap<User, GetUserResponse>()
                .ForMember(dest => dest.UserId, src => src.MapFrom(item => item.Id));
        }
    }
}
