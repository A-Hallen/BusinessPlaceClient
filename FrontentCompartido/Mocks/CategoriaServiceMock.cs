using FrontentCompartido.model;
using FrontentCompartido.Red.Api.Interfaces;

namespace FrontentCompartido.Mocks
{
    internal class CategoriaServiceMock : ICategoriaService
    {
        public async Task<Categoria[]> GetAll()
        {
            string Url = "_content/FrontentCompartido/imagenes";

            Categoria[] _categorias =
            {
                new Categoria(id: 0, nombre: "Productos de Maquillaje", imagenUrl: $"{Url}/maquillaje.png", colorDominante: "#8c7874"),
                new Categoria(id: 1, nombre: "Piezas de auto", colorDominante: "#797671", imagenUrl: $"{Url}/piezas_de_auto.png"),
                new Categoria(id: 2, nombre: "Electrodomésticos", colorDominante: "#c7c3c4", textColor: "black", imagenUrl: $"{Url}/electrodomesticos.png"),
                new Categoria(id: 3, nombre: "Ropa", colorDominante: "#c2949f", textColor: "black", imagenUrl: $"{Url}/ropa.png"),
                new Categoria(id: 4, nombre: "LLantas", colorDominante: "#585858", imagenUrl: $"{Url}/llantas.png"),
                new Categoria(id: 5, nombre: "Frutas", colorDominante: "#b6924a", imagenUrl: $"{Url}/frutas.png"),
                new Categoria(id: 6, nombre: "Bebidas", colorDominante: "#826a59", imagenUrl: $"{Url}/bebidas.png"),
                new Categoria(id: 7, nombre: "Licores", colorDominante: "#786856", imagenUrl: $"{Url}/licores.png"),
                new Categoria(id: 8, nombre: "Telefonos", colorDominante: "#6e7d8f", imagenUrl: $"{Url}/telefonos.png"),
                new Categoria(id: 9, nombre: "Laptops", colorDominante: "#3d415e", imagenUrl: $"{Url}/laptops.png"),
                new Categoria(id: 10, nombre: "vajilla", colorDominante: "#b5ab8e", textColor: "black", imagenUrl: $"{Url}/vajilla.png  "),
                new Categoria(id: 11, nombre: "Utensilios de cocina", colorDominante: "#a5a7ab", textColor: "black", imagenUrl: $"{Url}/utencilios_de_cocina.png"),
            };

            return _categorias;
        }
    }
}
