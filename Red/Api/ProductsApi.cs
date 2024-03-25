using Compartido.Model;
using System.Net.Http.Json;
namespace Red.Api
{
    internal class ProductsApi : IProductsApi
    {
        HttpClient Http { get; }

        public ProductsApi(HttpClient http)
        {
            Http = http;
        }

        public async Task<Producto[]> GetProductosAsync()
        {
            return await Http.GetFromJsonAsync<Producto[]>("Producto");
        }
    }
}
