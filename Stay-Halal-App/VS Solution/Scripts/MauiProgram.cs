using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Stay_Halal.MVVM.View;
using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Dynamic;
using ZXing.Net.Maui;

namespace Stay_Halal;

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


        builder.Services.AddTransient<BarcodeScannerView>();
        builder.Services.AddTransient<BarcodeScannerViewModel>();

        builder.Services.AddSingleton<ManualInputView>();
        builder.Services.AddSingleton<ManualInputViewModel>();

        builder.Services.AddTransient<ProductDetailView>();
        builder.Services.AddTransient<ProductDetailViewModel>();

        #endregion

        #region Register Libraries
        builder.Services.AddSingleton<Theme_Lib>();
        #endregion

        return builder.Build();
	}
}
