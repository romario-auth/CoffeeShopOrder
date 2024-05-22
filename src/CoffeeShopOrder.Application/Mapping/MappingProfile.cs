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
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<UserCreateRequest, User>().ReverseMap();
            CreateMap<CreateUserResponse, User>().ReverseMap();
        }
    }
}
