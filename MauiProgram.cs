global using WhatsAppClone.Views;
global using CommunityToolkit.Mvvm.ComponentModel;
global using WhatsAppClone.ViewModels;
global using CommunityToolkit.Maui;
global using Microsoft.Extensions.Logging;


namespace WhatsAppClone
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<CallsView,CallsViewModel>();
            builder.Services.AddSingleton<ChatsView,ChatsViewModel>();
            builder.Services.AddSingleton<CommunitiesView,CommunitiesViewModel>();
            builder.Services.AddSingleton<UpdatesView,UpdatesViewModel>();

            return builder.Build();
        }
    }
}
