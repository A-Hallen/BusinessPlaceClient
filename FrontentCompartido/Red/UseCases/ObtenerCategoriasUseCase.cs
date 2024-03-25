using System.Net.Http.Json;
using FrontentCompartido.model;

namespace FrontentCompartido.Red.UseCases
{
    public class ObtenerCategoriasUseCase
    {
        public async Task<Categoria[]> ObtenerCategorias(HttpClient http)
        {
            return await http.GetFromJsonAsync<Categoria[]>("Categoria");
        }

    }
}
