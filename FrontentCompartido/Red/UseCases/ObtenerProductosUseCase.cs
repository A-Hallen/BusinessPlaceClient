using System.Net.Http.Json;
using FrontentCompartido.model;

namespace FrontentCompartido.Red.UseCases
{
    public class ObtenerProductosUseCase
    {
        public async Task<Producto[]> ObtenerProductos(HttpClient http)
        {
            return await http.GetFromJsonAsync<Producto[]>("Productos");
        }
    }
}
