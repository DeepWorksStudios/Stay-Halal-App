

using CommunityToolkit.Mvvm.ComponentModel;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.ViewModel;

public partial class BarcodeScannerViewModel : BaseViewModel
{
    [ObservableProperty]
    private Color frameColor;

    public BarcodeScannerViewModel() : base()
    {

        Title = Localisation_Lib.ViewTitle_BarcodeScanner;

        FrameColor = Color.Parse("#FF0000");
    }
}

