
using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Static;
using ZXing.Net.Maui;
using ZXing.QrCode.Internal;

namespace Stay_Halal.MVVM.View;

public partial class BarcodeScannerView : ContentPage
{
    #region Private Data
    private BarcodeScannerViewModel ViewModel { get; set; }
    private bool canScan = true;
    private Color red = Color.Parse("#FF0000"), green = Color.Parse("#00FF00");
    #endregion

    #region Constructor/Destructor
    public BarcodeScannerView(BarcodeScannerViewModel vm)
	{
		InitializeComponent();

		BindingContext=vm;
        ViewModel = vm;

        Top_Bar.ViewModel.SetupTheme(Resources_Lib.HeaderTheme);

        cameraBarcodeReaderView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.All,
            AutoRotate = false,
            Multiple = true
        };
    }
    #endregion

    #region Protected Calls
    protected override void OnAppearing()
    {
        base.OnAppearing();

        cameraBarcodeReaderView.CameraLocation = CameraLocation.Front;
        cameraBarcodeReaderView.CameraLocation = CameraLocation.Rear;
        cameraBarcodeReaderView.CameraLocation = CameraLocation.Front;
        cameraBarcodeReaderView.CameraLocation = CameraLocation.Rear;
        canScan = true;

        ViewModel.FrameColor =red;
    }
    #endregion

    #region Private Calls
    private void cameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        if (!canScan) return;

        canScan = false;

        ViewModel.FrameColor = green;
        ViewModel.OnConfirmInput(e.Results[0].Value);
 
    }
    #endregion
}