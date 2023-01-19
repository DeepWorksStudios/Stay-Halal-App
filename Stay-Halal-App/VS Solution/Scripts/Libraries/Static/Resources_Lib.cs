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

    #region Navigation
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
    #endregion

    #region Info View
    public const string Info_AppTitleIcon_ImageDark = "info_dark.svg";
    public const string Info_AppTitleIcon_ImageLight = "info_light.svg";

    public const string Info_TeamIcon_ImageDark = "group_dark.svg";
    public const string Info_TeamIcon_ImageLight = "group_light.svg";
    #endregion

    #region Contact View
    public const string Contact_TitleIcon_ImageDark = "email_dark.svg";
    public const string Contact_TitleIcon_ImageLight = "email_light.svg";
    public const string Contact_WebsiteIcon_ImageLight = "www_light.svg";
    public const string Contact_FacebookIcon_ImageLight = "facebook_light.svg";
    public const string Contact_InstagramIcon_ImageLight = "instagram_light.svg";
    public const string Contact_SocialIcon_ImageLight = "network_light.svg";
    public const string Contact_WebsiteIcon_ImageDark = "www_dark.svg";
    public const string Contact_FacebookIcon_ImageDark = "facebook_dark.svg";
    public const string Contact_InstagramIcon_ImageDark = "instagram_dark.svg";
    public const string Contact_SocialIcon_ImageDark = "network_dark.svg";


    #endregion

    #region Manual Input View
    public const string Manual_TitleIcon_ImageDark = "shift_dark.svg";
    public const string Manual_TitleIcon_ImageLight = "shift_light.svg";
    #endregion

    #region Welcome View
    public const string Welcome_TitleIcon_ImageDark = "opportunity_dark.svg";
    public const string Welcome_TitleIcon_ImageLight = "opportunity_light.svg";
    public const string Welcome_InfoIcon_ImageDark = "info_dark.svg";
    public const string Welcome_InfoIcon_ImageLight = "info_light.svg";
    #endregion

    #region MainMenu View 
    public const string MainMenu_FAQ_ImageLight = "faq_light.svg";
    public const string MainMenu_FAQ_ImageDark = "faq_dark.svg";
    #endregion



    #region Setting View
    public const string Setting_DesignIcon_ImageLight = "paint_light.svg";
    public const string Setting_SonstigesIcon_ImageLight = "list_light.svg";

    public const string Setting_DesignDefault_ImageLight = "system_light.png";
    public const string Setting_DesignLight_ImageLight = "lightbulb_light.png";
    public const string Setting_DesignDark_ImageLight = "darkbulb_light.png";

    public const string Setting_DesignIcon_ImageDark = "paint_dark.svg";
    public const string Setting_SonstigesIcon_ImageDark = "list_dark.svg";

    public const string Setting_DesignDefault_ImageDark = "system_dark.png";
    public const string Setting_DesignLight_ImageDark = "lightbulb_dark.png";
    public const string Setting_DesignDark_ImageDark = "darkbulb_dark.png";

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

    #region FAQ 
    public static QAModel Qestion_1a = new QAModel() { QestionTitle = "Frage Title", QestionDescription = "Volle frage max char muss bestimmt werden", AwnserTitle = "darum", AwnserDescription = "test" };
    #endregion

}

