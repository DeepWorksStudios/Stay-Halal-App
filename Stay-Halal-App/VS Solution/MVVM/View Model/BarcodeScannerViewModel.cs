

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Stay_Halal.MVVM.Model;
using Stay_Halal.MVVM.View;
using Stay_Halal.Scripts.Libraries.Dynamic;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.ViewModel;

public partial class BarcodeScannerViewModel : BaseViewModel
{
    [ObservableProperty]
    private Color frameColor;

    Scanner_Lib scanner;

    [ObservableProperty]
    private string id;


    public async void OnConfirmInput(string input)
    {

        scanner.ScanProduct(input);





    }
    

    public BarcodeScannerViewModel(Scanner_Lib _scanner) : base()
    {
        scanner = _scanner;
      
        Title = Localisation_Lib.ViewTitle_BarcodeScanner;

        FrameColor = Color.Parse("#FF0000");
 
    }
}

