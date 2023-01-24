
using Stay_Halal.Scripts.Libraries.Dynamic;


namespace Stay_Halal.Scripts.Helper;

public class StartupHelper
{
    #region Private Data
    private readonly Setting_Lib lib;
    private bool input = false;
    #endregion

    #region Constructor/Destructor
    public StartupHelper(Setting_Lib _lib)
    {
        lib = _lib;
       
        if (!lib.HasKey)
        {
           DisplayFirstStart();
        }
    }
    #endregion

    #region Public Calls
    public void Check()
    {
        if (!lib.HasKey)
        {
            DisplayFirstStart();
        }
    }
    #endregion

    #region Private Calls
    private async void DisplayFirstStart()
    {
        if (input) return;
        input = true;

        System.Diagnostics.Debug.WriteLine("Welcome");

        string route;
        string path;

        route = $"//WelcomeFlyout";
        input = false;
        
        await Shell.Current.GoToAsync(route);
        MauiProgram.NavigationHelper.Look(route);

    }
    #endregion
}
