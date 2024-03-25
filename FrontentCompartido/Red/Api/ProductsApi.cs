using FrontentCompartido.model;
using FrontentCompartido.Red.Api.Interfaces;
using FrontentCompartido.Red.UseCases;
namespace FrontentCompartido.Red.Api
{
    internal class ProductsApi : IProductsApi
    {
        HttpClient Http { get; }

        public ProductsApi(HttpClient http) => Http = http;

        public async Task<Producto[]> GetProductosAsync() => await new ObtenerProductosUseCase().ObtenerProductos(Http);
    }
}
