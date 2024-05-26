using CoffeeShopOrder.Application.Context;
using CoffeeShopOrder.Application.Repositories;
using CoffeeShopOrder.Domain.Interfaces;
using CoffeeShopOrder.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeShopOrder.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services,
                                                    IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SqlServerConnection");
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICoffeeRepository, CoffeeRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}
