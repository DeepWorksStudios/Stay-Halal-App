using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.View;

public partial class ManualInputView : ContentPage
{
    #region Private Data
    private ManualInputViewModel ViewModel { get; set; }
    #endregion

    #region Constructor/Destructor
    public ManualInputView(ManualInputViewModel vm)
	{
		InitializeComponent();

        BindingContext = vm;
        ViewModel = vm;
        Top_Bar.ViewModel.SetupTheme(Resources_Lib.HeaderTheme);
    }
    #endregion

    #region Protected Calls
    protected override void OnAppearing()
    {
        base.OnAppearing();

        ViewModel.OnAppearing();
    }
    #endregion
}