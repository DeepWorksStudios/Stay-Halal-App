using CommunityToolkit.Mvvm.ComponentModel;
using Stay_Halal.MVVM.Model;
using Stay_Halal.Scripts.Libraries.Dynamic;

namespace Stay_Halal.MVVM.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    #region Observable Data
    [ObservableProperty]
    private bool isBusy;

    [ObservableProperty]
    private string title;

    [ObservableProperty]
    private ThemeModel theme;
    #endregion

    #region Constructor/Destructor
    public BaseViewModel()
    {
        Theme_Lib.ThemeChangeEvent += ThemeChanged;

        ThemeChanged(Theme_Lib.ActivTheme);
    }
    ~BaseViewModel()
    {
        Theme_Lib.ThemeChangeEvent -= ThemeChanged;
    }
    #endregion

    #region Protected Calls
    protected virtual void ThemeChanged(ThemeModel _theme)
    {
        Theme = _theme;
    }
    #endregion
}

