using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.View;

public partial class ManualInputView : ContentPage
{
    private ManualInputViewModel ViewModel { get; set; }
   

    public ManualInputView(ManualInputViewModel vm)
	{
		InitializeComponent();

        BindingContext = vm;
        ViewModel = vm;
        Top_Bar.ViewModel.SetupTheme(Resources_Lib.HeaderTheme);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        ViewModel.OnAppearing();
      

       
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();


    }

    
}