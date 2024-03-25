using FrontentCompartido.model;

namespace Red.Api
{
    public interface IProductsApi
    {
        Task<Producto[]> GetProductosAsync();
    }
}
