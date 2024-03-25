namespace FrontentCompartido.model
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public bool IsNew { get; set; }

        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        public decimal Oferta { get; set; }

        public string Descripcion { get; set; }
        public string ColorDominante { get; set; }

        public string ColorSecundario { get; set; }

        public Producto(int Id, string Nombre, string ImagenUrl, decimal Precio, string Descripcion, string ColorDominante, string ColorSecundario, decimal Oferta = 0m, bool IsNew = false)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.ImagenUrl = ImagenUrl;
            this.Precio = Precio;
            this.Oferta = Oferta;
            this.Descripcion = Descripcion;
            this.ColorDominante = ColorDominante;
            this.ColorSecundario = ColorSecundario;
            this.IsNew = IsNew;
        }
    }
}
