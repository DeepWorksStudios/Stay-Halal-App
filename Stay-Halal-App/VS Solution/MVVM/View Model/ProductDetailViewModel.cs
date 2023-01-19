

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


    #endregion


    private void UpdateView()
    {
        

        ProductBarcodeID = Model.Barcode;
        ProductHersteller = Model.Hersteller;
        ProductName = Model.Title;

        Inhaltstoffe.Clear();

        bool haram = false;

        for(int i=0;i < Model.Inhaltsstoffe.Length;i++)
        {
            Inhaltstoffe.Add(Model.Inhaltsstoffe[i]);

            if (Model.Inhaltsstoffe[i].Type == Inhalt_Type.Haram) haram=true;
        }

    

        Debug.WriteLine(Model.Inhaltsstoffe.Length);

    }

    public ProductDetailViewModel() : base()
    {

        Title = Localisation_Lib.ViewTitle_Product;

        ProductTitel = Localisation_Lib.ProductTitel;
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
             
                break;
            case AppTheme.Light:
               
                break;
            case AppTheme.Dark:

                break;
        }
    }

    #endregion
}

