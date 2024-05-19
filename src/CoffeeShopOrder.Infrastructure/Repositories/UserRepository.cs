using CoffeeShopOrder.Application.Context;
using CoffeeShopOrder.Domain.Entities;
using CoffeeShopOrder.Domain.Interfaces;

namespace CoffeeShopOrder.Application.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) {}
    }
}
