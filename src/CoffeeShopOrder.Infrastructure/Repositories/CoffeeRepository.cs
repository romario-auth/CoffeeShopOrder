using CoffeeShopOrder.Application.Context;
using CoffeeShopOrder.Domain.Entities;
using CoffeeShopOrder.Domain.Interfaces;

namespace CoffeeShopOrder.Application.Repositories
{
    public class CoffeeRepository : BaseRepository<Coffee>, ICoffeeRepository
    {
        public CoffeeRepository(AppDbContext context) : base(context) {}
    }
}
