

using CommunityToolkit.Mvvm.ComponentModel;
using Stay_Halal.MVVM.Model;
using Stay_Halal.Scripts.Libraries.Static;
using System.Collections.ObjectModel;

namespace Stay_Halal.MVVM.ViewModel;

public partial class InfoViewModel : BaseViewModel
{

    #region Observable Data 
    [ObservableProperty]
    private string appTitle;

    [ObservableProperty]
    private string appDesc;

    [ObservableProperty]
    private string appIcon;

    [ObservableProperty]
    private string teamTitle;

    [ObservableProperty]
    private string teamDesc;

    [ObservableProperty]
    private string teamIcon;

    [ObservableProperty]
    private string appLogo;

    public ObservableCollection<TeamMemberModel> TeamMembers { get; set; } = new ObservableCollection<TeamMemberModel>();


    #endregion

    #region Constructor/Destructor
    public InfoViewModel() : base()
    {

        Title = Localisation_Lib.ViewTitle_Info;
        AppTitle = Localisation_Lib.InfoAppTitle;
        AppDesc = Localisation_Lib.InfoAppDesc;

        TeamTitle = Localisation_Lib.InfoTeamTitle;
        TeamDesc = Localisation_Lib.InfoTeamDesc;

       

       

        LoadTeam();
    }

    #endregion

    #region Private Data
    private List<TeamMemberModel> team = new List<TeamMemberModel>
    {
        Resources_Lib.Sliem,
        Resources_Lib.Justin,
        Resources_Lib.Shoaib,
        Resources_Lib.Amjad,
        Resources_Lib.David,
        Resources_Lib.Leon
    };
    #endregion

    #region Private Calls
    private async void LoadTeam()
    {
        for(int i=0;i< team.Count;i++)
        {
            await Task.Delay(750);
            TeamMembers.Add(team[i]);
        }
        
    }
    #endregion

    #region Protected Calls
    protected override void ThemeChanged(ThemeModel _theme)
    {
        base.ThemeChanged(_theme);

        switch (_theme.ThemeTyp)
        {
            case AppTheme.Unspecified:
                AppIcon = Resources_Lib.Info_AppTitleIcon_ImageLight;
                TeamIcon = Resources_Lib.Info_TeamIcon_ImageLight;
                AppLogo = Resources_Lib.AppLogo_ImageLight;
                break;
            case AppTheme.Light:
                AppIcon = Resources_Lib.Info_AppTitleIcon_ImageLight;
                TeamIcon = Resources_Lib.Info_TeamIcon_ImageLight;
                AppLogo = Resources_Lib.AppLogo_ImageLight;
                break;
            case AppTheme.Dark:
                AppIcon = Resources_Lib.Info_AppTitleIcon_ImageDark;
                TeamIcon = Resources_Lib.Info_TeamIcon_ImageDark;
                AppLogo = Resources_Lib.AppLogo_ImageDark;
                break;
        }
    }
    #endregion
}

