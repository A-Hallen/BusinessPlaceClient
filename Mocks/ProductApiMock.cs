﻿using FrontentCompartido.model;
using Red.Api;

namespace Mocks
{
    internal class ProductApiMock : IProductsApi
    {
        public async Task<Producto[]> GetProductosAsync()
        {
            Producto[] _productos =
            {
            new Producto(Id: 0, Nombre: "Manzana", ImagenUrl: "imagenes/manzana.png", Precio: 2.99f, Descripcion: "Convierte en una opción irresistible para cualquier amante de las frutas. Ya sea que las disfrutes como un refrigerio saludable, las utilices en tus recetas favoritas o las añadas a tu ensalada, estas manzanas te brindarán una experiencia frutal de primera calidad.",
            ColorDominante: "#96e001", ColorSecundario: "#e5f89e", IsNew: true),
            new Producto(Id: 1, Nombre: "Zapatos", ImagenUrl: "imagenes/zapato.png", Precio: 60f, Oferta: 55.5f, Descripcion: "Zapatos elegantes y cómodos para cualquier ocasión: Nuestros zapatos combinan a la perfección estilo y comodidad. Diseñados con atención al detalle y con materiales de alta calidad, estos zapatos te brindarán un look sofisticado sin sacrificar la comodidad durante todo el día. La suela acolchada proporciona una amortiguación adicional, mientras que el diseño ergonómico garantiza un ajuste perfecto. Ya sea que los lleves en una reunión de negocios, una ocasión formal o simplemente para completar tu atuendo diario, estos zapatos son la elección ideal para destacar con estilo y mantener tus pies felices.",
            ColorDominante: "#110e0f", ColorSecundario: "#323232"),
            new Producto(Id: 2, Nombre: "Guitarra", ImagenUrl: "imagenes/guitarra.webp", Precio: 200f, Descripcion: "Guitarra de calidad profesional para músicos apasionados: Esta guitarra es la elección perfecta para aquellos que buscan un instrumento de alto rendimiento. Con una construcción sólida y meticulosa, ofrece un sonido excepcional y una resonancia equilibrada en cada nota. Su cuerpo elegante y ergonómico permite un fácil acceso a los trastes superiores y brinda una experiencia de interpretación cómoda y fluida. Además, sus pastillas de alta calidad capturan la esencia y la expresividad de tu estilo musical, llevando tus interpretaciones al siguiente nivel. Ya sea que seas un principiante entusiasta o un músico experimentado, esta guitarra te inspirará a crear música hermosa y cautivadora.",
            ColorDominante: "#7c5842", ColorSecundario: "#957b6f"),
            new Producto(Id: 3, Nombre: "Pintalabios", ImagenUrl: "imagenes/pintalabios.png", Precio: 10f, Descripcion: "Pintalabios de alta calidad y estilo deslumbrante: Nuestro pintalabios es el complemento perfecto para resaltar tu belleza y añadir un toque de glamour a tu maquillaje. Con una textura suave y sedosa, se desliza fácilmente sobre tus labios, brindando un color intenso y duradero. Además, su fórmula de larga duración mantiene tus labios hidratados y suaves, evitando la sequedad y el deterioro del color. Disponible en una amplia gama de tonos y acabados, desde los clásicos hasta los más audaces, este pintalabios te permite expresar tu estilo único y realzar tu sonrisa con confianza. Descubre el poder de un pintalabios que combina calidad, belleza y elegancia en cada aplicación.",
            ColorDominante: "#c6788c", ColorSecundario: "#cb8c98"),
            new Producto(Id: 4, Nombre: "Camisas", ImagenUrl: "imagenes/camisas.png", Precio: 20f, Descripcion: "Camisas elegantes y versátiles para lucir con estilo: Nuestras camisas son una opción perfecta para hombres y mujeres que buscan un look sofisticado y a la moda. Confeccionadas con tejidos de alta calidad, ofrecen una combinación perfecta de comodidad y estilo. Diseñadas con detalles cuidadosamente elaborados, como cuellos y puños con acabados impecables, estas camisas te brindan un aspecto pulido en cualquier ocasión. Desde estilos clásicos y formales hasta diseños más casuales y contemporáneos, nuestra colección cuenta con una amplia variedad de colores y patrones para adaptarse a tu gusto personal. Ya sea que las lleves en el trabajo, en eventos sociales o en ocasiones especiales, nuestras camisas te ayudarán a destacar con elegancia y confianza.",
            ColorDominante: "#a9bcd4", ColorSecundario: "#b1c5dc", IsNew: true),
            new Producto(Id: 5, Nombre: "Maleta", ImagenUrl: "imagenes/maleta.png", Precio: 50f, Descripcion: "Maletas duraderas y funcionales para tus viajes: Nuestras maletas están diseñadas pensando en los viajeros modernos que buscan combinar estilo y practicidad. Fabricadas con materiales resistentes y de alta calidad, estas maletas ofrecen una protección confiable para tus pertenencias durante tus desplazamientos. Con compartimentos espaciosos y organizadores internos, te brindan la capacidad de empacar de manera eficiente y mantener tus pertenencias ordenadas. Además, cuentan con características como ruedas giratorias suaves y asas ergonómicas, lo que facilita su transporte y maniobrabilidad en aeropuertos y estaciones. Ya sea que viajes por negocios o placer, nuestras maletas te brindarán la confianza de tener un compañero confiable y estilizado en todos tus viajes.",
            ColorDominante: "#b5322b", ColorSecundario: "#bb423d"),
            new Producto(Id: 6, Nombre: "Plancha", ImagenUrl: "imagenes/plancha.png", Precio: 20f, Descripcion: "Simplifica tus tareas de planchado con nuestra plancha de alta calidad. Diseñada con la última tecnología, esta plancha combina eficiencia y comodidad para ofrecerte resultados impecables en cada prenda. Su suela de cerámica antiadherente se desliza suavemente sobre las telas, eliminando arrugas difíciles con facilidad. Con su control de temperatura ajustable, puedes adaptar el calor según el tipo de tela, garantizando una protección óptima para tus prendas más delicadas. Además, su función de vapor vertical te permite refrescar tus prendas colgadas sin necesidad de usar la tabla de planchar. Descubre la eficacia y la practicidad de nuestra plancha y disfruta de la ropa perfectamente planchada en poco tiempo.",
            ColorDominante: "#c4c8d1", ColorSecundario: "#d2d3d8"),
            new Producto(Id: 7, Nombre: "Motorina", ImagenUrl: "imagenes/motorina.png", Precio: 700f, Oferta: 650f, Descripcion: "Motorina ágil y eficiente para tus desplazamientos urbanos: Nuestra motorina es la opción ideal para aquellos que buscan una forma conveniente y ecológica de moverse por la ciudad. Equipada con un motor eficiente y silencioso, te brinda una experiencia de conducción suave y sin emisiones contaminantes. Su diseño compacto y maniobrable te permite navegar fácilmente por el tráfico y encontrar estacionamiento sin problemas. Además, cuenta con características como luces LED, frenos de disco y una amplia plataforma para mayor comodidad y seguridad. Ya sea que la utilices para ir al trabajo, hacer recados o simplemente explorar la ciudad, nuestra motorina te ofrece una alternativa práctica y divertida para tus desplazamientos diarios.",
            ColorDominante: "#482c30", ColorSecundario: "#5e4044", IsNew: true),
            new Producto(Id: 8, Nombre: "Red Bull", ImagenUrl: "imagenes/red_bull.png", Precio: 3f, Descripcion: "Red Bull: la bebida energética que te da alas. Red Bull es una bebida energética popular y reconocida a nivel mundial. Con su distintivo sabor y una fórmula especializada, proporciona un impulso de energía y vitalidad cuando más lo necesitas. Infundida con ingredientes como la cafeína, la taurina y las vitaminas, Red Bull te ayuda a mantenerte despierto, concentrado y alerta, ya sea durante actividades físicas intensas, largas jornadas de estudio o momentos en los que necesitas ese estímulo adicional. Además, su lata icónica y diseño vibrante reflejan su espíritu dinámico y enérgico. Disfruta de Red Bull para recargar tus energías y enfrentar los desafíos diarios con vigor.",
            ColorDominante: "#787592", ColorSecundario: "#958e9e"),
            new Producto(Id: 9, Nombre: "Pulover", ImagenUrl: "imagenes/pulover.png", Precio: 30f, Descripcion: "Pulóver cómodo y elegante para mantenerte abrigado con estilo: Nuestro pulóver es una prenda versátil y acogedora que te brinda un look moderno y sofisticado. Confeccionado con tejidos suaves y de alta calidad, te envuelve en calidez y comodidad. Su diseño clásico y atemporal, combinado con detalles cuidadosamente elaborados, como cuello redondo o cuello en V, lo convierten en una opción perfecta para cualquier ocasión. Ya sea que lo uses como capa exterior en días frescos o como una capa adicional debajo de una chaqueta, nuestro pulóver te brindará un estilo elegante y te mantendrá abrigado con estilo durante los meses más fríos. Elige entre una variedad de colores y estilos para encontrar el pulóver que se adapte a tu personalidad y necesidades.",
            ColorDominante: "#013d85", ColorSecundario: "#083f88"),
            new Producto(Id: 10, Nombre: "Iphone 8 plus", ImagenUrl: "imagenes/iphone8plus.png", Precio: 400f, Oferta: 375f, Descripcion: "El iPhone 8 Plus es un teléfono inteligente de alta calidad que combina un diseño elegante con un rendimiento excepcional. Con su pantalla Retina HD de 5.5 pulgadas, disfrutarás de imágenes nítidas y colores vibrantes. Equipado con el potente chip A11 Bionic, este iPhone ofrece un rendimiento rápido y fluido, ideal para multitareas, juegos y aplicaciones exigentes.",
            ColorDominante: "#bab2ae", ColorSecundario: "#cbc2bd"),
    };
            return _productos;
        }
    }
}