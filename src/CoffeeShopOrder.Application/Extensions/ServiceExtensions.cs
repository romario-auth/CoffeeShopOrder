using CoffeeShopOrder.Application.Interfaces;
using CoffeeShopOrder.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CoffeeShopOrder.Application.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IUserService, UserService>();
        }
    }
}
