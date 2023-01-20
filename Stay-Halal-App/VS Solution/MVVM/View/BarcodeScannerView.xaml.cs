
using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Static;
using ZXing.Net.Maui;
using ZXing.QrCode.Internal;

namespace Stay_Halal.MVVM.View;

public partial class BarcodeScannerView : ContentPage
{
    private BarcodeScannerViewModel ViewModel { get; set; }
    bool canScan = true;

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

    protected override void OnAppearing()
    {
        base.OnAppearing();

        cameraBarcodeReaderView.CameraLocation = CameraLocation.Front;
        cameraBarcodeReaderView.CameraLocation = CameraLocation.Rear;
        cameraBarcodeReaderView.CameraLocation = CameraLocation.Front;
        cameraBarcodeReaderView.CameraLocation = CameraLocation.Rear;
        canScan = true;

        ViewModel.FrameColor = Color.Parse("#FF0000");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();


    }
    private void cameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        if (!canScan) return;
        canScan = false;

        ViewModel.FrameColor = Color.Parse("#00FF00");

        string value = e.Results[0].Value;
        ViewModel.OnConfirmInput(value);

       
           
    }
}