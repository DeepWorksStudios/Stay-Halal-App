using Stay_Halal.MVVM.ViewModel;
using Stay_Halal.Scripts.Libraries.Dynamic;

namespace Stay_Halal;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Theme_Lib.Init();
        MainPage = new AppShell(new AppShellViewModel());
	}
}
