
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Stay_Halal.MVVM.Model;
using Stay_Halal.MVVM.View;
using Stay_Halal.Scripts.Libraries.Static;
using System.Collections.ObjectModel;

namespace Stay_Halal.MVVM.ViewModel;

public partial class MainMenuViewModel : BaseViewModel
{

    #region Observable Data 
    [ObservableProperty]
    private string faqTitel;

    [ObservableProperty]
    private string faqDesc;

    [ObservableProperty]
    private string faqIcon;

    [ObservableProperty]
    private string productButtonText;

    public ObservableCollection<QAModel> Qestions { get; set; } = new ObservableCollection<QAModel>();
    #endregion

    #region Private Data
    private List<QAModel> qestiondata = new List<QAModel>
    {
        
    };
    #endregion

    #region Relay Command
    [RelayCommand]
    private async void OnProduct()
    {
     
        string route = $"//ProductMenu";
        
        await Shell.Current.GoToAsync(route);
    }
    #endregion

    #region Constructor/Destructor
    public MainMenuViewModel() : base()
    {
        Title = Localisation_Lib.ViewTitle_HauptMenü;
        FaqTitel = Localisation_Lib.MainMenuFaqTitle;
        FaqDesc = Localisation_Lib.MainMenuFaqDesc;
        ProductButtonText = Localisation_Lib.MainMenuProductButton;


        qestiondata.Add(Resources_Lib.Qestion_1a);
        qestiondata.Add(Resources_Lib.Qestion_1b);
        qestiondata.Add(Resources_Lib.Qestion_1c);
        qestiondata.Add(Resources_Lib.Qestion_1d);


        LoadQestion();
    }
    #endregion

    #region Private Calls
    private async void LoadQestion()
    {
        for (int i = 0; i < qestiondata.Count; i++)
        {
            await Task.Delay(1000);
            Qestions.Add(qestiondata[i]);
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
                FaqIcon = Resources_Lib.MainMenu_FAQ_ImageLight;
                break;
            case AppTheme.Light:
                FaqIcon = Resources_Lib.MainMenu_FAQ_ImageLight;
                break;
            case AppTheme.Dark:
                FaqIcon = Resources_Lib.MainMenu_FAQ_ImageDark;
                break;
        }
    }
    #endregion

    #region Public Calls
    public async void OnOpenFAQ(int i)
    {
        MessageModel customMsg = new MessageModel(Qestions[i].QestionTitle, Qestions[i].QestionDescription + "\n" + Qestions[i].AwnserDescription, Resources_Lib.MainMenu_FAQ_ImageLight, Resources_Lib.MainMenu_FAQ_ImageDark, false, Localisation_Lib.empty, "../..");

        string route = $"{nameof(MessagePage)}";
        Dictionary<string, object> parameters = new() { ["Model"] = customMsg };

        await Shell.Current.GoToAsync(route, parameters);
    }
    #endregion
}

