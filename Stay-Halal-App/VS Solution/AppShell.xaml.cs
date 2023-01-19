using Stay_Halal.MVVM.View;
using Stay_Halal.MVVM.ViewModel;

namespace Stay_Halal;

public partial class AppShell : Shell
{
	public AppShell(AppShellViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;

        Routing.RegisterRoute(nameof(ProductDetailView), typeof(ProductDetailView));
    }
}
