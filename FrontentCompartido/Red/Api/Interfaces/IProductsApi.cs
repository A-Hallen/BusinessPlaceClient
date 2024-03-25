using FrontentCompartido.model;

namespace FrontentCompartido.Red.Api.Interfaces
{
    public interface IProductsApi
    {
        Task<Producto[]> GetProductosAsync();
    }
}
