using FrontentCompartido.model;

namespace FrontentCompartido.Red.Api.Interfaces
{
    public interface ICategoriaService
    {
        Task<Categoria[]> GetAll();
    }
}
