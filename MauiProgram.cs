global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;

global using MenuSapmple.View;
global using MenuSapmple.ViewModel;

global using Microsoft.Extensions.Logging;

global using System.Diagnostics;

namespace MenuSapmple {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<MainViewModel>();

            builder.Services.AddSingleton<MainPage>();



            return builder.Build();
        }


    }
}
