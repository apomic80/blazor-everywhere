using blzcomponents.Services;
using blzmaui.Services;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace blzmaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .RegisterBlazorMauiWebView()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddBlazorWebView();
            builder.Services.AddSingleton<IDataService, DataServices>();

            return builder.Build();
        }
    }
}