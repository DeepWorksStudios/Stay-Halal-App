
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Stay_Halal.MVVM.Model;
using Stay_Halal.Scripts.Libraries.Dynamic;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.ViewModel;

public partial class SettingViewModel : BaseViewModel
{

    #region Private Data
    private readonly Setting_Lib setting_lib;
    private SettingModel setting_data;
    private Color selectedColor, unselectedColor;
    #endregion

    #region Observable Data

    [ObservableProperty]
    string sonstiges_Text;

    [ObservableProperty]
    string sonstiges_Icon;


    [ObservableProperty]
    string dataCaching_Text;

    [ObservableProperty]
    string theme_Text;

    [ObservableProperty]
    string theme_Icon;

    [ObservableProperty]
    string defaultTheme_Text;

    [ObservableProperty]
    string lightTheme_Text;

    [ObservableProperty]
    string darkTheme_Text;

    [ObservableProperty]
    Color defaultTheme_Color;

    [ObservableProperty]
    Color lightTheme_Color;

    [ObservableProperty]
    Color darkTheme_Color;
   

    [ObservableProperty]
    bool dataCaching_Value;

    [ObservableProperty]
    string defaultTheme_Image;

    [ObservableProperty]
    string lightTheme_Image;

    [ObservableProperty]
    string darkTheme_Image;

    #endregion

    #region Setup
    private void SetupText()
    {

        Title = Lokalisation_Lib.ViewTitle_Einstellung;
        Sonstiges_Text = Lokalisation_Lib.SettingSonstigeTitle;
        Theme_Text = Lokalisation_Lib.SettingThemeTitle;

        DataCaching_Text = Lokalisation_Lib.SettingCachingTitle;
        DefaultTheme_Text = Lokalisation_Lib.SettingDefaultThemeTitle;
        DarkTheme_Text = Lokalisation_Lib.SettingDarkThemeTitle;
        LightTheme_Text = Lokalisation_Lib.SettingLightThemeTitle;
    }
    private void SetupData()
    {

        DataCaching_Value = setting_data.DataCaching;
      
      

      
        switch (setting_data.Theme)
        {
            case AppTheme.Unspecified:
                DefaultTheme_Color = selectedColor;
                LightTheme_Color = unselectedColor;
                DarkTheme_Color = unselectedColor;
                break;
            case AppTheme.Light:
                DefaultTheme_Color = unselectedColor;
                LightTheme_Color = selectedColor;
                DarkTheme_Color = unselectedColor;
                break;
            case AppTheme.Dark:
                DefaultTheme_Color = unselectedColor;
                LightTheme_Color = unselectedColor;
                DarkTheme_Color = selectedColor;
                break;
        }
       
    }
    #endregion

    #region Update Calls

    #region Setting Data
    private void OnReceiveData(SettingModel _data)
    {
        setting_data = _data;
        DataCaching_Value = _data.DataCaching;
      

        UpdateThemeSelected(_data.Theme);
    }
    private void UpdateData()
    {
        UpdateThemeSelected(setting_data.Theme);
    
        setting_lib.Change_Settings(setting_data);
    }
    #endregion

    #region Update Theme
    private void UpdateTheme(AppTheme appTheme)
    {
        switch (appTheme)
        {
            case AppTheme.Unspecified:
               
              
                Theme_Icon = Resources_Lib.Setting_DesignIcon_ImageLight;
                Sonstiges_Icon = Resources_Lib.Setting_SonstigesIcon_ImageLight;
                DefaultTheme_Image = Resources_Lib.Setting_DesignDefault_ImageLight;
                DarkTheme_Image = Resources_Lib.Setting_DesignDark_ImageLight;
                LightTheme_Image = Resources_Lib.Setting_DesignLight_ImageLight;
                break;
            case AppTheme.Light:

                Theme_Icon = Resources_Lib.Setting_DesignIcon_ImageLight;
                Sonstiges_Icon = Resources_Lib.Setting_SonstigesIcon_ImageLight;
                DefaultTheme_Image = Resources_Lib.Setting_DesignDefault_ImageLight;
                DarkTheme_Image = Resources_Lib.Setting_DesignDark_ImageLight;
                LightTheme_Image = Resources_Lib.Setting_DesignLight_ImageLight;


                break;
            case AppTheme.Dark:

                Theme_Icon = Resources_Lib.Setting_DesignIcon_ImageDark;
                Sonstiges_Icon = Resources_Lib.Setting_SonstigesIcon_ImageDark;
                DefaultTheme_Image = Resources_Lib.Setting_DesignDefault_ImageDark;
                DarkTheme_Image = Resources_Lib.Setting_DesignDark_ImageDark;
                LightTheme_Image = Resources_Lib.Setting_DesignLight_ImageDark;


                break;
        }

        UpdateThemeSelected(appTheme);
        
    }
  
    #endregion

    #region Update Selected
    private void UpdateThemeSelected(AppTheme theme)
    {
        switch (theme)
        {
            case AppTheme.Unspecified:
                DefaultTheme_Color = selectedColor;
                LightTheme_Color = unselectedColor;
                DarkTheme_Color = unselectedColor;
                break;
            case AppTheme.Light:
                DefaultTheme_Color = unselectedColor;
                LightTheme_Color = selectedColor;
                DarkTheme_Color = unselectedColor;
                break;
            case AppTheme.Dark:
                DefaultTheme_Color = unselectedColor;
                LightTheme_Color = unselectedColor;
                DarkTheme_Color = selectedColor;
                break;
        }
    }
 
    #endregion

    #endregion

    #region Relay Commands

    #region Theme Changed
    [RelayCommand]
    void OnDefaultTheme()
    {
        setting_data.Theme = AppTheme.Unspecified;
        UpdateData();
    }

    [RelayCommand]
    void OnLightTheme()
    {
        setting_data.Theme = AppTheme.Light;
        UpdateData();
    }

    [RelayCommand]
    void OnDarkTheme()
    {
        setting_data.Theme = AppTheme.Dark;
        UpdateData();
    }
    #endregion

    #region Data Changed

    [RelayCommand]
    void OnRoundingChanged()
    {
        setting_data.DataCaching = DataCaching_Value;
        UpdateData();
    }



    #endregion

    #endregion

    #region Constructor/Destructor
    public SettingViewModel(Setting_Lib _lib)
    {
        setting_lib = _lib;
        setting_data = _lib.Setting_Data;

        setting_lib.updated_Settings += OnReceiveData;
        

        SetupText();
        SetupData();
    }

    ~SettingViewModel()
    {
        setting_lib.updated_Settings -= OnReceiveData;
      
    }
    #endregion

    #region Protected Calls
    protected override void ThemeChanged(ThemeModel _theme)
    {
        base.ThemeChanged(_theme);

        UpdateTheme(_theme.ThemeTyp);
        UpdateThemeSelected(_theme.ThemeTyp);

        selectedColor = _theme.SelectedColor;
        unselectedColor = _theme.UnselectedColor;

        switch (_theme.ThemeTyp)
        {
            case AppTheme.Unspecified:
               
                break;
            case AppTheme.Light:
              
                break;
            case AppTheme.Dark:
             
                break;
        }
    }
    #endregion
}

