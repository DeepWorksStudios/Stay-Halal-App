

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
    private void OnConfirmInput()
    {
        if (!canScan) return;
        canScan = false;
        scanner.ScanProduct(ManualInputValue);
    }
    #endregion

    private Scanner_Lib scanner;
    private bool canScan;

    public void OnAppearing()
    { ManualInputValue = Localisation_Lib.empty; canScan = true; }

    #region Constructor/Destructor
    public ManualInputViewModel(Scanner_Lib _scanner) : base()
    {
        Title = Localisation_Lib.ViewTitle_ManuelInput;
        scanner = _scanner;
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

