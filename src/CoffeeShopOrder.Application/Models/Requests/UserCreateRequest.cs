using System.ComponentModel.DataAnnotations;

namespace CoffeeShopOrder.Application.Models.Requests
{
    public class UserCreateRequest
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
