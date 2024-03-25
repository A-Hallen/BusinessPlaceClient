using Microsoft.Extensions.DependencyInjection;
using Red.Api;

namespace Mocks
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddMockNetApi(this IServiceCollection services)
        {
            services.AddScoped<IProductsApi, ProductApiMock>();
            return services;
        }
    }
}