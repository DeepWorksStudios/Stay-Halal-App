


namespace Stay_Halal.MVVM.Model;


public delegate void ThemeEvent(ThemeModel theme);

public class ThemeModel
{
    #region Private Data
    private AppTheme themeTyp;


    private Color mainColor;
    private Color secondColor;
    private Color thirdColor;
    private Color fourthColor;

    private Color mainTextColor;
    private Color secondTextColor;
    private Color disabledColor;
    private Color selectedColor;
    private Color unselectedColor;

    private LinearGradientBrush backgroundGradient;
    private LinearGradientBrush backgroundGradientv2;
    private LinearGradientBrush backgroundIconGradient;
    private LinearGradientBrush backgroundButtonGradient;
    #endregion

    #region Public Data
    public AppTheme ThemeTyp { get { return themeTyp; } }


    public Color MainColor { get { return mainColor; } }
    public Color SecondColor { get { return secondColor; } }
    public Color ThirdColor { get { return thirdColor; } }
    public Color FourthColor { get { return fourthColor; } }

    public Color MainTextColor { get { return mainTextColor; } }
    public Color SecondTextColor { get { return secondTextColor; } }
    public Color DisabledColor { get { return disabledColor; } }
    public Color SelectedColor { get { return selectedColor; } }
    public Color UnselectedColor { get { return unselectedColor; } }

    public LinearGradientBrush BackgroundGradient
    {
        get
        {
            return backgroundGradient;
        }
    }

    public LinearGradientBrush BackgroundGradientv2
    {
        get
        {
            return backgroundGradientv2;
        }
    }

    public LinearGradientBrush BackgroundIconGradient
    {
        get
        {
            return backgroundIconGradient;
        }
    }

    public LinearGradientBrush BackgroundButtonGradient
    {
        get
        {
            return backgroundButtonGradient;
        }
    }
    #endregion

    #region Constructor
    public ThemeModel(AppTheme _theme, string _mainColor, string _secondColor, string _thirdColor, string _fourthColor, string _mainTextColor, string _secondTextColor, string _disabledColor, string _selectedColor, string _unselectedColor)
    {
        themeTyp = _theme;

        mainColor = Color.Parse(_mainColor);
        secondColor = Color.Parse(_secondColor);
        thirdColor = Color.Parse(_thirdColor);
        fourthColor = Color.Parse(_fourthColor);
        mainTextColor = Color.Parse(_mainTextColor);
        secondTextColor = Color.Parse(_secondTextColor);
        disabledColor = Color.Parse(_disabledColor);
        selectedColor = Color.Parse(_selectedColor);
        unselectedColor = Color.Parse(_unselectedColor);




        backgroundGradient = new LinearGradientBrush()
        {
            StartPoint = new Point(0, 0),
            EndPoint = new Point(0, 1),

            GradientStops = new GradientStopCollection
                    {
                        new GradientStop { Color = mainColor, Offset = 0.0f },
                        new GradientStop { Color = secondColor, Offset = 1.0f }
                    }
        };

        backgroundGradientv2 = new LinearGradientBrush()
        {
            StartPoint = new Point(1, 0),
            EndPoint = new Point(0, 1),

            GradientStops = new GradientStopCollection
                    {
                        new GradientStop { Color = fourthColor, Offset = 0.0f },
                        new GradientStop { Color = secondColor, Offset = 0.8f }
                    }
        };

        backgroundButtonGradient = new LinearGradientBrush()
        {
            StartPoint = new Point(2, 0),
            EndPoint = new Point(0, 4),

            GradientStops = new GradientStopCollection
                    {
                        new GradientStop { Color = fourthColor, Offset = 0.0f },
                        new GradientStop { Color = thirdColor, Offset = 1.0f }
                    }
        };

        backgroundIconGradient = new LinearGradientBrush()
        {
            StartPoint = new Point(1, 0),
            EndPoint = new Point(0, 1),

            GradientStops = new GradientStopCollection
                    {
                        new GradientStop { Color = mainColor, Offset = 0.0f },
                        new GradientStop { Color = thirdColor, Offset = 1.0f }
                    }
        };
    }
    #endregion
}



