

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
    #region Private Data
    private readonly Scanner_Lib scanner;
    private bool canScan;
    #endregion

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
        scanner.ScanProdukt(ManualInputValue);
    }
    #endregion

    #region Constructor/Destructor
    public ManualInputViewModel(Scanner_Lib _scanner) : base()
    {
        Title = Lokalisation_Lib.ViewTitle_ManuelInput;
        scanner = _scanner;
        ManualInputPlaceHolder = Lokalisation_Lib.ManualInputPlaceHolder;
        ManualInputTitel = Lokalisation_Lib.ManualInputTitle;
        ManualInputDesc = Lokalisation_Lib.ManualInputDesc;
       ManualInputComfirmButton = Lokalisation_Lib.ManualInputComfirmButton;
    }
    #endregion

    #region Public Calls
    public void OnAppearing()
    { ManualInputValue = Lokalisation_Lib.empty; canScan = true; }
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

