using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Stay_Halal.MVVM.Model;
using Stay_Halal.Scripts.Libraries.Dynamic;
using System.Diagnostics;

namespace Stay_Halal.MVVM.ViewModel;

[QueryProperty(nameof(Model), nameof(Model))]
public partial class MessageViewModel : BaseViewModel
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
    bool goBackEnabled;
    [ObservableProperty]
    string buttonText;
    #endregion

    #region Relay Commands
    [RelayCommand]
    async void OnComfirm()
    {
        if (!Model.Unlook) MauiProgram.NavigationHelper.Continue(1); else MauiProgram.NavigationHelper.Unlook();
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

        if (!string.IsNullOrEmpty(Model.CustomeMessage))
        {
            Error = true;
            ErrorMessage = Model.CustomeMessage;
        }

        ButtonEnabled = Model.ButtonEnabled;
        GoBackEnabled = !Model.ButtonEnabled;
        ButtonText = Model.ButtonText;


        string path = Shell.Current.CurrentState.Location.ToString() + "/MessagePage";
        Debug.WriteLine(path);

        if (ButtonEnabled) MauiProgram.NavigationHelper.Look(path);

        Image = Theme_Lib.CurrentTheme switch
        {
            AppTheme.Unspecified => Model.Image_Light,
            AppTheme.Light => Model.Image_Light,
            AppTheme.Dark => Model.Image_Dark,
            _ => Model.Image_Light,
        };
    }
 
    #endregion

    #region Protected Calls
    
    protected override void ThemeChanged(ThemeModel _theme)
    {
        base.ThemeChanged(_theme);

        if (Model == null) return;

        switch (_theme.ThemeTyp)
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
        }
    }
    
    #endregion
}

