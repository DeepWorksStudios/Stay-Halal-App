using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Stay_Halal.MVVM.View;
using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Helper;
using Stay_Halal.Scripts.Libraries.Dynamic;
using ZXing.Net.Maui;

namespace Stay_Halal;

public static class MauiProgram
{
    public static NavigationHelper navigationHelper { get { return _navigationHelper; } }
    private static readonly NavigationHelper _navigationHelper = new();

    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
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

        builder.Services.AddTransient<ProductDetailView>();
        builder.Services.AddTransient<ProductDetailViewModel>();

        builder.Services.AddTransient<BarcodeScannerView>();
        builder.Services.AddTransient<BarcodeScannerViewModel>();

        builder.Services.AddTransient<MessagePage>();
        builder.Services.AddTransient<MessageViewModel>();

        #endregion

        #region Register Libraries
        builder.Services.AddSingleton<Theme_Lib>();
        builder.Services.AddSingleton<Setting_Lib>();
        builder.Services.AddSingleton<DB_Lib>();
        #endregion


        #region Register Helper
        builder.Services.AddSingleton<NavigationHelper>();
        builder.Services.AddSingleton<StartupHelper>();
        #endregion

        return builder.Build();
	}
}
