namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        readonly Random random = new();

        private TestContext testContextInstance;

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void ObtenerPrecioAdornadoTest()
        {
            decimal precio = 10m;
            decimal oferta = 5m;
            ObtenerPrecioAdornado(precio, oferta);
            
        }

        public string[] ObtenerPrecioAdornado(decimal precio, decimal oferta)
        {
            decimal numero = (oferta > 0) ? oferta : precio;
            int left = (int)numero;
            decimal _right = numero - left;
            string right = string.Empty;
            if (_right > 0)
            {
                right = $".{_right.ToString().Remove(0, 2)}";
            }

            if (oferta < precio && oferta > 0)
            {
                decimal _descuento = 100 - oferta / precio * 100;
                decimal discount = (decimal)Math.Round(_descuento);
                return [$"${left}", right, $"-{discount}%", $"${precio}"];
            }

            return [$"${left}", right];
        }

        private decimal GenerateRandomDecimal() => Convert.ToDecimal(random.NextDouble()) * 100.0m;
    }
}

