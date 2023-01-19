using CommunityToolkit.Mvvm.ComponentModel;
using Stay_Halal.Scripts.Libraries.Static;
using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.MVVM.Model;
using Stay_Halal.Scripts.Helper;

namespace Stay_Halal.MVVM.ViewModel;

public partial class AppShellViewModel : BaseViewModel
{
    #region Observable Data

    #region Text
    [ObservableProperty]
    string mainMenu_Text;

    [ObservableProperty]
    string productMenu_Text;

    [ObservableProperty]
    string barScannerMenu_Text;

    [ObservableProperty]
    string manualInputMenu_Text;

    [ObservableProperty]
    string settingMenu_Text;

    [ObservableProperty]
    string contactMenu_Text;

    [ObservableProperty]
    string infoMenu_Text;

    #endregion

    #region Images
    [ObservableProperty]
    string headerMenu_Image;
    [ObservableProperty]
    string footerMenu_Image;

    [ObservableProperty]
    string mainMenu_Image;

    [ObservableProperty]
    string productMenu_Image;


    [ObservableProperty]
    string barScannerMenu_Image;

    [ObservableProperty]
    string manualInputMenu_Image;

    [ObservableProperty]
    string settingMenu_Image;

    [ObservableProperty]
    string contactMenu_Image;

    [ObservableProperty]
    string infoMenu_Image;

    #endregion

    #endregion

    #region Private Data
    private readonly NavigationHelper navigationHelper;
    #endregion

    #region Constructor/Destructor
    public AppShellViewModel(NavigationHelper _navigationHelper)
    {
        navigationHelper = _navigationHelper;

        mainMenu_Text = Localisation_Lib.FlyoutMenuItem_HauptMenü;
        productMenu_Text = Localisation_Lib.FlyoutMenuItem_ProductScanner;
        settingMenu_Text = Localisation_Lib.FlyoutMenuItem_Einstellung;
        contactMenu_Text = Localisation_Lib.FlyoutMenuItem_Kontakt;
        infoMenu_Text = Localisation_Lib.FlyoutMenuItem_Info;

        barScannerMenu_Text = Localisation_Lib.MenuBarItem_BarCodeScanner;
        manualInputMenu_Text = Localisation_Lib.MenuBarItem_ManualInput;

             
    }
    #endregion

    #region Protected Calls
    protected override void ThemeChanged(ThemeModel _theme)
    {
        base.ThemeChanged(_theme);

        switch (_theme.ThemeTyp)
        {
            case AppTheme.Unspecified:
                HeaderMenu_Image = Resources_Lib.AppLogo_ImageLight;
                FooterMenu_Image = Resources_Lib.CompanyLogo_ImageLight;
                MainMenu_Image = Resources_Lib.FlyoutMenuItem_HauptMenü_ImageLight;
                ProductMenu_Image = Resources_Lib.FlyoutMenuItem_ProductScanner_ImageLight;
                SettingMenu_Image = Resources_Lib.FlyoutMenuItem_Einstellung_ImageLight;
                ContactMenu_Image = Resources_Lib.FlyoutMenuItem_Kontakt_ImageLight;
                InfoMenu_Image = Resources_Lib.FlyoutMenuItem_Info_ImageLight;
                BarScannerMenu_Image = Resources_Lib.MenuBarItem_BarCode_ImageLight;
                ManualInputMenu_Image = Resources_Lib.MenuBarItem_ManualInput_ImageLight;
                break;
            case AppTheme.Light:
                HeaderMenu_Image = Resources_Lib.AppLogo_ImageLight;
                FooterMenu_Image = Resources_Lib.CompanyLogo_ImageLight;
                MainMenu_Image = Resources_Lib.FlyoutMenuItem_HauptMenü_ImageLight;
                ProductMenu_Image = Resources_Lib.FlyoutMenuItem_ProductScanner_ImageLight;
                SettingMenu_Image = Resources_Lib.FlyoutMenuItem_Einstellung_ImageLight;
                ContactMenu_Image = Resources_Lib.FlyoutMenuItem_Kontakt_ImageLight;
                InfoMenu_Image = Resources_Lib.FlyoutMenuItem_Info_ImageLight;
                BarScannerMenu_Image = Resources_Lib.MenuBarItem_BarCode_ImageLight;
                ManualInputMenu_Image = Resources_Lib.MenuBarItem_ManualInput_ImageLight;

                break;
            case AppTheme.Dark:
                HeaderMenu_Image = Resources_Lib.AppLogo_ImageDark;
                FooterMenu_Image = Resources_Lib.CompanyLogo_ImageDark;
                MainMenu_Image = Resources_Lib.FlyoutMenuItem_HauptMenü_ImageDark;
                ProductMenu_Image = Resources_Lib.FlyoutMenuItem_ProductScanner_ImageDark;
                SettingMenu_Image = Resources_Lib.FlyoutMenuItem_Einstellung_ImageDark;
                ContactMenu_Image = Resources_Lib.FlyoutMenuItem_Kontakt_ImageDark;
                InfoMenu_Image = Resources_Lib.FlyoutMenuItem_Info_ImageDark;
                BarScannerMenu_Image = Resources_Lib.MenuBarItem_BarCode_ImageDark;
                ManualInputMenu_Image = Resources_Lib.MenuBarItem_ManualInput_ImageDark;

                break;
        }
    }
    #endregion
}
