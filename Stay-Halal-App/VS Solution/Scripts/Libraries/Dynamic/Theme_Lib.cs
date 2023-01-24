using Stay_Halal.MVVM.Model;
using System.Diagnostics;


namespace Stay_Halal.Scripts.Libraries.Dynamic;
public class Theme_Lib
{
    #region Private Data
    private static readonly List<Color> _randomeColorList = new()
        {
            Colors.AliceBlue, Colors.AntiqueWhite, Colors.Aqua,
            Colors.Aquamarine, Colors.Chocolate, Colors.Red,
            Colors.SeaGreen, Colors.BlueViolet,Colors.Coral,
            Colors.DarkGreen,Colors.DarkBlue,Colors.DarkCyan,
            Colors.DarkGoldenrod,Colors.DarkMagenta
};

    private static readonly ThemeModel lightTheme = new(AppTheme.Light,
                                                       "#40D690",
                                                         "#9AD870",
                                                         "#D8B100",
                                                         "#C8CECC",
                                                          "#000000",
                                                          "#000001",
                                                          "#606060",
                                                          "#3A4D5E",
                                                          "#A2ACAD");


    private static readonly ThemeModel darkTheme = new(AppTheme.Dark,
                                                          "#305559",
                                                          "#7FB77E",
                                                          "#ADCC94",
                                                          "#555555",
                                                         "#FFFFFF",
                                                         "#FFFFF1",
                                                         "#606060",
                                                         "#A2ACAD",
                                                         "#535F60");

      




    private static AppTheme currentTheme;
    private static ThemeModel activTheme;
    private static bool _init = false;
    #endregion

    #region Public Data

    public static AppTheme CurrentTheme { get { return currentTheme; } }

    public static ThemeEvent ThemeChangeEvent;

    public static ThemeModel ActivTheme { get { return activTheme; } }

    #endregion

    #region Private Calls
    private static void OnThemeChanged(object sender, AppThemeChangedEventArgs e)
    {
        Debug.WriteLine("Theme Request Change!");
        UpdateTheme(e.RequestedTheme);
    }
    private static void UpdateTheme(AppTheme appTheme)
    {
        currentTheme = appTheme;

        switch (appTheme)
        {
            case AppTheme.Unspecified:
                activTheme = lightTheme;
                ThemeChangeEvent?.Invoke(lightTheme);

                break;
            case AppTheme.Light:
                activTheme = lightTheme;

                ThemeChangeEvent?.Invoke(lightTheme);

                break;
            case AppTheme.Dark:
                activTheme = darkTheme;
                ThemeChangeEvent?.Invoke(darkTheme);


                break;
            default: activTheme = lightTheme; ThemeChangeEvent?.Invoke(lightTheme); break;
        }
        
    }
    #endregion

    #region Public Calls
    public static Color GetRandomeColor()
    {
        return _randomeColorList[new Random().Next(_randomeColorList.Count)];
    }
    public static void Init()
    {
        if (_init)
        {
            Debug.WriteLine("Theme Lib Already Init!");
            return;
        }
        else if (Application.Current == null)
        {
            Debug.WriteLine("Theme Lib Init Fault!");
            Debug.WriteLine("Application Instance Empty");
            return;
        }

        _init = true;

        Application.Current.RequestedThemeChanged += OnThemeChanged;
        UpdateTheme(Application.Current.RequestedTheme);
    }
    #endregion
  
    #region Constructor/Destructor
    public Theme_Lib()
    {
    
    }
    ~Theme_Lib()
    {
        if (!_init) return;      
        Application.Current.RequestedThemeChanged -= OnThemeChanged;
    }
    #endregion
}

