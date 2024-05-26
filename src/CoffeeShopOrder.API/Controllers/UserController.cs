using CoffeeShopOrder.Application.Interfaces;
using CoffeeShopOrder.Application.Models.DTO;
using CoffeeShopOrder.Application.Models.Requests;
using CoffeeShopOrder.Application.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopOrder.API.Controllers
{
    [Route("api/v1/users")]
    public class UserController : ControllerBase
    {
        protected IUserService _userService { get; set; }

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet, Route("get-by-id")]
        public async Task<GetUserResponse> Get(Guid id, CancellationToken cancellationToken)
        {

            return await _userService.Get(id, cancellationToken);
        }

        [HttpPost, Route("create")]
        public async Task<UserDTO> Post([FromBody] UserCreateRequest user, CancellationToken cancellationToken)
        {
            return await _userService.Create(user, cancellationToken);
        }

        [HttpGet, Route("list")]
        public async Task<List<GetUserResponse>> List(CancellationToken cancellationToken)
        {
            return await _userService.List(cancellationToken);
        }


    }
}
