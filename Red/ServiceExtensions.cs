using Microsoft.Extensions.DependencyInjection;
using Red.Api;

namespace Red
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddNetApi(this IServiceCollection services)
        {
            services.AddScoped<IProductsApi, ProductsApi>();
            return services;
        }
    }
}