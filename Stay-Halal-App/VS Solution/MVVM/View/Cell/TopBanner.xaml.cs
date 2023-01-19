using Stay_Halal.MVVM.ViewModel;

namespace Stay_Halal.Cells.Common;

public partial class TopBanner : Grid
{
    #region Private Data  
    private readonly TopBannerViewModel viewModel = new();
    #endregion

    #region Public Data
    public TopBannerViewModel ViewModel { get { return viewModel; } }
    #endregion

    #region Constructor/Destructor
    public TopBanner()
    {

        InitializeComponent();
        BindingContext = viewModel;
    }
    #endregion   
}