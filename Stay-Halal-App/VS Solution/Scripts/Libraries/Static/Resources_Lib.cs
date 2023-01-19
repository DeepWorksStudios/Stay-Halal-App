using Stay_Halal.MVVM.Model;
using Stay_Halal.MVVM.Model.Cell;

namespace Stay_Halal.Scripts.Libraries.Static;

public static class Resources_Lib
{
    #region App
    public const string CompanyLogo_ImageLight = "footer_light.png";
    public const string CompanyLogo_ImageDark = "footer_dark.png";

    public const string AppLogo_ImageLight = "applogo_light.svg";
    public const string AppLogo_ImageDark = "applogo_dark.svg";
    #endregion

    #region Flyout
    public const string FlyoutMenuItem_HauptMenü_ImageDark = "home_dark.svg";
    public const string FlyoutMenuItem_ProductScanner_ImageDark = "barcode_dark.svg";
    public const string FlyoutMenuItem_Einstellung_ImageDark = "settings_dark.svg";
    public const string FlyoutMenuItem_Kontakt_ImageDark = "brief_dark.svg";
    public const string FlyoutMenuItem_Info_ImageDark = "info_dark.svg";

    public const string FlyoutMenuItem_HauptMenü_ImageLight = "home_light.svg";
    public const string FlyoutMenuItem_ProductScanner_ImageLight = "barcode_light.svg";
    public const string FlyoutMenuItem_Einstellung_ImageLight = "settings_light.svg";
    public const string FlyoutMenuItem_Kontakt_ImageLight = "brief_light.svg";
    public const string FlyoutMenuItem_Info_ImageLight = "info_light.svg";
    #endregion

    #region MenuBar
    public const string MenuBarItem_BarCode_ImageLight = "barcode_light.svg";
    public const string MenuBarItem_ManualInput_ImageLight = "shift_light.svg";
    public const string MenuBarItem_BarCode_ImageDark = "barcode_dark.svg";
    public const string MenuBarItem_ManualInput_ImageDark = "shift_dark.svg";
    #endregion

    #region Info View
    public const string Info_AppTitleIcon_ImageDark = "document_dark.svg";
    public const string Info_AppTitleIcon_ImageLight = "document_light.svg";

    public const string Info_TeamIcon_ImageDark = "document_dark.svg";
    public const string Info_TeamIcon_ImageLight = "document_light.svg";
    #endregion

    #region Contact View
    public const string Contact_TitleIcon_ImageDark = "document_dark.svg";
    public const string Contact_TitleIcon_ImageLight = "document_light.svg";
    public const string Contact_WebsiteIcon_ImageLight = "document_light.svg";
    public const string Contact_FacebookIcon_ImageLight = "document_light.svg";
    public const string Contact_InstagramIcon_ImageLight = "document_light.svg";
    public const string Contact_SocialIcon_ImageLight = "document_light.svg";
    public const string Contact_WebsiteIcon_ImageDark = "document_dark.svg";
    public const string Contact_FacebookIcon_ImageDark = "document_dark.svg";
    public const string Contact_InstagramIcon_ImageDark = "document_dark.svg";
    public const string Contact_SocialIcon_ImageDark = "document_dark.svg";


    #endregion

    #region Links
    public const string WebsiteLink = "http://www.emschertal-berufskolleg.de/index.php/unsere-schule/standort-steinstrasse";
    public const string FacebookLink = "https://de-de.facebook.com/ebk.herne/";
    public const string InstagramLink = "https://www.instagram.com/ebk_steinstrasse/?hl=de";
    #endregion

    #region Models
    public static readonly TopBannerModel HeaderTheme = new TopBannerModel(Localisation_Lib.HeaderTitel,
                                                                           AppLogo_ImageDark,
                                                                           AppLogo_ImageLight);


    #endregion

    #region Team Members

    public static  TeamMemberModel Sliem = new TeamMemberModel()
    {
        Name = Localisation_Lib.Sliem_Name,
        Description = Localisation_Lib.Sliem_Desc,
        Pictrue = "sliem.png",

    };

    public static  TeamMemberModel Shoaib = new TeamMemberModel()
    {
        Name = Localisation_Lib.Shoaib_Name,
        Description = Localisation_Lib.Shoaib_Desc,
        Pictrue = "shoiab.png",

    };

    public static  TeamMemberModel Amjad = new TeamMemberModel()
    {
        Name = Localisation_Lib.Amjad_Name,
        Description = Localisation_Lib.Amjad_Desc,
        Pictrue = "amjad.png",
    };

    public static  TeamMemberModel Justin = new TeamMemberModel()
    {
        Name = Localisation_Lib.Justin_Name,
        Description = Localisation_Lib.Justin_Desc,
        Pictrue = "justin.png",

    };

    public static  TeamMemberModel David = new TeamMemberModel()
    {
        Name = Localisation_Lib.David_Name,
        Description = Localisation_Lib.David_Desc,
        Pictrue = "david.png",

    };

    public static  TeamMemberModel Leon = new TeamMemberModel()
    {
        Name = Localisation_Lib.Leon_Name,
        Description = Localisation_Lib.Leon_Desc,
        Pictrue = "leon.png",

    };
    #endregion

}

