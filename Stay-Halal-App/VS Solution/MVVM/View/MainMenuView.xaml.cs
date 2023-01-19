using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.View;

public partial class MainMenuView : ContentPage
{

    MainMenuViewModel ViewModel;

    public MainMenuView(MainMenuViewModel vm)
	{
		InitializeComponent();

        BindingContext = vm;
        ViewModel= vm;
        Top_Bar.ViewModel.SetupTheme(Resources_Lib.HeaderTheme);
    }

 
    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ViewModel.OnOpenFAQ(e.ItemIndex);
    }
}