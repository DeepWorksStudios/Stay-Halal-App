
using Stay_Halal.Scripts.Libraries.Dynamic;
using System.Diagnostics;

namespace Stay_Halal.Scripts.Helper;

public class StartupHelper
{
    private readonly Setting_Lib lib;

    public StartupHelper(Setting_Lib _lib)
    {
        lib = _lib;
       
        if (!lib.HasKey)
        {
           DisplayFirstStart();
        }
    }

    public void Check()
    {
        if (!lib.HasKey)
        {
           DisplayFirstStart();
        }
    }
    bool input=false;
    private async void DisplayFirstStart()
    {
        if (input) return;
        input = true;

        System.Diagnostics.Debug.WriteLine("Welcome");

        string route;
        string path;
#if ANDROID
        route = $"//WelcomeFlyout";
        path = route;          
        input = false;
#else
        route = $"WelcomePage";
        path  = Shell.Current.CurrentState.Location.ToString() + "/WelcomeView";
        
#endif
        
        await Shell.Current.GoToAsync(route);
        MauiProgram.navigationHelper.Look(route);

    }

}
