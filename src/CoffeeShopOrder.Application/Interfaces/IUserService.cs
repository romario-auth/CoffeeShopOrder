using CoffeeShopOrder.Application.DTO;

namespace CoffeeShopOrder.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> Create(UserDTO userDTORequest, CancellationToken cancellationToken);
        Task<UserDTO> Get(Guid id);
    }
}
