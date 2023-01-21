

using CommunityToolkit.Mvvm.ComponentModel;
using Stay_Halal.MVVM.Model;
using Stay_Halal.Scripts.Libraries.Static;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Stay_Halal.MVVM.ViewModel;

[QueryProperty(nameof(Model), nameof(Model))]
public partial class ProductDetailViewModel : BaseViewModel
{
    #region Private Data
    private ProductModel model;
    private Inhalt_Type resultValue;
    #endregion

    #region Public Data
    public ProductModel Model { set { model = value; UpdateView(); } get { return model; } }
    #endregion

    #region Observable Data 
    [ObservableProperty]
    private string productTitel;

    [ObservableProperty]
    private string productIcon;

    [ObservableProperty]
    private string productName;

    [ObservableProperty]
    private string productBarcodeID;

    [ObservableProperty]
    private string productHersteller;



    [ObservableProperty]
    private string productRatingText;

    [ObservableProperty]
    private string productRatingIcon;

    [ObservableProperty]
    private string inhaltsstoffeTitel;


    [ObservableProperty]
    private string inhaltsstoffeIcon;


    [ObservableProperty]
    private string inhaltsstoffeDesc;

    public ObservableCollection<InhaltsstoffModel> Inhaltstoffe { get; set; } = new ObservableCollection<InhaltsstoffModel>();


    [ObservableProperty]
    Color productRatingColor;

    #endregion


    private void UpdateView()
    {
        ProductBarcodeID = Model.Barcode;
        ProductHersteller = Model.Hersteller;
        ProductName = Model.Title;

        Inhaltstoffe.Clear();

        bool result = false;
        resultValue = Inhalt_Type.Halal;
      
        for(int i=0;i < Model.Inhaltsstoffe.Length;i++)
        {
            
         

            
              

            Inhaltstoffe.Add(Model.Inhaltsstoffe[i]);

            if (result) continue;

            if (Model.Inhaltsstoffe[i].Type == Inhalt_Type.Unknown) resultValue = Inhalt_Type.Unknown;
            if (Model.Inhaltsstoffe[i].Type == Inhalt_Type.Haram)
            {
                resultValue = Inhalt_Type.Haram;
                result=true;
            }
                
        }

        switch (resultValue)
        {
            case Inhalt_Type.Halal:
                ProductRatingText = Localisation_Lib.ProductErgebnissHalal;
                ProductRatingColor = Color.Parse("#009B54");
                break;
            case Inhalt_Type.Haram:
                ProductRatingText=Localisation_Lib.ProductErgebnissHaram;
                ProductRatingColor = Color.Parse("#CE0C1F");
                break;
            case Inhalt_Type.Unknown:
                ProductRatingText = Localisation_Lib.ProductErgebnissUnbekannt;
                ProductRatingColor = Color.Parse("#FF9B54");
                break;
        }

        switch (Theme.ThemeTyp)
        {
            case AppTheme.Unspecified:
                ProductIcon = Resources_Lib.Product_DetailIcon_ImageLight;
                InhaltsstoffeIcon = Resources_Lib.Product_InhaltIcon_ImageLight;

                switch (resultValue)
                {
                    case Inhalt_Type.Halal:
                        ProductRatingIcon = Resources_Lib.Product_RataingHalalIcon_ImageLight;
                        break;
                    case Inhalt_Type.Haram:
                        ProductRatingIcon = Resources_Lib.Product_RataingHaramIcon_ImageLight;
                        break;
                    case Inhalt_Type.Unknown:
                        ProductRatingIcon = Resources_Lib.Product_RataingUnkownIcon_ImageLight;
                        break;
                }
                break;
            case AppTheme.Light:
                ProductIcon = Resources_Lib.Product_DetailIcon_ImageLight;
                InhaltsstoffeIcon = Resources_Lib.Product_InhaltIcon_ImageLight;

                switch (resultValue)
                {
                    case Inhalt_Type.Halal:
                        ProductRatingIcon = Resources_Lib.Product_RataingHalalIcon_ImageLight;
                        break;
                    case Inhalt_Type.Haram:
                        ProductRatingIcon = Resources_Lib.Product_RataingHaramIcon_ImageLight;
                        break;
                    case Inhalt_Type.Unknown:
                        ProductRatingIcon = Resources_Lib.Product_RataingUnkownIcon_ImageLight;
                        break;
                }
                break;
            case AppTheme.Dark:
                ProductIcon = Resources_Lib.Product_DetailIcon_ImageDark;
                InhaltsstoffeIcon = Resources_Lib.Product_InhaltIcon_ImageDark;

                switch (resultValue)
                {
                    case Inhalt_Type.Halal:
                        ProductRatingIcon = Resources_Lib.Product_RataingHalalIcon_ImageDark;
                        break;
                    case Inhalt_Type.Haram:
                        ProductRatingIcon = Resources_Lib.Product_RataingHaramIcon_ImageDark;
                        break;
                    case Inhalt_Type.Unknown:
                        ProductRatingIcon = Resources_Lib.Product_RataingUnkownIcon_ImageDark;
                        break;
                }
                break;
        }

    }

