using CommunityToolkit.Mvvm.ComponentModel;
namespace Stay_Halal.Scripts.Libraries.Static;
public static class Localisation_Lib
{
    #region Universial
    public const string empty = "";
    public const string space = " ";
    public const string open = "(";
    public const string close = ")";
    #endregion
    #region Header
    public const string HeaderTitel = "Stay Halal";
    #endregion
    #region Flyout
    public const string FlyoutMenuItem_HauptMenü = "Hauptmenü";
    public const string FlyoutMenuItem_ProductScanner = "Product Scanner";
    public const string FlyoutMenuItem_Einstellung = "Einstellungen";
    public const string FlyoutMenuItem_Kontakt = "Kontakt";
    public const string FlyoutMenuItem_Info = "Informationen";
    #endregion
    #region MenuBar
    public const string MenuBarItem_BarCodeScanner = "Barcode Scanner";
    public const string MenuBarItem_ManualInput = "Manuelle Eingabe";
    #endregion
    #region View Title
    public const string ViewTitle_HauptMenü = "Hauptmenü";
    public const string ViewTitle_Einstellung = "Einstellungen";
    public const string ViewTitle_Contact = "Kontakt";
    public const string ViewTitle_Info = "Information";
    public const string ViewTitle_ManuelInput = "Manuelle Eingabe";
    public const string ViewTitle_BarcodeScanner = "Barcode Scanner";
    public const string ViewTitle_Product = "Product Auswertung";
    public const string ViewTitle_Welcome = "Willkommen";
    #endregion
    #region Info View
    public const string InfoAppTitle = "App Info";
    public const string InfoAppDesc = "Die App wurde mit net.7 Maui entwickelt. Diese nutzt c# und xaml";
    public const string InfoTeamTitle = "Über das Team";
    public const string InfoTeamDesc = "Diese App wurde im Zusammenhang mit der Projektwoche entwickelt";
    #endregion
    #region Contact View
    public const string ContactTitle = "Kontakt";
    public const string ContactDesc = "Sollte es zu Fehlern innerhalb der App kommen oder Produkte geben die sich nicht in unserer Datenbank befinden, können sie uns gerne über die folgenden Wege kontaktieren.";
    public const string ContactEmail = "kontakt@stayhalal.de";
    public const string ContactSocialMedia = "Socail Media";
    public const string ContactSocialMediaDesc = "Socail Media Inhalt";
    public const string ContactWebsite = "Website";
    public const string ContactFacebook = "Facebook";
    public const string ContactInstagram = "Instagram";
    #endregion
    #region Manual Input View
    public const string ManualInputTitle = "Manuelle Eingabe";
    public const string ManualInputDesc = "Bitte geben Sie hier die gewünschte Artikelnummer ein";
    public const string ManualInputPlaceHolder = "Artikelnummer eingeben";
    public const string ManualInputComfirmButton = "Bestätigen";
    #endregion
    #region Welcome View
    public const string WelcomeTitle = "Willkommen";
    public const string WelcomeDesc = "Herzlich Willkommen bei der Stay Halal App. Diese App wurde in Zusammenhang mit der Projektwoche an dem Emschertal Berufskolleg entwickelt.";
    public const string WelcomeInfoTitle = "Info";
    public const string WelcomeInfoDesc = "Unser Ziel ist es eine App für das Smartphone zu entwickeln, welche das Leben von praktizierenden Muslimen erleichtern soll, in dem unsere App Lebensmittel nach islamischen Prinzipien überprüft um den Verbraucher vor nicht zugelassenen Lebensmitteln auf Grund von nicht geduldeten Inhaltstoffen zu schützen.";
    public const string WelcomeButtonTitle = "Bestätigen";
    #endregion
    #region Setting View
    public const string SettingSonstigeTitle = "Sonstiges";
    public const string SettingThemeTitle = "Design";
    public const string SettingCachingTitle = "Data Caching";
    public const string SettingDefaultThemeTitle = "Standart";
    public const string SettingDarkThemeTitle = "Dunkel";
    public const string SettingLightThemeTitle = "Hell";
    #endregion
    #region MainMenu View
    public const string MainMenuFaqTitle = "FAQ";
    public const string MainMenuFaqDesc = "Hier erhälst du Antworten auf häufig gestellte Fragen";
    public const string MainMenuProductButton = "Product Scanner";
    #endregion
    #region Product View
    public const string ProductTitle = "Product Details";
    public const string ProductInhaltstoffeTitel = "Inhaltsstoffe";
    public const string ProductInhaltstoffeDesc = "inhaltsstoffe intro text";
    public const string ProductNameDesc = "Name: ";
    public const string ProductBarcodeIDDesc = "Barcode ID: ";
    public const string ProductHerstellerDec = "Hersteller: ";
    public const string ProductErgebnissUnbekannt = "Es liegen keine genaueren Informationen vom Hersteller vor, oder das Produkt wurde noch nicht in unserer Datenbank aufgelistet";
    public const string ProductErgebnissHalal = "Das Produkt ist durch ein Halal-Zertifizierungsinstitut als Halal ausgezeichnet";
    public const string ProductErgebnissHaram = "Das jeweilige Produkt beinhaltet einen Inhaltsstoff, welches nicht islamkonform ist";
    #endregion
    #region Team Member
    public const string Sliem_Name = "Sliem Beji";
    public const string Sliem_Desc = "Project Lead, Programmer";
    public const string Justin_Name = "Justin Szymikowski";
    public const string Justin_Desc = "Not Filled";
    public const string Shoaib_Name = "Shoaib Banai";
    public const string Shoaib_Desc = "Not Filled";
    public const string Amjad_Name = "Amjad Morad";
    public const string Amjad_Desc = "Not Filled";
    public const string David_Name = "David Rudnik";
    public const string David_Desc = "Not Filled";
    public const string Leon_Name = "Leon Schmitz";
    public const string Leon_Desc = "Not Filled";
    #endregion
}