
using Stay_Halal.MVVM.ViewModel;

namespace Stay_Halal.MVVM.View;

public partial class MessagePage : ContentPage
{
    #region Constructor/Destructor
    public MessagePage(MessageViewModel vm)
	{
        InitializeComponent();

        BindingContext = vm;
    }
    #endregion

}

