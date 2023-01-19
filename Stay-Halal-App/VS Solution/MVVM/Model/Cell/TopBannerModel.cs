namespace Stay_Halal.MVVM.Model.Cell;

public class TopBannerModel
{
    #region Private Data
    private readonly string title, logoImage_Light, logoImage_Dark;
    #endregion

    #region Public Data
    public string Title { get { return title; } }
    public string LogoImage_Dark { get { return logoImage_Dark; } }
    public string LogoImage_Light { get { return logoImage_Light; } }
    #endregion

    #region Constructor
    public TopBannerModel(string _title, string _logoImage_Dark, string _logoImage_Light)
    {
        title = _title;
        logoImage_Dark = _logoImage_Dark;
        logoImage_Light = _logoImage_Light;  
    }
    #endregion
}

