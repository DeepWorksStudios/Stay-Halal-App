using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.View;

public partial class ContactView : ContentPage
{
	public ContactView(ContactViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;

        Top_Bar.ViewModel.SetupTheme(Resources_Lib.HeaderTheme);
    }
}