using CoffeeShopOrder.Application.Models.Requests;
using CoffeeShopOrder.Application.Models.Responses;

namespace CoffeeShopOrder.Application.Interfaces
{
    public interface IUserService
    {
        Task<CreateUserResponse> Create(UserCreateRequest userCreateRequest, CancellationToken cancellationToken);
        Task<GetUserResponse> Get(Guid id, CancellationToken cancellationToken);
    }
}
