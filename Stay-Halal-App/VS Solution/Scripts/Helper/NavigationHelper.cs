using System.Diagnostics;

namespace Stay_Halal.Scripts.Helper;

public class NavigationHelper
{
    #region Private Data
    private Shell shell;
    private bool canContinue = false,unlooked=true,init=false;
    private int times=0;
    private int steps = 0,completedSteps=0;
    private string route = "";
    private string[] reRouting;
    private bool desteniArrive;
    #endregion

    #region Constructor/Destructor
    public void Init()
    {
        if (init) return; 
        Debug.WriteLine("Init");
        init = true;

        shell = Shell.Current;
        shell.Navigating += Current_Navigating;
        shell.Navigated += Current_Navigated;

        reRouting = new string[] { "//ProductMenu/BarcodeScannerView", "//ProductMenu/ManualInputView", "//Setting/SettingView"
        , "//Contact/ContactView","//Info/InfoView"};
    }
    ~ NavigationHelper()
    {
        if (!init) return;
        shell.Navigating -= Current_Navigating;
        shell.Navigated -= Current_Navigated;
    }
    #endregion

    #region Public Calls
    public void Look(string _route)
    {
        Shell.Current.FlyoutIsPresented = false;
        Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;
        Debug.WriteLine("Look");
        route = _route;
        unlooked = false;
    }
    public void Unlook()
    {
        Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
        Debug.WriteLine("Unlook");
        route = "";
        unlooked = true;
    }

    public void Continue(int _times)
    {


        Debug.WriteLine("Continue: " + _times);
        canContinue = true;
        times = _times;
        steps = 0;
    }
    #endregion

    #region Private Calls
    private void Current_Navigating(object sender, ShellNavigatingEventArgs e)
    {
        Debug.WriteLine("Navigating");
        Debug.WriteLine(e.Current.Location + " >> " + e.Target.Location);

        if (desteniArrive && string.IsNullOrEmpty(e.Target.Location.ToString()))
        {
            for (int i = 0; i < reRouting.Length; i++)
            {
                if (string.Equals(e.Current.Location.ToString(), reRouting[i]))
                {
                    Debug.WriteLine("Matched Reouting");
                    e.Cancel();
                    desteniArrive = false;
                    GoHome();
                    return;
                }
            }
        }
      

       

        if (unlooked) return;

        if (!canContinue || steps >= times)
        {
            e.Cancel();

        }
        steps++;
        Debug.WriteLine("Allowed is " + times);
        Debug.WriteLine("Consumed is " + steps);

    }
    private void Current_Navigated(object sender, ShellNavigatedEventArgs e)
    {
        desteniArrive = true;
        if (unlooked) return;
        Debug.WriteLine("Route to ignore = " + route);
        if (string.Equals(e.Current.Location.ToString(), route)) return;

        Debug.WriteLine("Navigated");
        Debug.WriteLine(e.Previous.Location + " >> " + e.Current.Location);
        Debug.WriteLine(e.Previous.Location.ToString().Split('/').Length + " >> " + e.Current.Location.ToString().Split('/').Length);


     
        int amount = Math.Abs(e.Previous.Location.ToString().Split('/').Length - e.Current.Location.ToString().Split('/').Length);
       
        
        if(steps > (completedSteps+1))
            completedSteps = steps;

        int leftover = times - completedSteps;

      

        Debug.WriteLine("LeftOverToContinue = " + leftover);
    
      
        if (amount > leftover )
        {
           
            string path="";
            for(int i=0;i< e.Current.Location.ToString().Split('/').Length-1;i++)
            {
        
                path+=e.Current.Location.ToString().Split('/')[i];
                if(i< e.Current.Location.ToString().Split('/').Length-2) path += "/";
            }
            Debug.WriteLine("SKIPPED!!!  Amount= " + amount + "\nRevent to path\n" + path);
            GoTO(path);
        }
        
            completedSteps++;

        if (completedSteps >= times)
        {
            canContinue = false;
            steps = 0;
            completedSteps = 0;
            times = 0;
        }


    }
    private async void GoHome()
    {

        var route = $"//MainMenu";
        await Shell.Current.GoToAsync(route); //await Shell.Current.fly;
    }
    private async void GoTO(string path)
    {
        Unlook();
        await Shell.Current.GoToAsync(path);
        Look(path);
    }
    #endregion
}
