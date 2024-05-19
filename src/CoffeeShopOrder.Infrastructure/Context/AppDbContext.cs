using CoffeeShopOrder.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopOrder.Application.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Coffee> Coffee { get; set; }
    }
}
