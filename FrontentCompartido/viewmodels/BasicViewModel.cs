using FrontentCompartido.model;
using FrontentCompartido.Red.Api.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FrontentCompartido.viewmodels
{
    public class BasicViewModel : INotifyPropertyChanged, IBasicViewModel
    {
        private IProductsApi ProductsApi { get; set; }
        private ICategoriaService CategoriaService { get; set; }


        public BasicViewModel(IProductsApi productsApi, ICategoriaService categoriaService)
        {
            ProductsApi = productsApi;
            CategoriaService = categoriaService;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private List<Categoria> _categorias;
        public List<Categoria> Categorias
        {
            get => _categorias ??= new List<Categoria>();
            set
            {
                if (_categorias != value)
                {
                    _categorias = value;
                    OnPropertyChanged();
                }
            }
        }


        private List<Producto>? _products;
        public List<Producto>? Productos
        {
            get => _products;
            set
            {
                if (_products != value)
                {
                    _products = value;
                    OnPropertyChanged();
                }
            }
        }

        private decimal _totalCarrito = 0;
        public decimal TotalCarrito
        {
            get => _totalCarrito;
            set
            {
                if (_totalCarrito != value)
                {
                    _totalCarrito = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<int> _productosDelCarrito = new();
        public List<int> ProductosDelCarrito
        {
            get { return _productosDelCarrito; }
            set
            {
                TotalCarrito = 0m;
                value.ForEach(_id =>
                {
                    Producto p = Productos.Find(_p => _p.Id == _id);

                    if (p.Oferta > 0)
                    {
                        TotalCarrito += p.Oferta;
                    }
                    else
                    {
                        TotalCarrito += p.Precio;
                    }
                });
                _productosDelCarrito = value; OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void GetCategorias()
        {
            Categoria[] response = await CategoriaService.GetAll();
            Categorias = response.ToList();
        }
        public async void GetProducts()
        {
            Producto[] response = await ProductsApi.GetProductosAsync();
            Productos = response.ToList();
        }
    }
}
