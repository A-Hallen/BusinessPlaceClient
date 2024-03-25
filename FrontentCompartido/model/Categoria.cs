namespace FrontentCompartido.model
{
    public class Categoria
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public string ImagenUrl { get; set; }

        public string ColorDominante { get; set; }

        public string TextColor { get; set; }

        public Categoria(string nombre, int id, string imagenUrl, string colorDominante, string textColor = "White")
        {
            Nombre = nombre;
            Id = id;
            ImagenUrl = imagenUrl;
            ColorDominante = colorDominante;
            TextColor = textColor;
        }

    }
}
