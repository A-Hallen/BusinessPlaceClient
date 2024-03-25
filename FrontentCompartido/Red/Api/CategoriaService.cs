using FrontentCompartido.model;
using FrontentCompartido.Red.Api.Interfaces;
using FrontentCompartido.Red.UseCases;

namespace FrontentCompartido.Red.Api
{
    internal class CategoriaService : ICategoriaService
    {
        HttpClient Http { get; }

        public CategoriaService(HttpClient http) => Http = http;

        public async Task<Categoria[]> GetAll() => await new ObtenerCategoriasUseCase().ObtenerCategorias(Http);
    }
}