    public ProductDetailViewModel() : base()
    {

        Title = Localisation_Lib.ViewTitle_Product;

        ProductTitel = Localisation_Lib.ProductTitle;
        InhaltsstoffeTitel = Localisation_Lib.ProductInhaltstoffeTitel;
        InhaltsstoffeDesc = Localisation_Lib.ProductInhaltstoffeDesc;
    }

    #region Protected Calls

    protected override void ThemeChanged(ThemeModel _theme)
    {
        base.ThemeChanged(_theme);

        if (Model == null) return;

        switch (_theme.ThemeTyp)
        {
            case AppTheme.Unspecified:
                ProductIcon = Resources_Lib.Product_DetailIcon_ImageLight;
                InhaltsstoffeIcon = Resources_Lib.Product_InhaltIcon_ImageLight;

                switch (resultValue)
                {
                    case Inhalt_Type.Halal:
                        ProductRatingIcon = Resources_Lib.Product_RataingHalalIcon_ImageLight;
                        break;
                    case Inhalt_Type.Haram:
                        ProductRatingIcon = Resources_Lib.Product_RataingHaramIcon_ImageLight;
                        break;
                    case Inhalt_Type.Unknown:
                        ProductRatingIcon = Resources_Lib.Product_RataingUnkownIcon_ImageLight;
                        break;
                }
                break;
            case AppTheme.Light:
                ProductIcon = Resources_Lib.Product_DetailIcon_ImageLight;
                InhaltsstoffeIcon = Resources_Lib.Product_InhaltIcon_ImageLight;

                switch (resultValue)
                {
                    case Inhalt_Type.Halal:
                        ProductRatingIcon = Resources_Lib.Product_RataingHalalIcon_ImageLight;
                        break;
                    case Inhalt_Type.Haram:
                        ProductRatingIcon = Resources_Lib.Product_RataingHaramIcon_ImageLight;
                        break;
                    case Inhalt_Type.Unknown:
                        ProductRatingIcon = Resources_Lib.Product_RataingUnkownIcon_ImageLight;
                        break;
                }
                break;
            case AppTheme.Dark:
                ProductIcon = Resources_Lib.Product_DetailIcon_ImageDark;
                InhaltsstoffeIcon = Resources_Lib.Product_InhaltIcon_ImageDark;

                switch (resultValue)
                {
                    case Inhalt_Type.Halal:
                        ProductRatingIcon = Resources_Lib.Product_RataingHalalIcon_ImageDark;
                        break;
                    case Inhalt_Type.Haram:
                        ProductRatingIcon = Resources_Lib.Product_RataingHaramIcon_ImageDark;
                        break;
                    case Inhalt_Type.Unknown:
                        ProductRatingIcon = Resources_Lib.Product_RataingUnkownIcon_ImageDark;
                        break;
                }
                break;
        }
    }

    #endregion
}

