
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Stay_Halal.MVVM.Model;
using Stay_Halal.Scripts.Libraries.Static;
using System;

namespace Stay_Halal.MVVM.ViewModel;

public partial class ContactViewModel : BaseViewModel
{

    #region Observable Data 
    [ObservableProperty]
    private string contactTitle;

    [ObservableProperty]
    private string contactDesc;

    [ObservableProperty]
    private string contactIcon;

    [ObservableProperty]
    private string contactEmail;

    [ObservableProperty]
    private string socailMediaTitle;

    [ObservableProperty]
    private string socailMediaDesc;

    [ObservableProperty]
    private string socailMediaIcon;

    [ObservableProperty]
    private string websiteTitle;

    [ObservableProperty]
    private string websiteIcon;

    [ObservableProperty]
    private string facebookTitle;

    [ObservableProperty]
    private string facebookIcon;

    [ObservableProperty]
    private string instagramTitle;

    [ObservableProperty]
    private string instagramIcon;
    #endregion

    #region Relay Commands

    [RelayCommand]
    private void OnEntryTextChanged()
    {
        ContactEmail = Localisation_Lib.ContactEmail;
    }

    [RelayCommand]
    private async void OnWebsite()
    {
        await Browser.OpenAsync(Resources_Lib.WebsiteLink, BrowserLaunchMode.External);
    }

    [RelayCommand]
    private async void OnFacebook()
    {
        await Browser.OpenAsync(Resources_Lib.FacebookLink, BrowserLaunchMode.External);
    }

    [RelayCommand]
    private async void OnInstagram()
    {
        await Browser.OpenAsync(Resources_Lib.InstagramLink, BrowserLaunchMode.External);
    }
    #endregion

    #region Constructor/Destructor
    public ContactViewModel() : base()
    {
        Title = Localisation_Lib.ViewTitle_Contact;

        ContactTitle= Localisation_Lib.ContactTitle;
        ContactDesc = Localisation_Lib.ContactDesc;
        ContactEmail = Localisation_Lib.ContactEmail;

        SocailMediaTitle = Localisation_Lib.ContactSocialMedia;
        WebsiteTitle = Localisation_Lib.ContactWebsite;
        FacebookTitle = Localisation_Lib.ContactFacebook;
        InstagramTitle = Localisation_Lib.ContactInstagram;

        SocailMediaDesc = Localisation_Lib.ContactSocialMediaDesc;
    }
    #endregion

    #region Protected Calls
    protected override void ThemeChanged(ThemeModel _theme)
    {
        base.ThemeChanged(_theme);

        switch (_theme.ThemeTyp)
        {
            case AppTheme.Unspecified:
                ContactIcon = Resources_Lib.Contact_TitleIcon_ImageLight;
                WebsiteIcon = Resources_Lib.Contact_WebsiteIcon_ImageLight;
                FacebookIcon = Resources_Lib.Contact_FacebookIcon_ImageLight;
                InstagramIcon = Resources_Lib.Contact_InstagramIcon_ImageLight;
                SocailMediaIcon= Resources_Lib.Contact_SocialIcon_ImageLight;
                break;
            case AppTheme.Light:
                ContactIcon = Resources_Lib.Contact_TitleIcon_ImageLight;
                WebsiteIcon = Resources_Lib.Contact_WebsiteIcon_ImageLight;
                FacebookIcon = Resources_Lib.Contact_FacebookIcon_ImageLight;
                InstagramIcon = Resources_Lib.Contact_InstagramIcon_ImageLight;
                SocailMediaIcon = Resources_Lib.Contact_SocialIcon_ImageLight;
                break;
            case AppTheme.Dark:
                ContactIcon = Resources_Lib.Contact_TitleIcon_ImageDark;
                WebsiteIcon = Resources_Lib.Contact_WebsiteIcon_ImageDark;
                FacebookIcon = Resources_Lib.Contact_FacebookIcon_ImageDark;
                InstagramIcon = Resources_Lib.Contact_InstagramIcon_ImageDark;
                SocailMediaIcon = Resources_Lib.Contact_SocialIcon_ImageDark;
                break;
        }
    }
    #endregion
}

