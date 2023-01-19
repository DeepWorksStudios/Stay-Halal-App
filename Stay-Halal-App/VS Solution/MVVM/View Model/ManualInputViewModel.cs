

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Stay_Halal.MVVM.Model;
using Stay_Halal.MVVM.View;
using Stay_Halal.Scripts.Libraries.Dynamic;
using Stay_Halal.Scripts.Libraries.Static;
using System.Diagnostics;

namespace Stay_Halal.MVVM.ViewModel;

public partial class ManualInputViewModel : BaseViewModel
{

    #region Observable Data 
    [ObservableProperty]
    private string manualInputTitel;

    [ObservableProperty]
    private string manualInputIcon;

    [ObservableProperty]
    private string manualInputDesc;

    [ObservableProperty]
    private string manualInputValue;

    [ObservableProperty]
    private string manualInputPlaceHolder;

    [ObservableProperty]
    private string manualInputComfirmButton;
    #endregion

    #region Relay Commands
    [RelayCommand]
    private async void OnConfirmInput()
    {
        Debug.WriteLine(ManualInputValue);

        ProductModel detail = _dB_Lib.GetProduct(ManualInputValue);

        Debug.WriteLine(detail);
        string route;
        Dictionary<string, object> parameters;
        if (detail==null)
        {

            MessageModel customMsg = new MessageModel("Regestrierung Verweigert", "Sie sind bereits angemeldet auf diesem gerät", "document_light.svg", "document_dark.svg", false, "Bestätigen", "../..");

            route = $"{nameof(MessagePage)}";
            parameters = new() { ["Model"] = customMsg };

        }
       
        else
        {
          
            route = $"//MainMenu/MainMenuView/{nameof(ProductDetailView)}";
            parameters = new() { ["Model"] = detail };
        }

        await Shell.Current.GoToAsync(route, parameters);
    }
    #endregion

    DB_Lib _dB_Lib;

    #region Constructor/Destructor
    public ManualInputViewModel(DB_Lib dB_Lib) : base()
    {
        Title = Localisation_Lib.ViewTitle_ManuelInput;
        _dB_Lib= dB_Lib;
        ManualInputPlaceHolder = Localisation_Lib.ManualInputPlaceHolder;
        ManualInputTitel = Localisation_Lib.ManualInputTitle;
        ManualInputDesc = Localisation_Lib.ManualInputDesc;
       ManualInputComfirmButton = Localisation_Lib.ManualInputComfirmButton;
    }
    #endregion

    #region Protected Calls
    protected override void ThemeChanged(ThemeModel _theme)
    {
        base.ThemeChanged(_theme);

        switch (_theme.ThemeTyp)
        {
            case AppTheme.Unspecified:
                ManualInputIcon = Resources_Lib.Manual_TitleIcon_ImageLight;
                break;
            case AppTheme.Light:
                ManualInputIcon = Resources_Lib.Manual_TitleIcon_ImageLight;
                break;
            case AppTheme.Dark:
                ManualInputIcon = Resources_Lib.Manual_TitleIcon_ImageDark;
                break;
        }
    }
    #endregion
}

