using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Stay_Halal.MVVM.View;
using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Helper;
using Stay_Halal.Scripts.Libraries.Dynamic;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace Stay_Halal;

public static class MauiProgram
{
    public static NavigationHelper NavigationHelper { get { return _NavigationHelper; } }
    private static readonly NavigationHelper _NavigationHelper = new();

    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(Fonts =>
            {
                Fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                Fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        #region Register Packages
        builder.UseMauiCommunityToolkit();
        builder.UseBarcodeReader();
        #endregion

        #region Register MVVM Components
        builder.Services.AddSingleton<WelcomeView>();
        builder.Services.AddSingleton<WelcomeViewModel>();

        builder.Services.AddSingleton<MainMenuView>();
        builder.Services.AddSingleton<MainMenuViewModel>();

        builder.Services.AddSingleton<SettingView>();
        builder.Services.AddSingleton<SettingViewModel>();

        builder.Services.AddSingleton<ContactView>();
        builder.Services.AddSingleton<ContactViewModel>();

        builder.Services.AddSingleton<InfoView>();
        builder.Services.AddSingleton<InfoViewModel>();

        builder.Services.AddSingleton<ManualInputView>();
        builder.Services.AddSingleton<ManualInputViewModel>();

        builder.Services.AddSingleton<BarcodeScannerView>();
        builder.Services.AddSingleton<BarcodeScannerViewModel>();

        builder.Services.AddTransient<ProductDetailView>();
        builder.Services.AddTransient<ProductDetailViewModel>();



        builder.Services.AddTransient<MessagePage>();
        builder.Services.AddTransient<MessageViewModel>();

        #endregion

        #region Register Libraries
        builder.Services.AddSingleton<Theme_Lib>();
        builder.Services.AddSingleton<Setting_Lib>();
        builder.Services.AddSingleton<DB_Lib>();
        builder.Services.AddSingleton<Scanner_Lib>();
        #endregion

        #region Register Helper
        builder.Services.AddSingleton<NavigationHelper>();
        builder.Services.AddSingleton<StartupHelper>();
        #endregion

        return builder.Build();
    }
}
