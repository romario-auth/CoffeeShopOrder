using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopOrder.API.Controllers
{
    [Route("api/v1/Tools")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        [HttpGet, Route("ping")]
        public string Ping()
        {
            return "Pong";
        }
    }
}
