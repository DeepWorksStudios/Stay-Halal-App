

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Stay_Halal.MVVM.Model;
using Stay_Halal.Scripts.Libraries.Dynamic;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.ViewModel;

public partial class WelcomeViewModel : BaseViewModel
{

    #region Private Data
    private readonly Setting_Lib setting_lib;
    #endregion

    #region Observable Data 
    [ObservableProperty]
    private string welcomeTitle;

    [ObservableProperty]
    private string welcomeDesc;

    [ObservableProperty]
    private string welcomeIcon;

    [ObservableProperty]
    private string infoTitle;

    [ObservableProperty]
    private string infoDesc;

    [ObservableProperty]
    private string infoIcon;

    [ObservableProperty]
    private string confirmButtonTitle;

    [ObservableProperty]
    private string appLogo;

    [ObservableProperty]
    private string teamLogo;
    #endregion

    #region Relay Command
    [RelayCommand]
    private async void OnConfirm()
    {
        setting_lib.Comfirm_Key();

        MauiProgram.NavigationHelper.Unlook();
        var route = $"//MainMenu";
        await Shell.Current.GoToAsync(route); //await Shell.Current.fly;
    }
    #endregion

    #region Constructor/Destructor
    public WelcomeViewModel(Setting_Lib _setting_Lib) : base()
    {
        setting_lib = _setting_Lib;

        Title = Localisation_Lib.ViewTitle_Welcome;

        WelcomeTitle = Localisation_Lib.WelcomeTitle;
        WelcomeDesc = Localisation_Lib.WelcomeDesc;
        InfoTitle = Localisation_Lib.WelcomeInfoTitle;
        InfoDesc = Localisation_Lib.WelcomeInfoDesc;

        ConfirmButtonTitle = Localisation_Lib.WelcomeButtonTitle;
    }
    #endregion

    #region Protected Calls
    protected override void ThemeChanged(ThemeModel _theme)
    {
        base.ThemeChanged(_theme);

        switch (_theme.ThemeTyp)
        {
            case AppTheme.Unspecified:
                WelcomeIcon = Resources_Lib.Welcome_TitleIcon_ImageLight;
                InfoIcon = Resources_Lib.Welcome_InfoIcon_ImageLight;
                AppLogo = Resources_Lib.AppLogo_ImageLight;
                TeamLogo = Resources_Lib.CompanyLogo_ImageLight;
                break;
            case AppTheme.Light:
                WelcomeIcon = Resources_Lib.Welcome_TitleIcon_ImageLight;
                InfoIcon = Resources_Lib.Welcome_InfoIcon_ImageLight;
                AppLogo = Resources_Lib.AppLogo_ImageLight;
                TeamLogo = Resources_Lib.CompanyLogo_ImageLight;
                break;
            case AppTheme.Dark:
                WelcomeIcon = Resources_Lib.Welcome_TitleIcon_ImageDark;
                InfoIcon = Resources_Lib.Welcome_InfoIcon_ImageDark;
                AppLogo = Resources_Lib.AppLogo_ImageDark;
                TeamLogo = Resources_Lib.CompanyLogo_ImageDark;
                break;
        }
    }
    #endregion
}

