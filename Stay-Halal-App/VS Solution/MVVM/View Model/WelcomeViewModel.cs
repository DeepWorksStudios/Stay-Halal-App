

using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.MVVM.ViewModel;

public partial class WelcomeViewModel : BaseViewModel
{

    public WelcomeViewModel() : base()
    {

        Title = Localisation_Lib.ViewTitle_Welcome;
    }
}

