
using CommunityToolkit.Mvvm.ComponentModel;

using Stay_Halal.MVVM.Model;
using Stay_Halal.MVVM.Model.Cell;

namespace Stay_Halal.MVVM.ViewModel;

public partial class TopBannerViewModel : BaseViewModel
{
    #region Private Data
    private TopBannerModel data;
    #endregion

    #region Observable Data
    [ObservableProperty]
    string image;
    #endregion

    #region Public Calls
    public void SetupTheme(TopBannerModel _data)
    {
        data = _data;
        Title = data.Title;

        switch (Application.Current.RequestedTheme)
        {

            case AppTheme.Unspecified:
                Image = data.LogoImage_Light;

                break;
            case AppTheme.Light:
                Image = data.LogoImage_Light;

                break;
            case AppTheme.Dark:
                Image = data.LogoImage_Dark;

                break;

        }
    }
    #endregion

    #region Protected Calls
    protected override void ThemeChanged(ThemeModel _theme)
    {
        base.ThemeChanged(_theme);

        if (data == null)
            return;

        switch (_theme.ThemeTyp)
        {

            case AppTheme.Unspecified:
                Image = data.LogoImage_Light;

                break;
            case AppTheme.Light:
                Image = data.LogoImage_Light;

                break;
            case AppTheme.Dark:
                Image = data.LogoImage_Dark;

                break;

        }
    }
    #endregion
}
