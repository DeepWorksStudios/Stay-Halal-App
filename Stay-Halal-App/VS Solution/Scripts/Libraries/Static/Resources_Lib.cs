using Stay_Halal.MVVM.Model;
using Stay_Halal.MVVM.Model.Cell;


namespace Stay_Halal.Scripts.Libraries.Static;
public static class Resources_Lib
{
    #region App

    #region Logo
    public const string CompanyLogo_ImageLight = "footer_light.png";
    public const string CompanyLogo_ImageDark = "footer_dark.png";
    public const string AppLogo_ImageLight = "applogo_light.svg";
    public const string AppLogo_ImageDark = "applogo_dark.svg";
    #endregion

    #region Links
    public const string WebsiteLink = "http://www.emschertal-berufskolleg.de/index.php/unsere-schule/standort-steinstrasse";
    public const string FacebookLink = "https://de-de.facebook.com/ebk.herne/";
    public const string InstagramLink = "https://www.instagram.com/ebk_steinstrasse/?hl=de";
    #endregion

    #region Models
    public static readonly TopBannerModel HeaderTheme = new(Lokalisation_Lib.HeaderTitel,
                                                                           AppLogo_ImageDark,
                                                                           AppLogo_ImageLight);
    #endregion

    #region Team Members
    public static TeamMemberModel Sliem = new()
    {
        Name = Lokalisation_Lib.Sliem_Name,
        Description = Lokalisation_Lib.Sliem_Desc,
        Pictrue = "sliem.png",
    };
    public static TeamMemberModel Shoaib = new()
    {
        Name = Lokalisation_Lib.Shoaib_Name,
        Description = Lokalisation_Lib.Shoaib_Desc,
        Pictrue = "shoiab.png",
    };
    public static TeamMemberModel Amjad = new()
    {
        Name = Lokalisation_Lib.Amjad_Name,
        Description = Lokalisation_Lib.Amjad_Desc,
        Pictrue = "amjad.png",
    };
    public static TeamMemberModel Justin = new()
    {
        Name = Lokalisation_Lib.Justin_Name,
        Description = Lokalisation_Lib.Justin_Desc,
        Pictrue = "justin.png",
    };
    public static TeamMemberModel David = new()
    {
        Name = Lokalisation_Lib.David_Name,
        Description = Lokalisation_Lib.David_Desc,
        Pictrue = "david.png",
    };
    public static TeamMemberModel Leon = new()
    {
        Name = Lokalisation_Lib.Leon_Name,
        Description = Lokalisation_Lib.Leon_Desc,
        Pictrue = "leon.png",
    };
    #endregion

    #region Scanner
    public static MessageModel ScannerFail = new("Produkt unbekannt", "Das Produkt welches Sie überprüfen lassen möchten ist uns nicht bekannt. Bitte stellen Sie sicher, dass Sie die korrekte Artikelnummer des gewünschten Produktes zur Überprüfung eingetragen wurde. Sollte Ihre Eingabe korrekt sein, wurde das Produkt welches Sie überprüfen lassen möchten, noch nicht in unser System aufgenommen. Wenn Sie uns bei der Optimierung und Vollständigkeit der App unterstützen möchten, dann rufen Sie bitte das Kontaktformular auf und reichen das unbekannte Produkt ein. Vielen Dank!", "unkown_light.svg", "unkown_dark.svg", false, "", "../..");
    public static MessageModel NoInput = new("Kein Barcode ID", "Die Eingabe war leer", "unkown_light.svg", "unkown_dark.svg", false, "", "../..");

    #endregion

