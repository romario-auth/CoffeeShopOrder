using CoffeeShopOrder.Application.Context;
using CoffeeShopOrder.Domain.Entities;
using CoffeeShopOrder.Domain.Interfaces;

namespace CoffeeShopOrder.Application.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context) {}
    }
}
