using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Stay_Halal.MVVM.Model;
using System.Diagnostics;

namespace Stay_Halal.MVVM.ViewModel;

[QueryProperty(nameof(Model), nameof(Model))]
public partial class MessageViewModel : ObservableObject
{
    #region Private Data
    private MessageModel model;
    #endregion

    #region Public Data
    public MessageModel Model { set { model = value; UpdateView(); } get { return model; } }
    #endregion

    #region Ovservable
    [ObservableProperty]
    string title;
    [ObservableProperty]
    string message;
    [ObservableProperty]
    bool error;
    [ObservableProperty]
    string errorMessage;
    [ObservableProperty]
    string image;
    [ObservableProperty]
    bool buttonEnabled;
    [ObservableProperty]
    string buttonText;
    #endregion

    #region Relay Commands
    [RelayCommand]
    async void OnComfirm()
    {
        await Shell.Current.GoToAsync(Model.TargetRoute);
    }

    [RelayCommand]
    void OnEntryTextChanged()
    {
        errorMessage = Model.CustomeMessage;
    }
    #endregion

    #region Private Calls

    private void UpdateView()
    {
        Title = Model.Title;
        Message = Model.Message;

        if(!string.IsNullOrEmpty(Model.CustomeMessage))
        {
            Error = true;
            ErrorMessage = Model.CustomeMessage;
        }

        ButtonEnabled = Model.ButtonEnabled;
       
        ButtonText = Model.ButtonText;


        string path = Shell.Current.CurrentState.Location.ToString() + "/MessagePage";
        Debug.WriteLine(path);

        switch (Application.Current.RequestedTheme)
        {
            case AppTheme.Unspecified:
                Image = Model.Image_Light;
                break;
            case AppTheme.Light:
                Image = Model.Image_Light;
                break;
            case AppTheme.Dark:
                Image = Model.Image_Dark;
                break;
            default:
                Image = Model.Image_Light;
                break;
        }

    }
    private void UpdateTheme(object s, AppThemeChangedEventArgs e)
    {
     
        switch (e.RequestedTheme)
        {
            case AppTheme.Unspecified:
                Image = Model.Image_Light;
                break;
            case AppTheme.Light:
                Image = Model.Image_Light;
                break;
            case AppTheme.Dark:
                Image = Model.Image_Dark;
                break;

            default:
                Image = Model.Image_Light;
                break;
        }
    }
    #endregion

    #region Constructor/Destructor
    public MessageViewModel()
    {
        Application.Current.RequestedThemeChanged += UpdateTheme;
    }
    ~MessageViewModel()
    {
        Application.Current.RequestedThemeChanged -= UpdateTheme;
    }
    #endregion
}

