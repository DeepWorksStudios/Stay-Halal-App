
using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Static;
using ZXing.Net.Maui;

namespace Stay_Halal.MVVM.View;

public partial class BarcodeScannerView : ContentPage
{
    private BarcodeScannerViewModel ViewModel { get; set; }


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

    private void cameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        ViewModel.FrameColor = Color.Parse("#00FF00");

        foreach (var barcode in e.Results)
        {
            System.Diagnostics.Debug.WriteLine($"Barcodes: {barcode.Format} -> {barcode.Value}");
            
        }
           
    }
}