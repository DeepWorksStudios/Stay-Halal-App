using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.View;

public partial class InfoView : ContentPage
{
    #region Constructor/Destructor
    public InfoView(InfoViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;

		Top_Bar.ViewModel.SetupTheme(Resources_Lib.HeaderTheme);
    }
    #endregion
}