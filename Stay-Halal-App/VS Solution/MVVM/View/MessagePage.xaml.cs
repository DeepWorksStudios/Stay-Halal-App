
using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.View;

public partial class MessagePage : ContentPage
{
    #region Constructor/Destructor
    public MessagePage(MessageViewModel vm)
	{
        InitializeComponent();

        BindingContext = vm;

        Top_Bar.ViewModel.SetupTheme(Resources_Lib.HeaderTheme);
    }
    #endregion

}

