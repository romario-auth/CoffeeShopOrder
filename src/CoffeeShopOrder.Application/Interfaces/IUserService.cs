using CoffeeShopOrder.Application.Models.DTO;
using CoffeeShopOrder.Application.Models.Requests;
using CoffeeShopOrder.Application.Models.Responses;

namespace CoffeeShopOrder.Application.Interfaces
{
    public interface IUserService
    {
        Task<GetUserResponse> Get(Guid id, CancellationToken cancellationToken);
        Task<UserDTO> Create(UserCreateRequest userCreateRequest, CancellationToken cancellationToken);
        Task<List<GetUserResponse>> List(CancellationToken cancellationToken);
    }
}
