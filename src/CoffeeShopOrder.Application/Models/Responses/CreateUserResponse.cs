using CoffeeShopOrder.Application.Models.DTO;

namespace CoffeeShopOrder.Application.Models.Responses
{
    public record CreateUserResponse
    {
        UserDTO User { get; set; }
    }
}
