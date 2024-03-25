using FrontentCompartido.model;
using System.ComponentModel;

namespace FrontentCompartido.viewmodels
{
    public interface IBasicViewModel
    {
        List<Producto>? Productos { get; set; }
        List<Categoria> Categorias { get; set; }
        List<int> ProductosDelCarrito { get; set; }

        decimal TotalCarrito { get; set; }

        event PropertyChangedEventHandler? PropertyChanged;

        void GetProducts();
        void GetCategorias();
    }
}
