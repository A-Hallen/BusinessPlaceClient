using FrontentCompartido.Mocks;
using FrontentCompartido.Red.Api;
using FrontentCompartido.Red.Api.Interfaces;
using FrontentCompartido.viewmodels;
using Microsoft.Extensions.DependencyInjection;

namespace FrontentCompartido
{
    public static class ServiceExtensions
    {
        private static IServiceCollection AddMockNetApi(this IServiceCollection services)
        {
            services.AddScoped<IProductsApi, ProductApiMock>();
            services.AddScoped<ICategoriaService, CategoriaServiceMock>();

            return services;
        }

        private static IServiceCollection AddNetApi(this IServiceCollection services)
        {
            services.AddScoped<IProductsApi, ProductsApi>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            return services;
        }

        public static IServiceCollection AddSharedServices(this IServiceCollection services)
        {
            services.AddScoped<IBasicViewModel, BasicViewModel>();

#if MOCKNETAPI
            return AddMockNetApi(services);
#else
            return AddNetApi(services);
#endif
        }
    }
}