

using CommunityToolkit.Mvvm.ComponentModel;

using Stay_Halal.Scripts.Libraries.Dynamic;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.ViewModel;

public partial class BarcodeScannerViewModel : BaseViewModel
{
    #region Private Data
    private readonly Scanner_Lib scanner;
    #endregion

    #region Observable Data
    [ObservableProperty]
    private Color frameColor;


    [ObservableProperty]
    private string id;
    #endregion

    #region Constructor/Destructor
    public BarcodeScannerViewModel(Scanner_Lib _scanner) : base()
    {
        scanner = _scanner;
      
        Title = Lokalisation_Lib.ViewTitle_BarcodeScanner;

        FrameColor = Color.Parse("#FF0000");
 
    }
    #endregion

    #region Public Calls
    public void OnConfirmInput(string input)
    {
        scanner.ScanProdukt(input);
    }
    #endregion
}

