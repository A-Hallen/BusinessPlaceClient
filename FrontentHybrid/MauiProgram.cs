using Microsoft.Extensions.Logging;
using FrontentCompartido.viewmodels;
using FrontentCompartido;
using FrontentCompartido.Red.Api;
using FrontentCompartido.Mocks;

namespace FrontentHybrid
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
           
            // Esta linea agrega los servicios que son compartidos por MauiHybrid y la web
            builder.Services.AddSharedServices();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

#if MOCKNETAPI
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