    #region FAQ
    public static QAModel Qestion_1a = new()
    {
        QestionTitle = "Nutzer Standort relevant?",
        QestionDescription = "Kann ich die App nur in Deutschland nutzen?",
        AwnserTitle = "Nein, der Standort des Nutzers spielt überhaupt keine Rolle. Sie können unabhängig...",
        AwnserDescription = "Nein, der Standort des Nutzers spielt überhaupt keine Rolle. Sie können unabhängig ihres Standortes von unserer App profitieren, und jederzeit Produkte mit unserer App nach islamischen Prinzipien überprüfen lassen. Der Standort spielt dabei überhaupt keine Rolle."
    };
    public static QAModel Qestion_1b = new()
    {
        QestionTitle = "App auch ohne Internetverbindung?",
        QestionDescription = "Kann die App kann auch ohne Interverbindung genutzt werden?",
        AwnserTitle = "Ja, die App kann auch ohne eine aktive Interverbindung genutzt werden, wenn Sie in...",
        AwnserDescription = "Ja, die App kann auch ohne eine aktive Interverbindung genutzt werden, wenn Sie in den Einstellungen 'Data - Caching' aktiviert haben und die App einmalig mit einer aktiven Internetverbindung geladen haben. Hierbei werden jegliche Produkt für weitere Nutzungen lokal auf ihr Endgerät gespeichert, sodass keine aktive Internetverbindung mehr von Nöten ist, jedoch ist eine ständige Internetverbindung empfohlen wenn Sie auf dem aktuellsten Stand unserer Lebensmitteldatenbank sein möchten."
    };
    public static QAModel Qestion_1c = new()
    {
        QestionTitle = "Wie genau ist die App?",
        QestionDescription = "Wie genau ist die App und was tue ich wenn es zu Fehlern kommt?",
        AwnserTitle = "Natürlich können wir Ihnen keine hundertprozentige Garantie geben, dass die App komplett Fehler frei ist...",
        AwnserDescription = "Natürlich können wir Ihnen keine hundertprozentige Garantie geben, dass die App komplett Fehler frei ist. Wir sind ständig daran bemüht keine Fehler einzubauen. Unser Team hat ein hohes Qualitätsstandard um Fehler zu vermeiden. Sollte es dennoch zu Fehlern kommen, können Sie uns diesen gerne über das Kontaktformular melden, damit wir diesen so schnell wie Möglich beheben können."
    };
    public static QAModel Qestion_1d = new()
    {
        QestionTitle = "Weitere Infos zu Halal-Lebensmitteln?",
        QestionDescription = "Wo finde ich weitere Infos zu Halal-Lebensmitteln?",
        AwnserTitle = "Es gibt viele Quelle, doch wir beziehen unsere Information aus einem zertifizierten...",
        AwnserDescription = "Es gibt viele Quelle, doch wir beziehen unsere Information aus einem zertifizierten Institut, welches sich mit dem Thema Halal beschäftigt. Dort finden Sie weitere Informationen rund um das Thema Halal: https://halalpi.com/"
    };

    #endregion

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

    #region Manual Input View
    public const string Manual_TitleIcon_ImageDark = "shift_dark.svg";
    public const string Manual_TitleIcon_ImageLight = "shift_light.svg";
    #endregion

    #region Product Detail View
    public const string Product_DetailIcon_ImageLight = "inhalt_light.svg";
    public const string Product_InhaltIcon_ImageLight = "information_light.svg";
    public const string Product_DetailIcon_ImageDark = "inhalt_dark.svg";
    public const string Product_InhaltIcon_ImageDark = "information_dark.svg";
    public const string Product_RataingHalalIcon_ImageLight = "check_light.svg";
    public const string Product_RataingHaramIcon_ImageLight = "cross_light.svg";
    public const string Product_RataingUnkownIcon_ImageLight = "unkown_light.svg";
    public const string Product_RataingHalalIcon_ImageDark = "check_dark.svg";
    public const string Product_RataingHaramIcon_ImageDark = "cross_dark.svg";
    public const string Product_RataingUnkownIcon_ImageDark = "unkown_dark.svg";
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

    #region Info View
    public const string Info_AppTitleIcon_ImageDark = "info_dark.svg";
    public const string Info_AppTitleIcon_ImageLight = "info_light.svg";
    public const string Info_TeamIcon_ImageDark = "group_dark.svg";
    public const string Info_TeamIcon_ImageLight = "group_light.svg";
    #endregion
}